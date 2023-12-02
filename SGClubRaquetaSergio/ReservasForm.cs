using SGClubRaquetaSergio.clubraquetaDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGClubRaquetaSergio
{
    public partial class ReservasForm : Form
    {
        int idPista = 0;
        string dniSocio = "";
        int idReserva = 0;
        public ReservasForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            clubraquetaDataSet dsDB = new clubraquetaDataSet();
            sociosTableAdapter sociosTableAdapter = new sociosTableAdapter();
            reservasTableAdapter reservasTA = new reservasTableAdapter();

            var comboItem = (ComboItemRevervas)cboSocio.SelectedItem;

            dniSocio = comboItem.Dni;

            sociosTableAdapter.FillByDNI(dsDB.socios,dniSocio);

            if(dsDB.socios != null)
            {
                var socio = dsDB.socios[0];
                txtNombre.Text = socio.nombre;
                txtApellidos.Text = socio.apellidos;
                txtTelefono.Text = socio.telefono;
                txtDireccion.Text = socio.domicilio;
                txtCCC.Text = socio.cuentaCorriente;
                txtEmail.Text = socio.email;
                lblRespuestaDniSocio.Text = socio.DNI;
            }

            reservasTA.FillAllByDniSocio(dsDB.reservas, dniSocio);
            dataGridViewReservas.DataSource = dsDB.reservas;
            dataGridViewReservas.Columns[0].Visible = false;

        }

        private void ReservasForm_Load(object sender, EventArgs e)
        {
            cargarComboSocio();
            cargarComboPistas();
            dateTimePickerReservas.MinDate = DateTime.Today;
            dateTimePickerReservas.Format = DateTimePickerFormat.Custom;
            dateTimePickerReservas.CustomFormat = "dd/MM/yyyy";

        }


        private void cargarComboSocio()
        {

            cboSocio.Items.Clear();
            
            clubraquetaDataSet dsDB = new clubraquetaDataSet();

            sociosTableAdapter sociosTableAdapter = new sociosTableAdapter();
            sociosTableAdapter.FillAllOrderByApellido(dsDB.socios);

            foreach (var socio in dsDB.socios)
            {
                ComboItemRevervas comboItem = new ComboItemRevervas(socio.apellidos, socio.nombre,socio.DNI);
                cboSocio.Items.Add(comboItem);
            }
        }

        private void cargarComboPistas()
        {

            cboPistaReservas.Items.Clear();

            clubraquetaDataSet dsDB = new clubraquetaDataSet();

            pistasTableAdapter pistasTableAdapter = new pistasTableAdapter();
            pistasTableAdapter.FillAllOrderByNombre(dsDB.pistas);

            foreach (var pista in dsDB.pistas)
            {
                cboPistaReservas.Items.Add(pista.nombre.ToString());
            }

        }


        private void btnReservar_Click(object sender, EventArgs e)
        {
            //if (socioTieneReserva())
            //{
            //    MessageBox.Show("El socio ya tiene una reserva hecha y no puedo reservar mas");
            //    return;
            //}
            if (socioEsMoroso())
            {
                MessageBox.Show("El socio tiene una reserva sin pagar y no puedo reservar");
                return;
            }
            if (!pistaEstaLibre())
            {
                MessageBox.Show("La pista ya tiene una reserva para esa hora", "Elija otra hora");
                return;
            }

            if(lblRespuestaDniSocio.Text != "")
            {
                clubraquetaDataSet dsDB = new clubraquetaDataSet();
                reservasTableAdapter reservasTA = new reservasTableAdapter();

                // Obtener los valores de horas y minutos de los controles numUpDoHoras y numUpDoMinutos
                int horas = (int)numUpDoHoras.Value;
                int minutos = (int)numUpDoMinutos.Value;

                // Crear una cadena con el formato "hh:mm:ss"
                string str_hora = $"{horas:D2}:{minutos:D2}:00";

                // Convertir la cadena a un valor de tipo TimeSpan
                TimeSpan hora = DateTime.Parse(str_hora).TimeOfDay;

                var coste = calcularPrecio();

                DialogResult rs = MessageBox.Show("¿Desea alquilarla?", "Pista disponible", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (rs == DialogResult.Yes)
                {
                    reservasTA.InsertReserva(dateTimePickerReservas.Value.Date.ToString(), str_hora, idPista, lblRespuestaDniSocio.Text, "NO", coste);
                    MessageBox.Show("Pista reservada con éxito", "Gracias!");
                    comboBox1_SelectedIndexChanged(sender, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("Reserva cancelada");
                }
            }
            else
            {
                MessageBox.Show("Primero debe seleccionar un socio");
            }
        }

        private void cboPistaReservas_SelectedIndexChanged(object sender, EventArgs e)
        {

            clubraquetaDataSet dsDB = new clubraquetaDataSet();
            pistasTableAdapter pistasTableAdapter = new pistasTableAdapter();

            var nombrePista = cboPistaReservas.SelectedItem.ToString();
            pistasTableAdapter.FillAllByNombrePista(dsDB.pistas,nombrePista);
            
            if(dsDB.pistas != null)
            {
                // Aprovechamos para coger el id de la pista
                idPista = dsDB.pistas[0].idPista;

                // Asumiendo que la columna "foto" es de tipo byte[]
                byte[] imagenBytes = dsDB.pistas[0].foto;

                // Convertir bytes a imagen
                using (MemoryStream ms = new MemoryStream(imagenBytes))
                {
                    pictureBoxReservas.Image = Image.FromStream(ms);
                }
            }
            else
            {
                MessageBox.Show("No hay pista seleccionada");
            }

            

        }

        private Boolean socioTieneReserva()
        {
            Boolean tieneReserva = false;
            reservasTableAdapter reservasTableAdapter = new reservasTableAdapter();

            var pistasSocioReservadas = reservasTableAdapter.CountPistasByDniSocio(dniSocio);
            
            if(pistasSocioReservadas > 0)
            {
                tieneReserva = true;
            }

            return tieneReserva;
        }


        private Boolean socioEsMoroso()
        {
            Boolean esMoroso = false;
            reservasTableAdapter reservasTableAdapter = new reservasTableAdapter();

            var cantidadSinPagar = (int)reservasTableAdapter.CountSinPagarByDni(dniSocio);

            if (cantidadSinPagar > 0)
            {
                esMoroso = true;
            }

            return esMoroso;

        }

        private bool pistaEstaLibre()
        {
            bool estaLibre = false;
            clubraquetaDataSet dsDB = new clubraquetaDataSet();
            reservasTableAdapter reservasTableAdapter = new reservasTableAdapter();

            var fecha = dateTimePickerReservas.Value.Date.ToString();

                reservasTableAdapter.FillAllByIdPistaYFecha(dsDB.reservas, idPista,fecha);

                if (dsDB.reservas != null && dsDB.reservas.Count > 0)
                {
                    foreach (var item in dsDB.reservas)
                    {
                        // Obtener la duración de la reserva existente
                        TimeSpan duracionReservaExistente = item.hora;

                        // Crear una nueva instancia de TimeSpan con los valores de numUpDoHoras y numUpDoMinutos
                        TimeSpan nuevaHora = new TimeSpan((int)numUpDoHoras.Value, (int)numUpDoMinutos.Value, 0);

                        // Sumar 1 hora y 30 minutos para obtener la hora de entrega estimada
                        TimeSpan tiempoReserva = new TimeSpan(1, 30, 0);
                        TimeSpan horaEntregaEstimada = nuevaHora + tiempoReserva;

                        // Verificar si la nueva reserva se solapa con alguna reserva existente
                        if ((nuevaHora >= item.hora && nuevaHora < item.hora.Add(tiempoReserva)) || (horaEntregaEstimada > item.hora && horaEntregaEstimada <= item.hora.Add(tiempoReserva)))
                        {
                            estaLibre = false;
                            break; // Salir del bucle si hay una superposición
                        }
                        else
                        {
                            estaLibre = true;
                        }
                    }

                }
                else
                {
                    estaLibre = true;
                }
           
            return estaLibre;
        }

        private decimal calcularPrecio()
        {
            clubraquetaDataSet dsDB = new clubraquetaDataSet();
            pistasTableAdapter reservasTableAdapter = new pistasTableAdapter();

            reservasTableAdapter.FillAllByIdPista(dsDB.pistas, idPista);
            
            decimal precioHoraPista = dsDB.pistas[0].precioHora;
            decimal mediaHora = precioHoraPista / 2;

            decimal costeTotal = precioHoraPista + mediaHora;
            return costeTotal;
        }

        private void bntPagar_Click(object sender, EventArgs e)
        {
            clubraquetaDataSet dsDB = new clubraquetaDataSet();
            reservasTableAdapter reservasTA = new reservasTableAdapter();

            reservasTA.UpdatePagadoByIdReserva("SI", idReserva);
            comboBox1_SelectedIndexChanged(sender, EventArgs.Empty);
        }

        private void dataGridViewReservas_SelectionChanged(object sender, EventArgs e)
        {
            clubraquetaDataSet dsDB = new clubraquetaDataSet();
            reservasTableAdapter reservasTA = new reservasTableAdapter();

            if(dataGridViewReservas.SelectedRows.Count > 0)
            {
                // Obtén el valor de la celda en la columna con índice 0 (puedes ajustar el índice según tus necesidades)
                idReserva = (int)dataGridViewReservas.SelectedRows[0].Cells[0].Value;
            }
   
        }
    }
}