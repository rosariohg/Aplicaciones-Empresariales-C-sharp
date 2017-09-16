using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cine
{
    public partial class PrincipalMDI : Form
    {
        public PrincipalMDI()
        {
            InitializeComponent();
        }

        private void mnuManUsuarios_Click(object sender, EventArgs e)
        {
            manUsuarios frm = new manUsuarios();
            frm.MdiParent = this;
            frm.Show();

        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuManPeliculas_Click(object sender, EventArgs e)
        {
            manPeliculas frm = new manPeliculas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuManGeneros_Click(object sender, EventArgs e)
        {
            manGeneros frm = new manGeneros();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuProReservas_Click(object sender, EventArgs e)
        {
            proReservas frm = new proReservas();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
