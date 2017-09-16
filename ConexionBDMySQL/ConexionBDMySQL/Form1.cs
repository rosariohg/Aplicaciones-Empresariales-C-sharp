using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConexionBDMySQL.mysql;

namespace ConexionBDMySQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            String bd = txtBD.Text;
            String usuario = txtUsuario.Text;
            String pwd = txtPwd.Text;

            conexion.crearConexion(bd,usuario,pwd);
            MessageBox.Show("La conexión se realizó con éxito");
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            conexion.desconectar();
            MessageBox.Show("Conexión cerrada satisfactoriamente");
        }
    }
}
