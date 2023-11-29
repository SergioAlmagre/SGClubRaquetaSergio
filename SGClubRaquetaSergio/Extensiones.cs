using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGClubRaquetaSergio
{
    /// <summary>
    /// Clase que contiene las extensiones adicionales que necesito en mi proyecto
    /// </summary>
    internal static class Extensiones
    {
        /// <summary>
        /// Este metodo extiende la clase List de string para devolver una cadena formateada
        /// con el Nº de elementos
        /// </summary>
        /// <param name="fuente"></param>
        /// <returns></returns>
        public static string CantidadElementos(this List<string> fuente) 
        { int Cantidad = fuente.Count();
          return ("La lista tiene " + Cantidad.ToString() + " elementos."); 
        }

        public static DataSet ObtenerDataSet(this DataGridView dgv)
        {
            var ds = new DataSet();
            var dt = new DataTable();

            foreach (var column in dgv.Columns.Cast<DataGridViewColumn>())
            {
                if (column.Visible)
                {
                    dt.Columns.Add(column.Name);
                }
            }

            foreach (var row in dgv.Rows.Cast<DataGridViewRow>())
            {
                var cellValues = new object[dgv.Columns.Count];

                int pos = 0;
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    if (dgv.Columns[i].Visible)
                    {
                        cellValues[pos] = row.Cells[i].Value;
                        pos++;
                    }
                }

                dt.Rows.Add(cellValues);
            }
            ds.Tables.Add(dt);
            return ds;
        }
    }
}
