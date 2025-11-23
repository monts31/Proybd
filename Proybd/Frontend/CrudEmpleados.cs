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
        private Empleados mEmpleado;
        private EmpleadosConsultas mEmpleadoConsultas;
        public CrudEmpleados()
        {
            InitializeComponent();
            mEmpleados = new List<Empleados>();
            mEmpleadoConsultas = new EmpleadosConsultas();
            mEmpleado = new Empleados();
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
            if (!datosCorrectos())
            {
                return;
            }

        private bool datosCorrectos()
        {
            if (txtNombre.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el nombre");
                return false;
            }
        }

        private void LimpiarCampos()
        {
            txtId_Empleado.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtRol.Text = "";
            txtHoras.Text = "";
            txtSueldo.Text = "";
            txtfecha_Contrato.Text = "";

        }

        private void cargarDatosEmpleado()
        {

            mEmpleado.id_Empleado = int.Parse(txtId_Empleado.Text.Trim());
            mEmpleado.nombre = txtNombre.Text.Trim();
            mEmpleado.telefono = txtTelefono.Text.Trim();
            mEmpleado.rol = byte.Parse(txtRol.Text.Trim());
            mEmpleado.horas = int.Parse(txtHoras.Text.Trim());
            mEmpleado.sueldo = float.Parse(txtSueldo.Text.Trim());
            mEmpleado.fecha_Contrato = DateTime.Parse(txtfecha_Contrato.Text.Trim());

        }

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

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvEmpleados.Rows[e.RowIndex];
            txtId_Empleado.Text = Convert.ToString(fila.Cells["id_Empleado"].Value);
            txtNombre.Text = Convert.ToString(fila.Cells["nombre "].Value);
            txtTelefono.Text = Convert.ToString(fila.Cells["telefono"].Value);
            txtRol.Text = Convert.ToString(fila.Cells["rol "].Value);
            txtHoras.Text = Convert.ToString(fila.Cells["horas"].Value);
            txtSueldo.Text = Convert.ToString(fila.Cells["sueldo"].Value);
            txtSueldo.Text = Convert.ToString(fila.Cells["sueldo"].Value);
            txtfecha_Contrato.Text = Convert.ToString(fila.Cells["fecha_Contrato "].Value);



        }
    }
}
