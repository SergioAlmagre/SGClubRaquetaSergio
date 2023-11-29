using SGClubRaquetaSergio.clubraquetaDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGClubRaquetaSergio
{
    public partial class Busquedas : Form
    {
        public int tipo = 0; //0 = pistas, 1 = reservas, 2 = socios
        public int idReserva { get; set; }
        public int idPista { get; set; }
        public int idSocio { get; set; }

        public Busquedas()
        {
            InitializeComponent();
        }

        private void Busquedas_Load(object sender, EventArgs e)
        {

        }

        private void Busquedas_Load_1(object sender, EventArgs e)
        {
  
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
                idReserva = Convert.ToInt32(dataGridBusquedas.CurrentRow.Cells[1].Value);
                this.Close();
            }
            else if(tipo == 2)
            {
                idSocio = Convert.ToInt32(dataGridBusquedas.CurrentRow.Cells[2].Value);
                this.Close();
            }
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            //List<String> lista = new List<String>();
            //lista.Add("HOla");
            //lista.Add("Como estas");
            //lista.Add("Adios");
            //MessageBox.Show(lista.CantidadElementos());
            string ruta = "";
            if (sfdRuta.ShowDialog() == DialogResult.OK)
            {
                ruta = sfdRuta.FileName;
            }

            //METER EL CONTENIDO DEL DATAGRIDVIEW A UN FICHERO XML
            var dataset = dataGridBusquedas.ObtenerDataSet(); 
            StreamWriter stw = new StreamWriter (ruta + ".xml");
            dataset.WriteXml (stw);
            MessageBox.Show("Archivo guardado correctamente");
           
        }

        private void rboSocios_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "Búsqueda de socios";
            this.sociosTableAdapter1.Fill(this.clubraquetaDataSet1.socios);
            dataGridBusquedas.DataSource = this.clubraquetaDataSet1.socios;
        }

        private void rboPistas_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "Búsqueda de pistas";
            this.pistasTableAdapter1.Fill(this.clubraquetaDataSet1.pistas);
            dataGridBusquedas.DataSource = this.clubraquetaDataSet1.pistas;
        }

        private void rboReservas_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "Búsqueda de reservas";
            this.reservasTableAdapter1.Fill(this.clubraquetaDataSet1.reservas);
            dataGridBusquedas.DataSource = this.clubraquetaDataSet1.reservas;
            
        }
        private void rboTodasFuentes_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "Todo";
            realizarBusquedaFiltros();
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            realizarBusquedaFiltros();
        }

        private void realizarBusquedaFiltros()
        {
            using (clubraquetaEntities objDB = new clubraquetaEntities())
            {
                var todosDatos = from p in objDB.pistas
                                 from s in objDB.socios
                                 from r in objDB.reservas
                                 where p.idPista == r.pista
                                 where r.socio == s.DNI
                                 select new
                                 {
                                     IdPista = p.idPista,
                                     IdReserva = r.idReserva,
                                     DNI = s.DNI,
                                     Apellidos = s.apellidos,
                                     Nombre = s.nombre,
                                     Telefono = s.telefono,
                                     Pista = p.nombre,
                                     Ubicacion = p.ubicacion,
                                     Precio = p.precioHora,
                                     FechaReserva = r.fecha,
                                     Hora = r.hora,
                                     Cantidad = r.cantidad,
                                     Pagado = r.pagado
                                 };

                var datos = todosDatos
                    .Where(r => r.Pista.Contains(txtNombrePista.Text) && r.Nombre.Contains(txtNombreSocio.Text)).OrderBy(r => r.FechaReserva).OrderBy(r => r.Hora)
                    .ToList();

                dataGridBusquedas.DataSource = datos;
                ocultarCoulmnas();

                if (rboMayor.Checked)
                {
                    var precioNumeric = (int)numericUpDownEuros.Value;
                    var preciosMas = datos.Where(r => r.Precio > precioNumeric);

                    dataGridBusquedas.DataSource = preciosMas.ToList();
                    ocultarCoulmnas();
                }
                else if (rboMenor.Checked)
                {
                    var precioNumeric = (int)numericUpDownEuros.Value;
                    var preciosMen = datos.Where(r => r.Precio < precioNumeric).ToList();

                    dataGridBusquedas.DataSource = preciosMen;
                    ocultarCoulmnas();
                }

                if (chkReservadas.Checked)
                {
                    var dia = dateTimePickerBusqueda.Value.Date;
                    var reservadas = datos.Where(r => r.FechaReserva == dia).ToList();

                    dataGridBusquedas.DataSource = reservadas;
                    ocultarCoulmnas();
                }
            }
        }



        private void ocultarCoulmnas()
        {
            dataGridBusquedas.Columns[0].Visible = false;
            dataGridBusquedas.Columns[1].Visible = false;
            dataGridBusquedas.Columns[2].Visible = false;
        }

    
    }
}
