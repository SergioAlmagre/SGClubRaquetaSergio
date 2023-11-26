using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGClubRaquetaSergio
{
    internal class ComboItemRevervas
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string apellidos;

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        private string dni;
        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }



        public ComboItemRevervas( string apellidos, string nombre, string dni)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Dni = dni;
        }


        public override string ToString()
        {
            return apellidos + " " + nombre;
        }
    }
}
