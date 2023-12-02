using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGClubRaquetaSergio
{
	


	internal class ComboItemPistas
    {

        private int idPista;

        public int IdPista
        {
            get { return idPista; }
            set { idPista = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string localizacion;

        public string Localizacion
        {
            get { return localizacion; }
            set { localizacion = value; }
        }

        public ComboItemPistas(int idPista, string nombre, string localizacion)
        {
            IdPista = idPista;
            Nombre = nombre;
            Localizacion = localizacion;
        }

        public override string ToString()
        {
            return nombre + " " + localizacion;
        }

    }
}
