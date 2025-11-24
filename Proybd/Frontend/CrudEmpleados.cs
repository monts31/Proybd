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
using MySql.Data.MySqlClient;
using Proybd.pojo;

namespace Proybd.Frontend
{
    public partial class CrudEmpleados : Form
    {
        private List<clsEmpleados> mEmpleados;
        private clsEmpleados mEmpleado;
        private EmpleadosConsultas mEmpleadoConsultas;
        public CrudEmpleados()
        {
            InitializeComponent();
            mEmpleados = new List<clsEmpleados>();
            mEmpleadoConsultas = new EmpleadosConsultas();
            mEmpleado = new clsEmpleados();
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
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("El nombre no puede estar vacio");
                    return;
                }
                if (!txtTelefono.Text.All(char.IsDigit))
                {
                    MessageBox.Show("El telefono solo debe contener numeros");
                    return;
                }
                else if (txtTelefono.Text.Length != 10)
                {
                    MessageBox.Show("El telefono debe contener 10 digitos");
                    return;
                }

                cargarDatosEmpleado();
                if (mEmpleadoConsultas.agregarEmpleados(mEmpleado))
                {
                    MessageBox.Show("Empleado Agregado");
                    cargarEmpleados();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar empleado: " + ex.Message);
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
            mEmpleado.rol = txtRol.Text.Trim();
            mEmpleado.horas = int.Parse(txtHoras.Text.Trim());
            mEmpleado.sueldo = float.Parse(txtSueldo.Text.Trim());
            mEmpleado.fecha_Contrato = DateTime.Parse(txtfecha_Contrato.Text.Trim());

            if (txtRol.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el Rol 1 = Administrador 2 = Empleado");
            }
            if (txtHoras.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el numero de horas laborales");
            }
            if (txtSueldo.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el sueldo del empleado");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtId_Empleado.Text))
            {
                MessageBox.Show("Seleccione un empleado para eliminar");
                return;
            }
            DialogResult confirm = MessageBox.Show("¿Está seguro de que desea eliminar este empleado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            if (mEmpleadoConsultas.eliminarEmpleado(int.Parse(txtId_Empleado.Text.Trim())))
            {
                MessageBox.Show("Empleado Eliminado");
                cargarEmpleados();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el empleado");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtId_Empleado.Text))
                {
                    MessageBox.Show("Seleccione un empleado para modificar");
                    return;
                }
                if (!txtTelefono.Text.All(char.IsDigit))
                {
                    MessageBox.Show("El telefono solo debe contener numeros");
                    return;
                }
                else if (txtTelefono.Text.Length != 10)
                {
                    MessageBox.Show("El telefono debe contener 10 digitos");
                    return;
                }
                cargarDatosEmpleado();
                if (mEmpleadoConsultas.actualizarEmpleado(mEmpleado))
                {
                    MessageBox.Show("Empleado Modificado");
                    cargarEmpleados();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar empleado: " + ex.Message);
            }

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu menu = new frmMenu();
            menu.ShowDialog();
            this.Close();
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvEmpleados.Rows[e.RowIndex];
            txtId_Empleado.Text = Convert.ToString(fila.Cells["id_Empleado"].Value);
            txtNombre.Text = Convert.ToString(fila.Cells["nombre"].Value);
            txtTelefono.Text = Convert.ToString(fila.Cells["telefono"].Value);
            txtRol.Text = Convert.ToString(fila.Cells["rol"].Value);
            txtHoras.Text = Convert.ToString(fila.Cells["horas"].Value);
            txtSueldo.Text = Convert.ToString(fila.Cells["sueldo"].Value);
            txtSueldo.Text = Convert.ToString(fila.Cells["sueldo"].Value);
            txtfecha_Contrato.Text = Convert.ToString(fila.Cells["fecha_Contrato"].Value);

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInicio inicio = new frmInicio();
            inicio.ShowDialog();
            this.Close();
        }
    }
}
