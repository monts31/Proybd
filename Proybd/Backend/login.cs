using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Proybd.Backend
{
    public class login
    {
<<<<<<< HEAD
        public bool IniciarSesion(Personas persona)
=======
        /*public bool IniciarSesion(//Personas persona)
>>>>>>> 1c670cd060883907daacafecc69155e4fe3a1a7e
        {

            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = "server=localhost; database=login; user=root; pwd=31tv9";
            try
            {
                cn.Open();

                /// login
                //Hash hash = new Hash(); aqui tenia una clase hash pero no se como lo vayas a usar 
                //string contraseñaHash = hash.GetHash(persona.Contraseña); comente esta tambien porque no se como lo vayas a usar

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

        }*/
        
    }
}
