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
    public partial class PistasForm : Form
    {
        public PistasForm()
        {
            InitializeComponent();
        }

        private void pistasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pistasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clubraquetaDataSet);

        }

        private void pistasBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.pistasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clubraquetaDataSet);

        }

        private void PistasForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'clubraquetaDataSet.pistas' Puede moverla o quitarla según sea necesario.
            this.pistasTableAdapter.Fill(this.clubraquetaDataSet.pistas);

        }

        private void btnNuevaFoto_Click(object sender, EventArgs e)
        {
            if (ofdCaratula.ShowDialog() == DialogResult.OK)
            {
                fotoPictureBox.Image = Image.FromFile(ofdCaratula.FileName);
                this.Validate();
                this.pistasBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.clubraquetaDataSet);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("¿Estás seguro?", "Eliminar el alumno", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (rs == DialogResult.Yes)
            {

                reservasTableAdapter reservasAdapter = new reservasTableAdapter();
                pistasTableAdapter pistasAdapter = new pistasTableAdapter();


                // Check if the alumno has a related curso
                bool pistaTieneReserva = false;

                int idPista = int.Parse(pistasBindingNavigator.PositionItem.Text);


                if (reservasAdapter.CountByIdPista(idPista) > 0)
                {
                    pistaTieneReserva = true;
                };

                if (pistaTieneReserva)
                {
                    MessageBox.Show("La pista elegida tiene reservas en curso, No se puede borrar");
                }
                else
                {
                    pistasAdapter.DeleteByIdPista(idPista);
                    MessageBox.Show("Pista borrada");
                    cargarDatos();
                }
            }
        }

        private void cargarDatos()
        {
            this.pistasTableAdapter.Fill(this.clubraquetaDataSet.pistas);
        }
    }
}
