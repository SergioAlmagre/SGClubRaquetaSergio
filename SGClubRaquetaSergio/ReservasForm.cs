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
        public ReservasForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            clubraquetaDataSet dsDB = new clubraquetaDataSet();
            sociosTableAdapter sociosTableAdapter = new sociosTableAdapter();

            var comboItem = (ComboItemRevervas)cboSocio.SelectedItem;
            var dniSocio = comboItem.Dni;

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

        }

        private void cboPistaReservas_SelectedIndexChanged(object sender, EventArgs e)
        {

            clubraquetaDataSet dsDB = new clubraquetaDataSet();
            pistasTableAdapter pistasTableAdapter = new pistasTableAdapter();

            var nombrePista = cboPistaReservas.SelectedItem.ToString();
            pistasTableAdapter.FillAllByNombrePista(dsDB.pistas,nombrePista);

            // Asumiendo que la columna "foto" es de tipo byte[]
            byte[] imagenBytes = dsDB.pistas[0].foto;

            // Convertir bytes a imagen
            using (MemoryStream ms = new MemoryStream(imagenBytes))
            {
                pictureBoxReservas.Image = Image.FromStream(ms);
            }

        }
    }
}
