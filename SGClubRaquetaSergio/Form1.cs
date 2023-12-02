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
            PistasForm formulario = new PistasForm(); //FORMULARIO MODAL

            if (formulario.ShowDialog() == DialogResult.Cancel)
            {

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

            SociosForm formulario = new SociosForm(); //FORMULARIO MODAL

            if (formulario.ShowDialog() == DialogResult.Cancel)
            {
                        
            } 

        }

        private void aDMINISTRARToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gESTIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "GestionForm")
                {
                    DialogResult rs = MessageBox.Show("¿Seguro que desea salir?, Puedes perder los datos si no has guardado", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        this.MdiChildren[0].Close();
                        GestionForm formulario = new GestionForm();
                        formulario.MdiParent = this;
                        formulario.Dock = DockStyle.Fill;
                        formulario.Show();
                    }
                }
            }
            else
            {
                GestionForm formulario = new GestionForm();
                formulario.MdiParent = this;
                formulario.Dock = DockStyle.Fill;
                formulario.Show();
            }
        }

        private void bORRADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "BorradoForm")
                {
                    DialogResult rs = MessageBox.Show("¿Seguro que desea salir?, Puedes perder los datos si no has guardado", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        this.MdiChildren[0].Close();
                        BorradoForm formulario = new BorradoForm(null,-1);
                        formulario.MdiParent = this;
                        formulario.Dock = DockStyle.Fill;
                        formulario.Show();
                    }
                }
            }
            else
            {
                BorradoForm formulario = new BorradoForm(null,-1);
                formulario.MdiParent = this;
                formulario.Dock = DockStyle.Fill;
                formulario.Show();
            }
        }

        private void pRECIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "PreciosForm")
                {
                    DialogResult rs = MessageBox.Show("¿Seguro que desea salir?, Puedes perder los datos si no has guardado", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        this.MdiChildren[0].Close();
                        PreciosForm formulario = new PreciosForm();
                        formulario.MdiParent = this;
                        formulario.Dock = DockStyle.Fill;
                        formulario.Show();
                    }
                }
            }
            else
            {
                PreciosForm formulario = new PreciosForm();
                formulario.MdiParent = this;
                formulario.Dock = DockStyle.Fill;
                formulario.Show();
            }
        }
    }
}
