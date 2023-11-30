using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGClubRaquetaSergio
{
    internal class ComboItemReservaBorrado
    {
        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private string pista;

        public string Pista
        {
            get { return pista; }
            set { pista = value; }
        }


        private int idReserva;
        public int IdReserva
        {
            get { return idReserva; }
            set { idReserva = value; }
        }

        public ComboItemReservaBorrado(DateTime fecha, string pista, int idReserva)
        {
            Fecha = fecha;
            Pista = pista;
            IdReserva = idReserva;
        }


        public override string ToString()
        {
            return fecha + " " + pista;
        }
    }
}
