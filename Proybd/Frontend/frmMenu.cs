using Proybd.Backend;
using Proybd.pojo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proybd.Frontend
{
    public partial class frmMenu : Form
    {
        clsEmpleados empleado = new clsEmpleados();
        public frmMenu()
        {
            InitializeComponent();
            
        }

        public frmMenu(clsUsuarios usuario)
        {
            InitializeComponent();
            EmpleadosConsultas cons = new EmpleadosConsultas();
            empleado = cons.obtenerEmpleado(usuario);

            string nombreEmpleado = empleado.nombre;
            if (nombreEmpleado != null)
            {
                txtEmpleado.Text = nombreEmpleado;
                MessageBox.Show("Bienvenido " + empleado.nombre, "Inicio de sesión exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo obtener el nombre del empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

                txtEmpleado.Enabled = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrudEmpleados empleados = new CrudEmpleados();
            empleados.ShowDialog();
            this.Close();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrudProductos productos = new CrudProductos();
            productos.ShowDialog();
            this.Close();
        }
    }
}
