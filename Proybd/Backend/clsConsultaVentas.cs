using Proybd.pojo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proybd.Backend
{
    public class clsConsultaVentas
    {
        private ConexiónMSQL conexionMSQL;

        public clsConsultaVentas()
        {
            conexionMSQL = new ConexiónMSQL();
        }

        public List<clsOrdenes> obtenerVentas()
        {
            List<clsOrdenes> ventas = new List<clsOrdenes>();

            string QUERY = "select * from ordenes;";

            using (MySql.Data.MySqlClient.MySqlCommand comando = new MySql.Data.MySqlClient.MySqlCommand(QUERY, conexionMSQL.GetConnection()))
            using (MySql.Data.MySqlClient.MySqlDataReader reader = comando.ExecuteReader())
            {
                while (reader.Read())
                {
                    clsOrdenes venta = new clsOrdenes();

                    venta.id_Orden = reader.GetInt32("id_Orden");
                    venta.id_Producto = reader.GetInt32("id_Producto");
                    venta.precio = reader.GetFloat("precio");
                    venta.cantidad = reader.GetInt32("cantidad");

                    ventas.Add(venta);
                }
            }
            return ventas;
        }

        public List<clsDetallesOrden> obtenerReporte(int id_Orden)
        {
            List<clsDetallesOrden> detalles = new List<clsDetallesOrden>();

            string QUERY = "select * from dOrdenes where id_Orden = @id_Orden;";

            using (MySql.Data.MySqlClient.MySqlCommand comando = new MySql.Data.MySqlClient.MySqlCommand(QUERY, conexionMSQL.GetConnection()))
            {
                comando.Parameters.AddWithValue("@id_Orden", id_Orden);

                using (MySql.Data.MySqlClient.MySqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        clsDetallesOrden orden = new clsDetallesOrden();

                        orden.id_Orden = reader.GetInt32("id_Orden");
                        orden.id_Producto = reader.GetInt32("id_Producto");
                        orden.precio = reader.GetFloat("precio");
                        orden.cantidad = reader.GetInt32("cantidad");
                        orden.monto = reader.GetFloat("precio") * reader.GetInt32("cantidad");

                        detalles.Add(orden);
                    }
                }
            }
            return detalles;
        }
    }
}
