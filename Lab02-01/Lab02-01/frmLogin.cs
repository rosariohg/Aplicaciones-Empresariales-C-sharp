using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_01
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string[] usuarios = { "rosario", "veronica", "lupe", "juan" };
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;
            for (int i = 0; i < usuarios.Length; i++) {
                if (Convert.ToString(usuarios[i]) != usuario && password != "root123")
                {
                    MessageBox.Show("Usuario o  password incorrecto");
                    return;
                }
                else {
                    PrincipalMDI principal = new PrincipalMDI();
                    principal.Show();
                    this.Hide();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
