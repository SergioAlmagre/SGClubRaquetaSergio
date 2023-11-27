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
    public partial class InformesForm : Form
    {
        public InformesForm()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            dataGridViewInformes.DataSource = null;
            using (clubraquetaEntities objDB = new clubraquetaEntities())
            {
                var pistaMasAlquiladaId = objDB.reservas
                   .GroupBy(r => r.pista)
                   .OrderByDescending(g => g.Count())
                   .Select(g => g.Key)
                   .FirstOrDefault();

                if (pistaMasAlquiladaId != null)
                {
                    var pistaObj = objDB.pistas
                        .Where(r => r.idPista == pistaMasAlquiladaId)
                        .ToList();

                    dataGridViewInformes.DataSource = pistaObj;
                    dataGridViewInformes.Columns[5].Visible = false;
                }             
            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            dataGridViewInformes.DataSource = null;
            using (clubraquetaEntities objDB = new clubraquetaEntities())
            {
                var pistaMenosAlquilada = objDB.reservas
                 .GroupBy(r => r.pista)
                 .OrderBy(g => g.Count())
                 .Select(g => g.Key)
                 .FirstOrDefault();

                var pistaMenosAlquiladaObj = objDB.pistas
                    .Where(p => p.idPista == pistaMenosAlquilada).ToList()
                    .FirstOrDefault();

                dataGridViewInformes.DataSource = pistaMenosAlquiladaObj;
 
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
                dataGridViewInformes.DataSource = null;
                using (clubraquetaEntities objDB = new clubraquetaEntities())
                {
                //OPCION 1 MAS SENCILLA SIN OBTENER NINGUN VALOR MAS QUE NO SEA UN ATRIBUTO DEL OBJETO
                //var pistaMasAlquildasId = objDB.reservas
                //.GroupBy(r => r.pista)
                //.OrderByDescending(g => g.Count())
                //.Select(g => g.Key).ToList(); //Obtiene solo el id con el comando Key

                //var pistasDetalles = new List<pistas>();

                //foreach (var item in pistaMasAlquildasId)
                //{
                //    var pista = objDB.pistas.FirstOrDefault(p => p.idPista == item);
                //    if (pista != null)
                //    {
                //        pistasDetalles.Add(pista);
                //    }
                //}

                //var resultadoFinal = pistasDetalles.Select(p => new
                //{
                //    IdPista = p.idPista,
                //    Nombre = p.nombre,
                //    Ubicacion = p.ubicacion,
                //    PrecioHora = p.precioHora,
                //    Foto = p.foto
                //});

                //dataGridViewInformes.DataSource = resultadoFinal.ToList();

                var pistasOrdenadasPorPopularidad = objDB.reservas
                    .GroupBy(r => r.pista)
                    .OrderByDescending(g => g.Count())
                    .Select(g => new
                    {
                        IdPista = g.Key,
                        Popularidad = g.Count()
                    })
                    .ToList();

                var resultadoFinal = from p in pistasOrdenadasPorPopularidad
                                     join pd in objDB.pistas on p.IdPista equals pd.idPista
                                     select new
                                     {
                                         IdPista = pd.idPista,
                                         Nombre = pd.nombre,
                                         Ubicacion = pd.ubicacion,
                                         PrecioHora = pd.precioHora,
                                         Foto = pd.foto,
                                         VecesAlquilada = p.Popularidad
                                     };

                dataGridViewInformes.DataSource = resultadoFinal.ToList();

            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            dataGridViewInformes.DataSource = null;
            using (clubraquetaEntities objDB = new clubraquetaEntities())
            {
                var socioMasMorosoDni = objDB.reservas
                    .GroupBy(r => r.socio)
                    .OrderByDescending(g => g.Count())
                    .Where(g => g.Any(reserva => reserva.pagado.StartsWith("N")))
                    .Select(g => g.Key)
                    .FirstOrDefault();


                if (socioMasMorosoDni != null)
                {
                    var socioObj = objDB.socios
                        .Where(r => r.DNI == socioMasMorosoDni)
                        .ToList();

                    dataGridViewInformes.DataSource = socioObj;
                    dataGridViewInformes.Columns[7].Visible = false;
                }
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            using (clubraquetaEntities objDB = new clubraquetaEntities())
            {


            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            using (clubraquetaEntities objDB = new clubraquetaEntities())
            {


            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            using (clubraquetaEntities objDB = new clubraquetaEntities())
            {


            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            using (clubraquetaEntities objDB = new clubraquetaEntities())
            {


            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            dataGridViewInformes.DataSource = null;
        }

        private void dataGridViewInformes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
