using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Proybd.Backend
{
    public class login
    {
        public bool IniciarSesion(Personas persona)
        {

            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = "server=localhost; database=login; user=root; pwd=31tv9";
            try
            {
                cn.Open();

                /// login
                Hash hash = new Hash();
                string contraseñaHash = hash.GetHash(persona.Contraseña);

                string query = "SELECT * FROM personas WHERE binary usuario = @usuario AND contraseña = @contraseña";
                MySqlCommand comando = new MySqlCommand(query, cn);
                comando.Parameters.AddWithValue("@usuario", persona.Usuario);
                comando.Parameters.AddWithValue("@contraseña", contraseñaHash);

                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    return reader.Read();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message);
                return false;
            }
            finally { cn.Close(); }

        }
        /* public void logea(Personas persona)
         {
             using (MySqlConnection conexion = Class1.conexion())
             {
                 if (conexion == null)
                 {
                     MessageBox.Show("Error al conectar con la base de datos.");
                     return;
                 }

                 try
                 {
                     conexion.Open();
                     string query = "SELECT * FROM personas WHERE binary usuario = @usuario AND contraseña = @contraseña";
                     using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                     {
                         Hash hash = new Hash();
                         string contraseñaHash = hash.GetHash(persona.Contraseña);
                         cmd.Parameters.AddWithValue("@usuario", persona.Usuario);
                         cmd.Parameters.AddWithValue("@contraseña", contraseñaHash);

                         MySqlDataReader reader = cmd.ExecuteReader();


                         if (reader.Read())
                         {
                             MessageBox.Show("¡Login exitoso!");

                             Menu menu = new Menu();
                             menu.Show();

                         }
                         else
                         {
                             MessageBox.Show("Usuario o contraseña incorrectos.");
                         }
                     }
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show("Error: " + ex.Message);
                 }
             }
         }*/
    }
}
