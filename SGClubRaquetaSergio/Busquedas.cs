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
    public partial class Busquedas : Form
    {
        public int tipo = 0; //0 = pistas, 1 = reservas, 2 = socios
        public int idAlquiler { get; set; }
        public int idPista { get; set; }
        public int idSocio { get; set; }

        public Busquedas(int tipo)
        {
            InitializeComponent();
            this.tipo = tipo;
        }

        private void Busquedas_Load(object sender, EventArgs e)
        {

           
        }

        private void Busquedas_Load_1(object sender, EventArgs e)
        {
            if (tipo == 0)
            {
                this.Text = "Búsqueda de pistas";
                this.pistasTableAdapter1.Fill(this.clubraquetaDataSet1.pistas);
                dataGridBusquedas.DataSource = this.clubraquetaDataSet1.pistas;
            }
            else if (tipo == 1)
            {
                this.Text = "Búsqueda de reservas";
                this.reservasTableAdapter1.Fill(this.clubraquetaDataSet1.reservas);
                dataGridBusquedas.DataSource = this.clubraquetaDataSet1.reservas;
            }
            else if (tipo == 2)
            {
                this.Text = "Búsqueda de socios";
                this.sociosTableAdapter1.Fill(this.clubraquetaDataSet1.socios);
                dataGridBusquedas.DataSource = this.clubraquetaDataSet1.socios;
            }
        }

        private void dataGridBusquedas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(tipo == 0)
            {
                idPista = Convert.ToInt32(dataGridBusquedas.CurrentRow.Cells[0].Value);
                this.Close();
            }
            else if(tipo == 1)
            {
                idAlquiler = Convert.ToInt32(dataGridBusquedas.CurrentRow.Cells[0].Value);
                this.Close();
            }
            else if(tipo == 2)
            {
                idSocio = Convert.ToInt32(dataGridBusquedas.CurrentRow.Cells[0].Value);
                this.Close();
            }
        }
    }
}
