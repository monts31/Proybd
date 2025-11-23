using MySql.Data.MySqlClient;
using Proybd.pojo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proybd.Backend
{
    public class clsConsultaAuditorias
    {
        private ConexiónMSQL conexionMSQL;

        public clsConsultaAuditorias()
        {
            conexionMSQL = new ConexiónMSQL();
        }

        public List<clsAuditorias> obtenerAuditorias()
        {
            List<clsAuditorias> auditorias = new List<clsAuditorias>();

            string QUERY = "select * from auditorias;";

            using (MySqlCommand comado = new MySqlCommand(QUERY, conexionMSQL.GetConnection()))
            using (MySqlDataReader reader = comado.ExecuteReader())
            {
                while (reader.Read())
                {
                    clsAuditorias audi = new clsAuditorias();

                    audi.id_Auditorias = reader.GetInt32("id_Auditorias");
                    audi.id_Usuario = reader.GetInt32("id_Usuario");
                    audi.cambio = reader.GetString("cambio");
                    audi.valor_Anterior = reader.GetFloat("valor_Anterior");
                    audi.valor_Nuevo = reader.GetFloat("valor_Nuevo");
                    audi.fecha = reader.GetDateTime("fecha");

                    auditorias.Add(audi);
                }
            }

            return auditorias;
        }
    }
}
