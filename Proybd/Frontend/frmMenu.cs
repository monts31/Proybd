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

namespace Proybd.Frontend
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            
        }

        public frmMenu(clsConsultaUsuarios usuario)
        {
            InitializeComponent();
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
