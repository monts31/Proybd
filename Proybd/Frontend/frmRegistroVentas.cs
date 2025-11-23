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
    public partial class frmRegistroVentas : Form
    {
        public frmRegistroVentas()
        {
            InitializeComponent();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
