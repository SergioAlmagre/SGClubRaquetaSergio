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

                    var pistaObj = objDB.pistas
                        .Where(r => r.idPista == pistaMasAlquiladaId)
                        .ToList();

                    dataGridViewInformes.DataSource = pistaObj;
                    dataGridViewInformes.Columns[5].Visible = false;
                           
            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            dataGridViewInformes.DataSource = null;
            using (clubraquetaEntities objDB = new clubraquetaEntities())
            {
                var pistaMenosAlquida = from pistas in objDB.pistas
                                        join reservas in objDB.reservas on pistas.idPista equals reservas.pista
                                        group pistas by pistas.idPista into g
                                        orderby g.Count() ascending
                                        select new
                                        {
                                            IdPista = g.Key,
                                            Nombre = g.Select(p => p.nombre).FirstOrDefault(),
                                            Ubicacion = g.Select(p => p.ubicacion).FirstOrDefault(),
                                            PrecioHora = g.Select(p => p.precioHora).FirstOrDefault(),
                                            Foto = g.Select(p => p.foto).FirstOrDefault(),
                                        };

                dataGridViewInformes.DataSource = pistaMenosAlquida.ToList();
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
                dataGridViewInformes.DataSource = null;
                using (clubraquetaEntities objDB = new clubraquetaEntities())
                {

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
                var resultado = objDB.socios
                    .Join(
                        objDB.reservas,
                        socio => socio.DNI,
                        reserva => reserva.socio,
                        (socio, reserva) => new { Socio = socio, Reserva = reserva }
                    )
                    .GroupBy(joined => new { joined.Socio.nombre, joined.Socio.apellidos })
                    .Select(group => new
                    {
                        Nombre = group.Key.nombre,
                        Apellidos = group.Key.apellidos,
                        TotalCantidad = group.Sum(j => j.Reserva.cantidad)
                    })
                    .OrderByDescending(result => result.TotalCantidad)
                    .ToList();

                dataGridViewInformes.DataSource = resultado;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            using (clubraquetaEntities objDB = new clubraquetaEntities())
            {
                var fechaInicioMasHoraYMedia = DateTime.Now.AddHours(1.5);

                var pistasAlquiladasAhoraMismo = from p in objDB.pistas
                                                 join r in objDB.reservas on p.idPista equals r.pista
                                                 where r.fecha >= DateTime.Now && fechaInicioMasHoraYMedia <= DateTime.Now
                                                 select new
                                                 {
                                                     IdPista = p.idPista,
                                                     Nombre = p.nombre,
                                                     Hora = r.hora, // Cambié r.fecha a r.hora para obtener la hora de la reserva
                                                     Ubicacion = p.ubicacion,
                                                     PrecioHora = p.precioHora,
                                                     Foto = p.foto
                                                 };


                if (!pistasAlquiladasAhoraMismo.Any())
                {
                    MessageBox.Show("No hay pistas alquiladas ahora mismo");
                    return;
                }

                dataGridViewInformes.DataSource = pistasAlquiladasAhoraMismo.ToList();

            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            dataGridViewInformes.DataSource = null;

            using (clubraquetaEntities objDB = new clubraquetaEntities())
            {
                var horaAlquilerMasFrecuente = from r in objDB.reservas
                                               group r by r.hora into g
                                               orderby g.Count() descending
                                               select new
                                               {
                                                   Hora = g.Key,
                                                   Cantidad = g.Count()
                                               };

                dataGridViewInformes.DataSource = horaAlquilerMasFrecuente.ToList();
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            using (clubraquetaEntities objDB = new clubraquetaEntities())
            {
                dataGridViewInformes.DataSource = null;

                var nombreYPrecioPistaMayorAMenor = from p in objDB.pistas
                                                    orderby p.precioHora descending
                                                    select new
                                                    {
                                                        Nombre = p.nombre,
                                                        PrecioHora = p.precioHora
                                                    };
                dataGridViewInformes.DataSource = nombreYPrecioPistaMayorAMenor.ToList();
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
