using SGClubRaquetaSergio.clubraquetaDataSetTableAdapters;
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
    public partial class BorradoForm : Form
    {
        public string id { get; set; }
        public int tipo { get; set; }

        public BorradoForm(string id, int tipo)
        {
            InitializeComponent();
            this.id = id;
            this.tipo = tipo;
        }

        private void BorradoForm_Load(object sender, EventArgs e)
        {
            using (clubraquetaEntities objDB = new clubraquetaEntities())
            {

                //cargarCombosAdo();
                cargarCombosEntity();

                if (tipo == 0) // Reservas
                {
                    reservasYSusRelaciones(id);                  
                }
                else if (tipo == 1) //Pista
                {
                    pistaYSusRelaciones(id);
                }
                else if (tipo == 2) //Socio
                {
                    socioYSusRelaciones(id);
                }
            }

            gestionDeHabilitadoDeBotones(txtDNI.Text);
        }


        public void cargarCombosEntity()
        {
            // PISTAS
            using (clubraquetaEntities objDB = new clubraquetaEntities())
            {
                var pistas = from p in objDB.pistas
                             select p;

                cboPistas.Items.Clear();

                foreach (var p in pistas)
                {
                    ComboItemPistas comboItem = new ComboItemPistas(p.idPista, p.nombre, p.ubicacion);
                    cboPistas.Items.Add(comboItem);
                }
            }

            // RESERVAS
            using (clubraquetaEntities objDB = new clubraquetaEntities())
            {
                var reservas = from r in objDB.reservas
                               from p in objDB.pistas
                               where r.pista == p.idPista
                               select new { r.fecha, p.nombre, r.idReserva };

                cboReservas.Items.Clear();

                foreach (var res in reservas)
                {
                    ComboItemReservaBorrado comboItem = new ComboItemReservaBorrado(res.fecha, res.nombre, res.idReserva);
                    cboReservas.Items.Add(comboItem);
                }
            }

            // SOCIOS
            using (clubraquetaEntities objDB = new clubraquetaEntities())
            {
                var socios = from s in objDB.socios
                             select s;

                cboSocios.Items.Clear();

                foreach (var s in socios)
                {
                    ComboItemSocio comboItem = new ComboItemSocio(s.DNI, s.nombre, s.telefono);
                    cboSocios.Items.Add(comboItem);
                }
            }

        }

        public void cargarCombosAdo()
        {
            // PISTAS
            clubraquetaDataSet dsDB = new clubraquetaDataSet();
            pistasTableAdapter pistasAdapter = new pistasTableAdapter();
            pistasAdapter.Fill(dsDB.pistas);

            cboPistas.Items.Clear();

            foreach (var p in dsDB.pistas)
            {
                ComboItemPistas comboItem = new ComboItemPistas(p.idPista, p.nombre, p.ubicacion);
                cboPistas.Items.Add(comboItem);
            }

            // RESERVAS - Tiene su nuevo tableadapter en la base de datos que mezcla dos tablas
            comboItemReservasBorradoDataSetTableAdapter comboItemReservasAdapter = new comboItemReservasBorradoDataSetTableAdapter();
            comboItemReservasAdapter.FillFechaNombrePistaIdReserva(dsDB.comboItemReservasBorradoDataSet);

            cboReservas.Items.Clear();

            foreach (var r in dsDB.comboItemReservasBorradoDataSet)
            {
                //var fechaFormateada = r.fecha.ToString("dd/MM/yyyy"); // DateTime no acepta un formateo de la fecha sin la hora, así que si lo quieres el tipo de dato de entrada deberá ser string
                ComboItemReservaBorrado comboItem = new ComboItemReservaBorrado(r.fecha, r.nombre, r.idReserva);
                cboReservas.Items.Add(comboItem);
            }

            // SOCIOS
            sociosTableAdapter sociosAdapter = new sociosTableAdapter();
            sociosAdapter.Fill(dsDB.socios);

            cboSocios.Items.Clear();

            foreach (var r in dsDB.socios)
            {
                ComboItemSocio comboItem = new ComboItemSocio(r.DNI, r.nombre, r.telefono);
                cboSocios.Items.Add(comboItem);
            }
        }



        private void sociosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void btnPagarTodo_Click(object sender, EventArgs e) // UPDATE MASIVO CON ENTITY
        {
            using (clubraquetaEntities objDB = new clubraquetaEntities())
            {
                // Buscar todas las reservas del socio que tengan el estado de pago "NO"
                var reservasNoPagadas = objDB.reservas
                    .Where(r => r.socio == txtDNI.Text && r.pagado == "NO")
                    .ToList();

                // Actualizar el estado de pago a "SI" para todas las reservas encontradas
                foreach (var reserva in reservasNoPagadas)
                {
                    reserva.pagado = "SI";
                }

                // Guardar los cambios en la base de datos
                objDB.SaveChanges();

                // Realizar otras operaciones si es necesario después de actualizar
            }
            gestionDeHabilitadoDeBotones(txtDNI.Text);
            reservasYSusRelaciones(txtDNI.Text);
        }

        private void btnEliminarReservasSocio_Click(object sender, EventArgs e)
        {
            using (clubraquetaEntities objDB = new clubraquetaEntities())
            {
                // Buscar el socio por su DNI
                var socio = objDB.socios.SingleOrDefault(s => s.DNI == txtDNI.Text);

                if (socio != null)
                {
                    // Obtener todas las reservas asociadas al socio
                    var reservasASuprimir = objDB.reservas.Where(r => r.socio == socio.DNI).ToList();

                    // Borrar las reservas
                    objDB.reservas.RemoveRange(reservasASuprimir);

                    // Guardar los cambios en la base de datos
                    objDB.SaveChanges();

                    // Realizar otras operaciones si es necesario después de borrar las reservas
                }
                else
                {
                    MessageBox.Show("No se ha encontrado al socio");
                }
            }

            gestionDeHabilitadoDeBotones(txtDNI.Text);
            socioYSusRelaciones(txtDNI.Text);
        }

        private void btnEliminarSocio_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarReservasPistas_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEliminarPista_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarReservaReserva_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridViewRReservas_SelectionChanged(object sender, EventArgs e)
        {
            id = dataGridViewRReservas.CurrentRow.Cells[0].Value.ToString();
        }

        private void dataGridViewSSocios_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewSSocios.Rows.Count > 0) //Contamos la cantidad de lineas primero
            {
                txtDNI.Text = dataGridViewSSocios.CurrentRow.Cells[0].Value.ToString(); //dni
                txtNombre.Text = dataGridViewSSocios.CurrentRow.Cells[1].Value.ToString(); //nombre
                txtApellido.Text = dataGridViewSSocios.CurrentRow.Cells[2].Value.ToString(); //apellido
            }

        }

        private void dataGridViewPPistas_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewPPistas.Rows.Count > 0)
            {
                txtIdPistaPista.Text = dataGridViewPPistas.CurrentRow.Cells[0].Value.ToString(); //idPista
                txtNombrePista.Text = dataGridViewPPistas.CurrentRow.Cells[1].Value.ToString(); //nombre
                txtUbicacion.Text = dataGridViewPPistas.CurrentRow.Cells[2].Value.ToString(); //ubicación
            }

        }



        private void cboSocios_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (clubraquetaEntities objDB = new clubraquetaEntities())
            {
                var selectedComboItem = (ComboItemSocio)cboSocios.SelectedItem; //IMPORTANTE!! RECUERDA QUE LOS CASTEOS Y OTRAS HISTORIAS NO PUEDES HACERLOS
                                                                                // DENTRO DE LA CONSULTA POR ESO SE HACE PREVIAMENTE
                socioYSusRelaciones(selectedComboItem.Dni);
                gestionDeHabilitadoDeBotones(selectedComboItem.Dni);
            }
        }


        private void cboPistas_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (clubraquetaEntities objDB = new clubraquetaEntities())
            {
                var selectedComboItem = (ComboItemPistas)cboPistas.SelectedItem; //IMPORTANTE!! RECUERDA QUE LOS CASTEOS Y OTRAS HISTORIAS NO PUEDES HACERLOS
                                                                                // DENTRO DE LA CONSULTA POR ESO SE HACE PREVIAMENTE
                pistaYSusRelaciones(selectedComboItem.IdPista.ToString());
            }

        }

        private void cboReservas_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (clubraquetaEntities objDB = new clubraquetaEntities())
            {
                var selectedComboItem = (ComboItemReservaBorrado)cboReservas.SelectedItem; //IMPORTANTE!! RECUERDA QUE LOS CASTEOS Y OTRAS HISTORIAS NO PUEDES HACERLOS
                                                                                         // DENTRO DE LA CONSULTA POR ESO SE HACE PREVIAMENTE
                reservasYSusRelaciones(selectedComboItem.IdReserva.ToString());
            }
        }


        private void socioYSusRelaciones(string id)
        {
            using (clubraquetaEntities objDB = new clubraquetaEntities())
            {
                var socio = from s in objDB.socios
                            where s.DNI == id.ToString()
                            select s;

                // forma 1: Convertir la select en lista y extraer los atributos de ahí
                var textosSocio = socio.ToList();

                txtNombre.Text = textosSocio[0].nombre.ToString();
                txtDNI.Text = textosSocio[0].DNI.ToString();
                txtApellido.Text = textosSocio[0].apellidos.ToString();

                dataGridViewSSocios.DataSource = socio.ToList();
                dataGridViewSSocios.Columns[0].Visible = false; //dni
                dataGridViewSSocios.Columns[1].Visible = false; //nombre
                dataGridViewSSocios.Columns[2].Visible = false; //apellido
                dataGridViewSSocios.Columns[7].Visible = false; //reservas

                var reservas = from s in objDB.socios
                               from r in objDB.reservas
                               where s.DNI == r.socio
                               where s.DNI == id
                               select new
                               {
                                   r.idReserva,
                                   r.pista,
                                   r.fecha,
                                   r.cantidad,
                                   r.pagado,
                                   s.apellidos,
                                   s.nombre,
                                   s.telefono
                               };
                dataGridViewRReservas.DataSource = reservas.ToList();
                dataGridViewRReservas.Columns[0].Visible = false; //idReserva


                var pistas = from r in reservas
                             from p in objDB.pistas
                             where r.pista == p.idPista
                             select new
                             {
                                 p.idPista,
                                 p.nombre,
                                 p.ubicacion,
                                 p.precioHora,
                                 r.pagado,
                                 r.cantidad,
                                 r.fecha
                             };
                dataGridViewPPistas.DataSource = pistas.ToList();
                dataGridViewPPistas.Columns[0].Visible = false; //idPista
                dataGridViewPPistas.Columns[1].Visible = false; //nombre
                dataGridViewPPistas.Columns[2].Visible = false; //reservas

                //forma 2: En la select sacar los datos que te interen, ocultarlos(si quieres) y cogerlos desde las celdas
                if(dataGridViewPPistas.Rows.Count > 0)
                {
                    txtIdPistaPista.Text = dataGridViewPPistas.Rows[0].Cells[0].Value.ToString(); //idPista
                    txtNombrePista.Text = dataGridViewPPistas.Rows[0].Cells[1].Value.ToString(); //nombre
                    txtUbicacion.Text = dataGridViewPPistas.Rows[0].Cells[2].Value.ToString(); //ubicación
                }
            }
        }

        private void pistaYSusRelaciones(string id)
        {
            using (clubraquetaEntities objDB = new clubraquetaEntities())
            {
                var pista = from p in objDB.pistas
                            where p.idPista.ToString() == id
                            select p;
                dataGridViewPPistas.DataSource = pista.ToList();

                // forma 1: Convertir la select en lista y extraer los atributos de ahí


                if(dataGridViewSSocios.Rows.Count > 0)
                {
                    dataGridViewSSocios.Columns[0].Visible = false; //dni
                    dataGridViewSSocios.Columns[1].Visible = false; //nombre
                    dataGridViewSSocios.Columns[2].Visible = false; //apellido
                    dataGridViewSSocios.Columns[7].Visible = false; //reservas
                }
                

                var reservas = from s in objDB.socios
                               from r in objDB.reservas
                               where s.DNI == r.socio
                               where s.DNI == id
                               select new
                               {
                                   r.idReserva,
                                   r.pista,
                                   r.fecha,
                                   r.cantidad,
                                   r.pagado,
                                   s.apellidos,
                                   s.nombre,
                                   s.telefono

                               };
                dataGridViewRReservas.DataSource = reservas.ToList();
                dataGridViewRReservas.Columns[0].Visible = false; //idReserva
                dataGridViewRReservas.Columns[1].Visible = false; //idPista

                var idInt = int.Parse(id);

                var pistas = from r in reservas
                             from p in objDB.pistas
                             where r.pista == p.idPista
                             where p.idPista == idInt
                             select new
                             {
                                 p.idPista,
                                 p.nombre,
                                 p.ubicacion,
                                 p.precioHora,
                                 r.pagado,
                                 r.cantidad,
                                 r.fecha
                             };
                dataGridViewPPistas.DataSource = pistas.ToList();

                if (dataGridViewPPistas.Rows.Count > 0)
                {
                    dataGridViewPPistas.Columns[0].Visible = false; //idPista
                    dataGridViewPPistas.Columns[1].Visible = false; //nombre
                    dataGridViewPPistas.Columns[2].Visible = false; //reservas
                }

                //forma 2: En la select sacar los datos que te interen, ocultarlos(si quieres) y cogerlos desde las celdas
                if(dataGridViewRReservas.Rows.Count > 0)
                {
                    txtIdPistaPista.Text = dataGridViewPPistas.Rows[0].Cells[0].Value.ToString(); //idPista
                    txtNombrePista.Text = dataGridViewPPistas.Rows[0].Cells[1].Value.ToString(); //nombre
                    txtUbicacion.Text = dataGridViewPPistas.Rows[0].Cells[2].Value.ToString(); //ubicación
                }
            }
        }


        private void reservasYSusRelaciones(string id)
        {
            using (clubraquetaEntities objDB  = new clubraquetaEntities())
            {
                var reserva = from r in objDB.reservas
                              where r.socio.ToString() == id
                              select r;

                dataGridViewRReservas.DataSource = reserva.ToList();
                dataGridViewRReservas.Columns[0].Visible = false; //idReserva
                dataGridViewRReservas.Columns[7].Visible = false; //idPistas
                dataGridViewRReservas.Columns[8].Visible = false; //idSocios

            }
            
        }


        
        private Boolean socioEsMoroso(string dni) //ADO.NET
        {                                       
            Boolean esMoroso = false;
            reservasTableAdapter reservasTableAdapter = new reservasTableAdapter();

            var cantidadSinPagar = (int)reservasTableAdapter.CountSinPagarByDni(dni);

            if (cantidadSinPagar > 0)
            {
                esMoroso = true;
            }
            return esMoroso;
        }

        private Boolean socioTieneReservas(string dni) //ADO.NET
        {
            Boolean tieneReserva = false;
            reservasTableAdapter reservasTableAdapter = new reservasTableAdapter();

            var pistasSocioReservadas = reservasTableAdapter.CountPistasByDniSocio(dni);

            if (pistasSocioReservadas > 0)
            {
                tieneReserva = true;
            }

            return tieneReserva;

        }

        private void gestionDeHabilitadoDeBotones(string dni)
        {
            if(!socioEsMoroso(dni))
            {
                btnEliminarReservasSocio.Enabled = true;
            }
            else
            {
                btnEliminarReservasSocio.Enabled = false;
            }
            if (!socioTieneReservas(dni))
            {
                btnEliminarSocio.Enabled = true;
            }
            else
            {
                btnEliminarSocio.Enabled = false;
            }
            
        }

        private void btnPagarReservaBorrado_Click(object sender, EventArgs e) //UPDATE UNICO CON ENTITY
        {
            using (clubraquetaEntities objDB = new clubraquetaEntities())
            {
                if (id != null)
                {
                    int idReservaInt = int.Parse(id);// Como siempre hacemos conversiones y otros antes de la consulta                           

                    var reserva = objDB.reservas.SingleOrDefault(r => r.idReserva == idReservaInt);

                    if (reserva != null)
                    {
                        // Actualizar el campo "Pagado" a "SI"
                        reserva.pagado = "SI";

                        // Guardar los cambios en la base de datos
                        objDB.SaveChanges();

                        // Realizar otras operaciones si es necesario después de actualizar
                    }
                    else
                    {
                        // Manejar el caso en el que la reserva no fue encontrada
                        // Puedes mostrar un mensaje, lanzar una excepción, etc.
                    }
                }
            }
            gestionDeHabilitadoDeBotones(txtDNI.Text);
            socioYSusRelaciones(txtDNI.Text);
        }
    }
}
