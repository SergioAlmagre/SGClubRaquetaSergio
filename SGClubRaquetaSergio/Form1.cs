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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "PistasForm")
                {
                    DialogResult rs = MessageBox.Show("¿Seguro que desea salir?, Puedes perder los datos si no has guardado", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        this.MdiChildren[0].Close();
                        PistasForm formulario = new PistasForm();
                        formulario.MdiParent = this;
                        formulario.Dock = DockStyle.Fill;
                        formulario.Show();
                    }
                }
            }
            else
            {
                PistasForm formulario = new PistasForm();
                formulario.MdiParent = this;
                formulario.Dock = DockStyle.Fill;
                formulario.Show();
            }
        }

        private void rESERVASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "ReservasForm")
                {
                    DialogResult rs = MessageBox.Show("¿Seguro que desea salir?, Puedes perder los datos si no has guardado", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        this.MdiChildren[0].Close();
                        ReservasForm formulario = new ReservasForm();
                        formulario.MdiParent = this;
                        formulario.Dock = DockStyle.Fill;
                        formulario.Show();
                    }
                }
            }
            else
            {
                ReservasForm formulario = new ReservasForm();
                formulario.MdiParent = this;
                formulario.Dock = DockStyle.Fill;
                formulario.Show();
            }
        }

        private void iNFORMESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "InformesForm")
                {
                    DialogResult rs = MessageBox.Show("¿Seguro que desea salir?, Puedes perder los datos si no has guardado", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        this.MdiChildren[0].Close();
                        InformesForm formulario = new InformesForm();
                        formulario.MdiParent = this;
                        formulario.Dock = DockStyle.Fill;
                        formulario.Show();
                    }
                }
            }
            else
            {
                InformesForm formulario = new InformesForm();
                formulario.MdiParent = this;
                formulario.Dock = DockStyle.Fill;
                formulario.Show();
            }
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "SociosForm")
                {
                    DialogResult rs = MessageBox.Show("¿Seguro que desea salir?, Puedes perder los datos si no has guardado", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        this.MdiChildren[0].Close();
                        SociosForm formulario = new SociosForm();
                        formulario.MdiParent = this;
                        formulario.Dock = DockStyle.Fill;
                        formulario.Show();
                    }
                }
            }
            else
            {
                SociosForm formulario = new SociosForm();
                formulario.MdiParent = this;
                formulario.Dock = DockStyle.Fill;
                formulario.Show();
            }

        }

        private void aDMINISTRARToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
