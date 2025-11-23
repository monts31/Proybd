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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu menu = new frmMenu();
            menu.ShowDialog();
            this.Close();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrudProductos productos = new CrudProductos();
            productos.ShowDialog();
            this.Close();
        }

        private void btnRegistrosDeVentas_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistroVentas registroVentas = new frmRegistroVentas();
            registroVentas.ShowDialog();
            this.Close();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrudEmpleados empleados = new CrudEmpleados();
            empleados.ShowDialog();
            this.Close();
        }

        private void btnAuditorias_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAuditorias auditorias = new frmAuditorias();
            auditorias.ShowDialog();
            this.Close();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }
    }
}
