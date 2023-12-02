using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGClubRaquetaSergio
{
    internal class ComboItemSocio
    {

		private string dni;

		public string Dni
		{
			get { return dni; }
			set { dni = value; }
		}

		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private string telefono;

		public string Telefono
		{
			get { return telefono; }
			set { telefono = value; }
		}

		public ComboItemSocio(string dni, string nombre, string telefono)
		{
			this.dni = dni;
			this.nombre = nombre;
			this.telefono = telefono;
		}


        public override string ToString()
        {
            return nombre + " " + telefono;
        }


    }
}
