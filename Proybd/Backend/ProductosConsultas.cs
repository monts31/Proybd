using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proybd.Backend
{
    internal class ProductosConsultas
    {
        private ConexiónMSQL conexionMSQL;

        public ProductosConsultas()
        {
            conexionMSQL = new ConexiónMSQL();
        }
        public List<Productos> getProductos()
        {
            List<Productos> lista = new List<Productos>();

            string QUERY = "SELECT * FROM productos;";

            using (MySqlCommand cmd = new MySqlCommand(QUERY, conexionMSQL.GetConnection()))
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Productos p = new Productos();

                    p.id_Producto = reader.GetInt32("id_Producto");
                    p.nombre = reader.GetString("nombre");
                    p.descripcion = reader.GetString("descripcion");
                    p.precio = reader.GetFloat("precio");
                    p.stock = reader.GetInt32("stock");
                    p.foto = reader["foto"] != DBNull.Value? (byte[])reader["foto"]: null;

                    lista.Add(p);
                }
            }

            return lista;
        }
    }
}
