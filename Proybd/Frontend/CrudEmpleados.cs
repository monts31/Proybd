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
                    mEmpleados[i].id_Empleado,
                    mEmpleados[i].nombre,
                    mEmpleados[i].telefono,
                    mEmpleados[i].rol,
                    mEmpleados[i].horas,
                    mEmpleados[i].sueldo,
                    mEmpleados[i].fecha_Contrato
                    );

            }
        }

        private void CrudEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            cargarEmpleados(txtBuscar.Text.Trim());
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

        }

        private bool datosCorrectos()
        {
            if (txtNombre.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el nombre");
                return false;
            }
            if (txtTelefono.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el Telefono");
                return false;

            }
            if (txtRol.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el Rol 1 = Administrador 2 = Empleado");
                return false;

            }
            if (txtHoras.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el numero de horas de laburo");
                return false;

            }
            if (txtSueldo.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el sueldo del empleado");
                return false;

            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {

        }
    }
}
