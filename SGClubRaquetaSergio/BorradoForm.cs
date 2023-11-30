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
        public string id {  get; set; }
        public string tipo { get; set; }

        public BorradoForm(string id, string tipo)
        {
            InitializeComponent();
            this.id = id;
            this.tipo = tipo;
        }

        private void BorradoForm_Load(object sender, EventArgs e)
        {
           //cargarCombosAdo();
           cargarCombosEntity();
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
                    ComboItemPistas comboItem = new ComboItemPistas(p.idPista,p.nombre,p.ubicacion);
                    cboPistas.Items.Add(comboItem);
                }
                
            // RESERVAS - Tiene su nuevo tableadapter en la base de datos que mezcla dos tablas
                comboItemReservasBorradoDataSetTableAdapter comboItemReservasAdapter = new comboItemReservasBorradoDataSetTableAdapter();
                comboItemReservasAdapter.FillFechaNombrePistaIdReserva(dsDB.comboItemReservasBorradoDataSet);

                cboReservas.Items.Clear();

                foreach (var r in dsDB.comboItemReservasBorradoDataSet)
                {
                    //var fechaFormateada = r.fecha.ToString("dd/MM/yyyy"); // DateTime no acepta un formateo de la fecha sin la hora, así que si lo quieres el tipo de dato de entrada deberá ser string
                    ComboItemReservaBorrado comboItem = new ComboItemReservaBorrado(r.fecha, r.nombre ,r.idReserva);
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


        public void borradoEntity()
        {



        }


        public void borradoAdo()
        {
            


        }
    }
}
