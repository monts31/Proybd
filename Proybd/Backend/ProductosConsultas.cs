using MySql.Data.MySqlClient;
using Proybd.pojo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proybd.Backend
{
    public class ProductosConsultas
    {
        private ConexiónMSQL conexionMSQL;

        public ProductosConsultas()
        {
            conexionMSQL = new ConexiónMSQL();
        }
        public List<clsProductos> getProductos()
        {
            List<clsProductos> lista = new List<clsProductos>();

            string QUERY = "SELECT * FROM productos;";

            using (MySqlCommand cmd = new MySqlCommand(QUERY, conexionMSQL.GetConnection()))
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    clsProductos p = new clsProductos();

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

        public bool agregarProducto(clsProductos producto)
        {
            string INSERT = "insert into Productos(nombre, descripcion, precio, stock, foto) values (@nombre ,@descripcion ,@precio ,@stock ,@foto);";
            
            MySqlCommand comando = new MySqlCommand(INSERT, conexionMSQL.GetConnection());

            comando.Parameters.Add(new MySqlParameter("@nombre", producto.nombre));
            comando.Parameters.Add(new MySqlParameter("@descripcion", producto.descripcion));
            comando.Parameters.Add(new MySqlParameter("@precio", producto.precio));
            comando.Parameters.Add(new MySqlParameter("@stock", producto.stock));
            comando.Parameters.Add(new MySqlParameter("@foto", producto.foto));

            return comando.ExecuteNonQuery() > 0;
        }

        public bool eliminarPRoducto(int id_Producto)
        {
            string DELETE = "delete from Prodctos where id_Producto = @id_Producto;";

            MySqlCommand mcCommand = new MySqlCommand(DELETE, conexionMSQL.GetConnection());

            mcCommand.Parameters.Add(new MySqlParameter("@id_Producto", id_Producto));

            return mcCommand.ExecuteNonQuery() > 0;
        }

        public bool actualizarProducto(clsProductos producto)
        {
            string UPDATE = "update Productos set nombre = @nombre, descripcion = @descripcion, precio = @precio, stock = @stock, foto = @foto where id_Producto = @id_Producto;";
            
            MySqlCommand mcCommand = new MySqlCommand(UPDATE, conexionMSQL.GetConnection());

            mcCommand.Parameters.Add(new MySqlParameter("@id_Producto", producto.id_Producto));
            mcCommand.Parameters.Add(new MySqlParameter("@nombre", producto.nombre));
            mcCommand.Parameters.Add(new MySqlParameter("@descripcion", producto.descripcion));
            mcCommand.Parameters.Add(new MySqlParameter("@precio", producto.precio));
            mcCommand.Parameters.Add(new MySqlParameter("@stock", producto.stock));
            mcCommand.Parameters.Add(new MySqlParameter("@foto", producto.foto));

            return mcCommand.ExecuteNonQuery() > 0;
        }
    }

}

