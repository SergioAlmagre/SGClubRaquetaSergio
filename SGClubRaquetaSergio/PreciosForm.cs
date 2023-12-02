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
    public partial class PreciosForm : Form
    {
        private static PreciosForm preciosFormSingleton;

        int idPista = 0;
        private PreciosForm()
        {
            InitializeComponent();  
        }

        public static PreciosForm getInstance()
        {
            if (preciosFormSingleton == null)
            {
                preciosFormSingleton = new PreciosForm();
            }
            return preciosFormSingleton;
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            string idPistaString = dataGridPrecios.CurrentRow.Cells[0].Value.ToString();
            idPista = int.Parse(idPistaString);
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) //ENTITY
        {
            
            using (clubraquetaEntities objDB = new clubraquetaEntities())
            {
                var pistaSeleccionada = objDB.pistas.Find(idPista);

                PrecioInputForm formulario = new PrecioInputForm(pistaSeleccionada); //FORMULARIO MODAL

                if (formulario.ShowDialog() == DialogResult.Cancel)
                {
                    cargarDataGridPrecios();
                }

            }

            
        }

        private void PreciosForm_Load(object sender, EventArgs e)
        {
            cargarDataGridPrecios();
        }

        private void cargarDataGridPrecios() //ADO.NET
        {
            clubraquetaDataSet dsDB = new clubraquetaDataSet();
            pistasTableAdapter pistasTable = new pistasTableAdapter();

            pistasTable.Fill(dsDB.pistas);
            dataGridPrecios.DataSource = dsDB.pistas;
        }

        private void btnVolverPrecios_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
