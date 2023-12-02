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
    public partial class PrecioInputForm : Form
    {
        pistas pista;
        public PrecioInputForm(pistas pista)
        {
            InitializeComponent();
            this.pista = pista;
        }

        private void PrecioInputForm_Load(object sender, EventArgs e)
        {
            lblNombrePista.Text = pista.nombre.ToString();
            numericUpDown.Value = (int)pista.precioHora;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (clubraquetaEntities objDB = new clubraquetaEntities())
            {
                var nuevaPista = objDB.pistas.Find(pista.idPista);
                nuevaPista.precioHora = numericUpDown.Value;

                MessageBox.Show("Precio insertado correctamente");
                objDB.SaveChanges();
                Close();
            }
        }
    }
}
