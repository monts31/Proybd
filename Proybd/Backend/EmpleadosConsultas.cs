using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proybd.Backend
{
    internal class EmpleadosConsultas
    {
        private ConexiónMSQL conexiónMSQL;
        private List<Empleados> mEmpleados;
        public EmpleadosConsultas()
        {
            conexiónMSQL = new ConexiónMSQL();
            mEmpleados = new List<Empleados>();
        }

        public List<Empleados> getEmpleados(string filtro)
        {
            string QUERY = "SELECT * FROM Empleados ";
            MySqlDataReader mReader = null;
            try
            {
                if(filtro != "")
                {
                    QUERY += " WHERE " +
                        "id_Empleado LIKE '%" + filtro + "%' OR " +
                        "nombre LIKE '%" + filtro + "%' OR " +
                        "telefono LIKE '%" + filtro + "%' OR " +
                        "rol LIKE '%" + filtro + "%' OR " +
                        "horas LIKE '%" + filtro + "%' OR " +
                        "sueldo LIKE '%" + filtro + "%' OR " +
                        "fecha_Contrato LIKE '%" + filtro + "%' ;";

                }
                MySqlCommand mComando = new MySqlCommand(QUERY);
                mComando.Connection = conexiónMSQL.GetConnection();
                mReader = mComando.ExecuteReader();

                Empleados mEmpleadoss = null;
                while(mReader.Read())
                {
                    mEmpleadoss = new Empleados();
                    mEmpleadoss.id_Empleado = mReader.GetInt16("id_Empleado");
                    mEmpleadoss.nombre = mReader.GetString("nombre");
                    mEmpleadoss.telefono = mReader.GetString("telefono");
                    mEmpleadoss.rol = mReader.GetByte("rol");
                    mEmpleadoss.horas = mReader.GetInt16("horas");
                    mEmpleadoss.sueldo = mReader.GetFloat("sueldo");
                    mEmpleadoss.fecha_Contrato = mReader.GetDateTime("fecha_Contrato");
                    mEmpleados.Add(mEmpleadoss);

                }
                mReader.Close();

            }
            catch (Exception) {
                throw;
            }
            return mEmpleados;
        }
    }
}
