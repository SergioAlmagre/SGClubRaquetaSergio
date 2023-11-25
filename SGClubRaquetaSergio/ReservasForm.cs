using SGClubRaquetaSergio.clubraquetaDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        
    }
}
