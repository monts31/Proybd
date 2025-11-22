using Org.BouncyCastle.Utilities;
using Proybd.Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proybd.Frontend
{
    public partial class CrudEmpleados : Form
    {
        private List<Empleados> mEmpleados;
        private EmpleadosConsultas mEmpleadoConsultas;
        public CrudEmpleados()
        {
            InitializeComponent();
            mEmpleados = new List<Empleados>();
            mEmpleadoConsultas = new EmpleadosConsultas();

            cargarEmpleados();
        }

        private void cargarEmpleados(string filtro = "")
        {
            dgvEmpleados.Rows.Clear();
            dgvEmpleados.Refresh();
            mEmpleados.Clear();
            mEmpleados = mEmpleadoConsultas.getEmpleados(filtro);

            for (int i = 0; i < mEmpleados.Count; i++)
            {
                dgvEmpleados.RowTemplate.Height = 50;
                dgvEmpleados.Rows.Add(
                    mEmpleados[i] id_Empleado,
                    mEmpleados[i] nombre,
                    mEmpleados[i] telefono,
                    mEmpleados[i] rol,
                    mEmpleados[i] horas,
                    mEmpleados[i] sueldo,
                    mEmpleados[i] fecha_Contrato
                    );

            }
        }

        private void CrudEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            cargarEmpleados(txtBuscar.Text.Trim());
        }
    }
}
