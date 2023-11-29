using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGClubRaquetaSergio
{
    public partial class GestionForm : Form
    {
        int sociosStatus = 0;
        int pistasStatus = 0;
        int reservasStatus = 0;
        int idPista = 0;
        int idSocio = 0;
        int idReserva = 0;


        public GestionForm()
        {
            InitializeComponent();
        }

        private void pistasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void sociosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void pistasBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {


        }

        private void reservasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reservasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clubraquetaDataSet);

        }

        private void reservasBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.reservasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clubraquetaDataSet);

        }

        private void reservasBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.reservasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clubraquetaDataSet);

        }

        private void GestionForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'clubraquetaDataSet.socios' Puede moverla o quitarla según sea necesario.
            this.sociosTableAdapter.Fill(this.clubraquetaDataSet.socios);
            // TODO: esta línea de código carga datos en la tabla 'clubraquetaDataSet.pistas' Puede moverla o quitarla según sea necesario.
            this.pistasTableAdapter.Fill(this.clubraquetaDataSet.pistas);
            // TODO: esta línea de código carga datos en la tabla 'clubraquetaDataSet.pistas' Puede moverla o quitarla según sea necesario.
            this.pistasTableAdapter.Fill(this.clubraquetaDataSet.pistas);
            // TODO: esta línea de código carga datos en la tabla 'clubraquetaDataSet.reservas' Puede moverla o quitarla según sea necesario.
            this.reservasTableAdapter.Fill(this.clubraquetaDataSet.reservas);
            disableTXTPistas();
            disableTXTSocios();
            disableTXTReservas();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void disableTXTReservas()
        {
            txtIdReserva.Enabled = false;
            txtIdReserva.Enabled = false;
            txtDataPickerFecha.Enabled = false;
            numUpDoHorasGestion.Enabled = false;
            numUpDoMinutosGestion.Enabled = false;
            txtPistaReserva.Enabled = false;
            txtSocioReserva.Enabled = false;
            txtPagado.Enabled = false;
            txtCantidad.Enabled = false;
        }

        private void disableTXTSocios()
        {
            txtDNI.Enabled = false;
            txtNombre.Enabled = false;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtDomicilio.Enabled = false;
            txtMaskCuentaC.Enabled = false;
            txtMaskEmail.Enabled = false;
            txtMaskTelefono.Enabled = false;
        }

        private void disableTXTPistas()
        {
           txtIdPistaPista.Enabled = false;
           txtNombrePista.Enabled = false;
           txtUbicacion.Enabled = false;
           txtPrecioHora.Enabled = false; 
        }

        private void enableTXTSocios()
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtNombre.Enabled = true;
            txtDomicilio.Enabled = true;
            txtMaskCuentaC.Enabled = true;
            txtMaskEmail.Enabled = true;
            txtMaskTelefono.Enabled = true;
        }

        private void enableTXTPistas()
        {
            txtNombrePista.Enabled = true;
            txtUbicacion.Enabled = true;
            txtPrecioHora.Enabled = true;
        }

        private void enableTXTReservas()
        {
            txtDataPickerFecha.Enabled = true;
            numUpDoHorasGestion.Enabled = true; 
            numUpDoMinutosGestion.Enabled = true;
            txtPistaReserva.Enabled = true;
            txtSocioReserva.Enabled = true;
            txtPagado.Enabled = true;
            txtCantidad.Enabled = true;
        }

        private void btnModificarReserva_Click(object sender, EventArgs e)
        {
            if (reservasStatus == 0)
            {
                enableTXTReservas();
                reservasStatus = 1;
            }
            else
            {
                disableTXTReservas();
                reservasStatus = 0;

                using (clubraquetaEntities objDB = new clubraquetaEntities())
                {
                    int idReserva = int.Parse(txtIdReserva.Text);
                    reservas reservaAModificar = objDB.reservas.Find(idReserva);

                    reservaAModificar.fecha = txtDataPickerFecha.Value;

                    // Obtener los valores de horas y minutos de los controles numUpDoHoras y numUpDoMinutos
                    int horas = (int)numUpDoHorasGestion.Value;
                    int minutos = (int)numUpDoMinutosGestion.Value;

                    // Crear una cadena con el formato "hh:mm:ss"
                    string str_hora = $"{horas:D2}:{minutos:D2}:00";

                    reservaAModificar.hora = TimeSpan.Parse(str_hora);
                    reservaAModificar.pista = int.Parse(txtPistaReserva.SelectedValue.ToString());
                    reservaAModificar.socio = txtSocioReserva.SelectedValue.ToString();
                    reservaAModificar.pagado = txtPagado.Text;
                    reservaAModificar.cantidad = int.Parse(txtCantidad.Text);

                    // Guardar los cambios y obtener el número de entidades modificadas
                    int cambiosGuardados = objDB.SaveChanges();

                    if (cambiosGuardados > 0)
                    {
                        MessageBox.Show("Reserva modificada correctamente", "Modificar reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se realizaron cambios en la reserva", "Modificar reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnModificarSocio_Click(object sender, EventArgs e)
        {
            if (sociosStatus == 0)
            {
                enableTXTSocios();
                sociosStatus = 1;
            }
            else
            {
                disableTXTSocios();
                sociosStatus = 0;
                using (clubraquetaEntities objDB = new clubraquetaEntities())
                {
                    socios socioAModificar = objDB.socios.Find(txtDNI.Text);

                    socioAModificar.nombre = txtNombre.Text;
                    socioAModificar.apellidos = txtApellido.Text;
                    socioAModificar.domicilio = txtDomicilio.Text;
                    socioAModificar.cuentaCorriente = txtMaskCuentaC.Text;
                    socioAModificar.email = txtMaskEmail.Text;
                    socioAModificar.telefono = txtMaskTelefono.Text;

                    objDB.SaveChanges();
                    MessageBox.Show("Socio modificado correctamente", "Modificar socio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
         
            }
            
        }

        private void btnModificarFoto_Click(object sender, EventArgs e)
        {
            if (ofdCaratula.ShowDialog() == DialogResult.OK)
            {
                fotoPictureBox.Image = Image.FromFile(ofdCaratula.FileName);
                this.Validate();
                this.pistasBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.clubraquetaDataSet);
            }
        }

        private void btnModificarPista_Click(object sender, EventArgs e)
        {
            if(pistasStatus == 0)
            {
                enableTXTPistas();
                pistasStatus = 1;
            }
            else
            {
                disableTXTPistas();
                pistasStatus = 0;

                using (clubraquetaEntities objDB = new clubraquetaEntities())
                {
                    int idPista = int.Parse(txtIdPistaPista.Text);
                    pistas pistaAModificar = objDB.pistas.Find(idPista);

                    pistaAModificar.nombre = txtNombrePista.Text;
                    pistaAModificar.ubicacion = txtUbicacion.Text;
                    pistaAModificar.precioHora = Convert.ToDecimal(txtPrecioHora.Text);

                    objDB.SaveChanges();
                    MessageBox.Show("Pista modificada correctamente", "Modificar pista", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnBuscarPista_Click(object sender, EventArgs e)
        {
            Busquedas formulario = new Busquedas(0); //FORMULARIO MODAL

            if (formulario.ShowDialog() == DialogResult.Cancel)
            {
                idPista = formulario.idPista;
                txtPistaReserva.SelectedValue = idPista;
            }
            
        }

        private void btnBuscarReserva_Click(object sender, EventArgs e)
        {
            Busquedas formulario = new Busquedas(1); //FORMULARIO MODAL

            if (formulario.ShowDialog() == DialogResult.Cancel)
            {

            }
        }

        private void btnBuscarSocio_Click(object sender, EventArgs e)
        {
            Busquedas formulario = new Busquedas(2); //FORMULARIO MODAL

            if (formulario.ShowDialog() == DialogResult.Cancel)
            {

            }
        }

       

        private void txtPistaReserva_SelectedValueChanged(object sender, EventArgs e)
        {
            using (clubraquetaEntities objDB = new clubraquetaEntities())
            {
                pistas pistaSeleccionada = objDB.pistas.Find(txtPistaReserva.SelectedValue);

                if(pistaSeleccionada != null)
                {
                    txtNombrePista.Text = pistaSeleccionada.nombre;
                    txtUbicacion.Text = pistaSeleccionada.ubicacion;
                    txtPrecioHora.Text = pistaSeleccionada.precioHora.ToString();
                    txtIdPistaPista.Text = pistaSeleccionada.idPista.ToString();

                    var todasReservasDePista = from res in objDB.reservas
                                               where res.pista == pistaSeleccionada.idPista
                                               select res;

                    dataGridGestion.DataSource = todasReservasDePista.ToList();
                    //dataGridGestion.Columns[4].Visible = false;
                    dataGridGestion.Columns[7].Visible = false;
                    dataGridGestion.Columns[8].Visible = false;

                    //Gescion de horas y minutos en los campos reserva

                    if(txtIdReserva.Text != "")
                    {
                        int idReserva = int.Parse(txtIdReserva.Text);

                        reservas objReserva = objDB.reservas.Find(idReserva);
                        numUpDoHorasGestion.Value = objReserva.hora.Hours;
                        numUpDoMinutosGestion.Value = objReserva.hora.Minutes;
                    }
                }
            }
        }

        private void txtSocioReserva_SelectedValueChanged(object sender, EventArgs e)
        {
            using (clubraquetaEntities objDB = new clubraquetaEntities())
            {
                socios socioSeleccionado = objDB.socios.Find(txtSocioReserva.SelectedValue);

                if (socioSeleccionado != null)
                {
                    txtDNI.Text = socioSeleccionado.DNI;
                    txtNombre.Text = socioSeleccionado.nombre;
                    txtApellido.Text = socioSeleccionado.apellidos;
                    txtDomicilio.Text = socioSeleccionado.domicilio;
                    txtMaskCuentaC.Text = socioSeleccionado.cuentaCorriente;
                    txtMaskEmail.Text = socioSeleccionado.email;
                    txtMaskTelefono.Text = socioSeleccionado.telefono;
                }
            }


        }

    }
}
