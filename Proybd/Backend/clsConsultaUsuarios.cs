using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Proybd.pojo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proybd.Backend
{
    public class clsConsultaUsuarios
    {
        private ConexiónMSQL conexiónMSQL;

        public clsConsultaUsuarios()
        {
            conexiónMSQL = new ConexiónMSQL();
        }
        public bool IniciarSesion(clsUsuarios usuario)
        {
            MySqlConnection conn = conexiónMSQL.GetConnection();

            try
            {
                string strSQL = "select id_Usuario, usuario from usuarios where usuario = @usuario and password = SHA1(@password)";

                MySqlCommand command = new MySqlCommand(strSQL, conn);
                command.Parameters.AddWithValue("@usuario", usuario.Usuario);
                command.Parameters.AddWithValue("@password", usuario.Contraseña);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        /* int id = reader.GetInt32("id_Usuario");
                        string nombreUsuario = reader.GetString("usuario");

                        MessageBox.Show("ID: " + id + "\nUsuario: " + nombreUsuario, "LOGIN OK", MessageBoxButtons.OK, MessageBoxIcon.Information); */
                        return true;
                    }
                    else
                    {
                        /* MessageBox.Show("Usuario o contraseña incorrectos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning); */
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al iniciar sesión: " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        

    }
}
