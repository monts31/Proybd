using MySql.Data.MySqlClient;
using Mysqlx.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proybd.Backend
{
    internal class ConexiónMSQL : Conexión
    {
        private MySqlConnection connection;
        private string cadenaConexion;
        public ConexiónMSQL()
        {
            cadenaConexion = "Database=" + database +
                "; DataSource=" + server +
                "; User id= " + user +
                "; Password=" + password;

            connection = new MySqlConnection(cadenaConexion);
        }

        public MySqlConnection GetConnection()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }

            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
                
            }

            return connection;
        }
    }
}
