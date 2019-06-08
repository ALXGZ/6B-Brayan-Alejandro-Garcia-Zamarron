using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace LoginSB
{
    class Login
    {
        #region "atributos"
        string usuario;
        string contraseña;
        #endregion

        #region "propiedades"
        public string USUARIO
        {
            set { usuario = value; }
            get { return usuario; }
        }
        public string CONTRASEÑA
        {
            set { contraseña = value; }
            get { return contraseña; }
        }
        #endregion

        #region "Funciones"
        public bool validarLogin(string u, string c)
        {
            string cadena = "Server=localhost;Database=ser_ban_login;uid=root;pwd=;port=3306;";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            MySqlCommand cmd;
            MySqlDataReader dr;

            string sql = "SELECT * FROM usuarios WHERE usuario = '"+u+"' and contrasena ='" + c + "' ";
            cmd = new MySqlCommand(sql, con);
            dr = cmd.ExecuteReader();
            dr.Read();

            if (dr.HasRows)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña no incorrectos");
                return false;
            }
            return false;
        }
        #endregion
    }
}
