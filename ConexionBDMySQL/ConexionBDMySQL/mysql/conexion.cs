using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConexionBDMySQL.mysql
{
    class conexion
    {
        public static MySqlConnection crearConexion(String bd, String uid, String pwd) {
            String str = "Server=localhost" + ";database=" + bd + ";UID=" + uid + ";pwd=" + pwd + ";";
            MySqlConnection conn = new MySqlConnection(str);
            conn.Open();
            return conn;
        }

        public static void desconectar() {
            MySqlConnection conn = new MySqlConnection();
            conn.Close();
        }

    }
}
