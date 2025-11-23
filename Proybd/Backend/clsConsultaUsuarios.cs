using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Proybd.pojo;

namespace Proybd.Backend
{
    public class clsConsultaUsuarios
    {
        public bool IniciarSesion(clsUsuarios usuario)
        {

            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = "server=localhost; database=LosTresBombones; user=root; pwd=31tv9";
            try
            {
                cn.Open();

                string strSQL = "select count(*) from usuarios where usuario = @usuario and password = sha1(@password)";

                MySqlCommand comando = new MySqlCommand(strSQL, cn);
                comando.Parameters.AddWithValue("@usuario", usuario.Usuario);
                comando.Parameters.AddWithValue("@password", usuario.Contraseña);

                int resultado = Convert.ToInt32(comando.ExecuteScalar());

                /*using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    return reader.Read();
                }*/
                if(resultado > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message);
                return false;
            }
            finally { cn.Close(); }

        }
        
    }
}
