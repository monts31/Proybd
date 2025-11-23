using MySql.Data.MySqlClient;
using Proybd.pojo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proybd.Backend
{
    public class EmpleadosConsultas
    {
        private ConexiónMSQL conexiónMSQL;
        private List<clsEmpleados> mEmpleados;
        public EmpleadosConsultas()
        {
            conexiónMSQL = new ConexiónMSQL();
            mEmpleados = new List<clsEmpleados>();
        }

        public List<clsEmpleados> getEmpleados(string filtro)
        {
            string QUERY = "SELECT * FROM Empleados ";
            MySqlDataReader mReader = null;
            try
            {
                if (filtro != "")
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

                clsEmpleados mEmpleadoss = null;
                while (mReader.Read())
                {
                    mEmpleadoss = new clsEmpleados();
                    mEmpleadoss.id_Empleado = mReader.GetInt16("id_Empleado");
                    mEmpleadoss.nombre = mReader.GetString("nombre");
                    mEmpleadoss.telefono = mReader.GetString("telefono");
                    mEmpleadoss.rol = mReader.GetString("rol");
                    mEmpleadoss.horas = mReader.GetInt16("horas");
                    mEmpleadoss.sueldo = mReader.GetFloat("sueldo");
                    mEmpleadoss.fecha_Contrato = mReader.GetDateTime("fecha_Contrato");
                    mEmpleados.Add(mEmpleadoss);

                }
                mReader.Close();

            }
            catch (Exception)
            {
                throw;
            }
            return mEmpleados;
        }

        public clsEmpleados obtenerEmpleado(clsUsuarios usuario)
        {
            MySqlConnection conn = conexiónMSQL.GetConnection();
            clsEmpleados empleado = null;
            try
            {
                string strSQL = "select * from Empleados e join usuarios u on e.id_empleado = u.id_empleado where u.usuario = @usuario and u.password = SHA1(@password)";

                MySqlCommand command = new MySqlCommand(strSQL, conn);
                command.Parameters.AddWithValue("@usuario", usuario.Usuario);
                command.Parameters.AddWithValue("@password", usuario.Contraseña);

                
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        empleado = new clsEmpleados();
                        empleado.id_Empleado = reader.GetInt32("id_Empleado");
                        empleado.nombre = reader.GetString("nombre");
                        empleado.telefono = reader.GetString("telefono");
                        empleado.rol = reader.GetString("rol");
                        empleado.horas = reader.GetInt16("horas");
                        empleado.sueldo = reader.GetFloat("sueldo");
                        empleado.fecha_Contrato = reader.GetDateTime("fecha_Contrato");
                        
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el empleado asociado a las credenciales proporcionadas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener datos del empleado: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return empleado;
        }
            
        public bool agregarEmpleados(clsEmpleados mEmpleado)
        {
            string INSERT = "INSERT INTO Empleados(id_Empleado , nombre , telefono , rol , horas , sueldo ,  fecha_Contrato) values (@id_Empleado,@nombre ,@telefono ,@rol ,@horas ,@sueldo ,@fecha_Contrato);";
            MySqlCommand mcCommand = new MySqlCommand(INSERT, conexiónMSQL.GetConnection());
            mcCommand.Parameters.Add(new MySqlParameter("@id_Empleado", mEmpleado.id_Empleado));
            mcCommand.Parameters.Add(new MySqlParameter("@nombre", mEmpleado.nombre));
            mcCommand.Parameters.Add(new MySqlParameter("@telefono", mEmpleado.telefono));
            mcCommand.Parameters.Add(new MySqlParameter("@rol", mEmpleado.rol));
            mcCommand.Parameters.Add(new MySqlParameter("@horas", mEmpleado.horas));
            mcCommand.Parameters.Add(new MySqlParameter("@sueldo", mEmpleado.sueldo));
            mcCommand.Parameters.Add(new MySqlParameter("@fecha_Contrato", mEmpleado.fecha_Contrato));

            return mcCommand.ExecuteNonQuery() > 0;

        }

        public bool eliminarEmpleado(int id_Empleado)
        {
            string DELETE = "DELETE FROM Empleados WHERE id_Empleado = @id_Empleado;";
            MySqlCommand mcCommand = new MySqlCommand(DELETE, conexiónMSQL.GetConnection());
            mcCommand.Parameters.Add(new MySqlParameter("@id_Empleado", id_Empleado));
            return mcCommand.ExecuteNonQuery() > 0;
        }

        public bool actualizarEmpleado(clsEmpleados mEmpleado)
        {
            string UPDATE = "UPDATE Empleados SET nombre = @nombre, telefono = @telefono, rol = @rol, horas = @horas, sueldo = @sueldo, fecha_Contrato = @fecha_Contrato WHERE id_Empleado = @id_Empleado;";
            MySqlCommand mcCommand = new MySqlCommand(UPDATE, conexiónMSQL.GetConnection());
            mcCommand.Parameters.Add(new MySqlParameter("@id_Empleado", mEmpleado.id_Empleado));
            mcCommand.Parameters.Add(new MySqlParameter("@nombre", mEmpleado.nombre));
            mcCommand.Parameters.Add(new MySqlParameter("@telefono", mEmpleado.telefono));
            mcCommand.Parameters.Add(new MySqlParameter("@rol", mEmpleado.rol));
            mcCommand.Parameters.Add(new MySqlParameter("@horas", mEmpleado.horas));
            mcCommand.Parameters.Add(new MySqlParameter("@sueldo", mEmpleado.sueldo));
            mcCommand.Parameters.Add(new MySqlParameter("@fecha_Contrato", mEmpleado.fecha_Contrato));
            return mcCommand.ExecuteNonQuery() > 0;
        }
    }
}