using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGClubRaquetaSergio
{

    public partial class SociosForm : Form
    {
        string dni = "";
        socios socioSeleccionado;
        string expresion = "";

        public SociosForm()
        {
            InitializeComponent();
        }

        private void SociosForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'clubraquetaDataSet.socios' Puede moverla o quitarla según sea necesario.
            this.sociosTableAdapter.Fill(this.clubraquetaDataSet.socios);

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                using (clubraquetaEntities objDB = new clubraquetaEntities())
                {
                    socios nuevoSocio = new socios();

                    if (esFormatoCorrecto())
                    {
                        nuevoSocio.cuentaCorriente = txtCuentaCorriente.Text;
                        nuevoSocio.DNI = txtDNI.Text;
                        nuevoSocio.nombre = txtNombre.Text;
                        nuevoSocio.apellidos = txtApellidos.Text;
                        nuevoSocio.domicilio = txtDomicilio.Text;
                        nuevoSocio.email = txtEmail.Text;
                        nuevoSocio.cuentaCorriente = txtCuentaCorriente.Text;
                        nuevoSocio.telefono = txtTelefono.Text;
                        // Guardar cambios
                        objDB.socios.Add(nuevoSocio);
                        objDB.SaveChanges();
                        MessageBox.Show("Socio insertado correctamente");
                        btnTodos_Click(sender, e);
                    }

                }
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var entityValidationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationErrors.ValidationErrors)
                    {
                        MessageBox.Show($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                    }
                }
            }
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                using (clubraquetaEntities objDB = new clubraquetaEntities())
                {
                    socios socioModificado = objDB.socios.Find(socioSeleccionado.DNI);


                    if (esFormatoCorrecto())
                    {
                        socioModificado.cuentaCorriente = txtCuentaCorriente.Text;
                        //socioModificado.DNI = txtDNI.Text; // este no se pone porque es clave primaria y no te deja modificarla
                        socioModificado.nombre = txtNombre.Text;
                        socioModificado.apellidos = txtApellidos.Text;
                        socioModificado.domicilio = txtDomicilio.Text;
                        socioModificado.email = txtEmail.Text;

                        socioModificado.telefono = txtTelefono.Text;
                        // Guardar cambios
                        objDB.SaveChanges();
                        MessageBox.Show("Socio modificado correctamente");
                        btnTodos_Click(sender, e);
                    }

                }
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var entityValidationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationErrors.ValidationErrors)
                    {
                        MessageBox.Show($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                    }
                }

                // Otros manejadores o acciones que puedas necesitar.
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (clubraquetaEntities objDB = new clubraquetaEntities())
            {

                DialogResult respuesta = MessageBox.Show("¿Está seguro de que desea eliminar el curso seleccionado?", "Eliminar curso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    socios socioABorrar = objDB.socios.Find(socioSeleccionado.DNI);

                    var nReservas2 = from res in objDB.reservas
                                     where res.socio == socioABorrar.DNI
                                     select res;

                    nReservas2.ToList();

                    if (nReservas2.Count() == 0)
                    {
                        objDB.socios.Remove(socioABorrar);
                        objDB.SaveChanges();
                        MessageBox.Show("Socio eliminado correctamente", "Eliminar socio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnTodos_Click(sender, e);

                    }
                    else
                    {
                        MessageBox.Show("Socio tiene reservas en curso y no se puede eliminar ", "Eliminar socio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }


        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            using (clubraquetaEntities objDB = new clubraquetaEntities())
            {
                var datosSocios = from socios in objDB.socios
                                  select socios;

                dataGSocios.DataSource = datosSocios.OrderBy(s => s.nombre).ToList();
                dataGSocios.Columns[7].Visible = false;
            }
        }

        private void dataGSocios_SelectionChanged(object sender, EventArgs e)
        {
            using (clubraquetaEntities objDB = new clubraquetaEntities())
            {
                try
                {
                    // Verificar si hay una fila seleccionada
                    if (dataGSocios.CurrentRow != null)
                    {
                        // Obtener el ID del curso
                        dni = dataGSocios.CurrentRow.Cells[0].Value.ToString();

                        // Instanciar el curso por su ID
                        socioSeleccionado = objDB.socios.Where(x => x.DNI == dni).FirstOrDefault();

                        if (socioSeleccionado != null)
                        {
                            txtDNI.Text = socioSeleccionado.DNI;
                            txtNombre.Text = socioSeleccionado.nombre;
                            txtApellidos.Text = socioSeleccionado.apellidos;
                            txtDomicilio.Text = socioSeleccionado.domicilio;
                            txtEmail.Text = socioSeleccionado.email;
                            txtTelefono.Text = socioSeleccionado.telefono;
                            txtCuentaCorriente.Text = socioSeleccionado.cuentaCorriente;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al seleccionar el socio: " + ex.Message);
                }
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDNI.Text = null;
            txtNombre.Text = null;
            txtApellidos.Text = null;
            txtDomicilio.Text = null;
            txtEmail.Text = null;
            txtTelefono.Text = null;
            txtCuentaCorriente.Text = null;
            //dataGSocios.DataSource = null; // no entiendo por que si pongo el datagrid tengo que pulsar dos veces el botón de limpiar para que los textBox se limpien
        }

        private Boolean esFormatoCorrecto()
        {
            Boolean esCorrecto = true;
            int bandera = 0;

            expresion = "\\AES\\d{2}[-]\\d{4}[-]\\d{4}[-]\\d{2}[-]\\d{10}\\Z"; //Cuenta bancaria: "ES00-0000-0000-00-0000000000"
            String str = txtCuentaCorriente.Text.Trim();
            Regex regExp = new Regex(expresion);
            if (!regExp.Match(str).Success)
            {
                bandera++;
                MessageBox.Show("Formato de la cuenta corriente equivocado", "Vuelva a introducirlo de nuevo \"ES00-0000-0000-00-0000000000\"", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            expresion = "[0-9]{3}[-][0-9]{3}[-][0-9]{3}"; //Numero de teléfono: "123-123-123"
            str = txtTelefono.Text.Trim();
            regExp = new Regex(expresion);
            if (!regExp.Match(str).Success)
            {
                bandera++;
                MessageBox.Show("Formato del telefono equivocado", "Vuelva a introducirlo de nuevo \"123-123-123\"", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            if(bandera > 0) 
            {
                esCorrecto = false;
            }

            return esCorrecto;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
