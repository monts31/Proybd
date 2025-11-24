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

        private List<clsProductos> Products;
        clsEmpleados empleado = new clsEmpleados();
        int[] cantidad;
        private ProductosConsultas productosConsultas;
        clsUsuarios usuarioActual = new clsUsuarios();
        public frmMenu()
        {
            InitializeComponent();
            Products = new List<clsProductos>();
            productosConsultas = new ProductosConsultas();
            txtEmpleado.Text = ClsSesion.UsuarioActual.Id_Usuario.ToString();
        }


       /* public frmMenu(clsUsuarios usuario)
        {
            InitializeComponent();
            Products = new List<clsProductos>();
            productosConsultas = new ProductosConsultas();
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
        }*/

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            cargarProducto(sender);

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Products = productosConsultas.getProductos();
            cantidad = new int[Products.Count];
            pic1.Tag = Products[0].id_Producto;
            pic2.Tag = Products[1].id_Producto;
            pic3.Tag = Products[2].id_Producto;
            pic4.Tag = Products[3].id_Producto;
            pic5.Tag = Products[4].id_Producto;
            pic6.Tag = Products[5].id_Producto;
            pic7.Tag = Products[6].id_Producto;
            pic8.Tag = Products[7].id_Producto;

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

        private void btnRechazar_Click(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInicio inicio = new frmInicio();
            inicio.ShowDialog();
            this.Close();
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            cargarProducto(sender);

        }
        private void cargarProducto(object sender)
        {
            PictureBox pb = sender as PictureBox;
            int id = Convert.ToInt32(pb.Tag);
            agregarProductos(id);
        }

        private void agregarProductos(int id)
        {
            int index = Products.FindIndex(p => p.id_Producto == id);
            if (index == -1) return;

            cantidad[index]++; // aumentar la cantidad
            var producto = Products[index];
            float subtotal = producto.precio * cantidad[index];
            // Revisar si ya está en el datagrid
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToInt32(row.Cells[0].Value) == id)
                {
                    row.Cells[2].Value = cantidad[index]; // actualizar cantidad
                    row.Cells[3].Value = subtotal; // actualizar subtotal
                    return;
                }
            }

            // Si no está, agregarlo nuevo

            dataGridView1.Rows.Add(
                producto.id_Producto,
                producto.nombre,
                cantidad[index],
                subtotal
            );

        }

        private void pic2_Click(object sender, EventArgs e)
        {
            cargarProducto(sender);
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            cargarProducto(sender);
        }

        private void pic5_Click(object sender, EventArgs e)
        {
            cargarProducto(sender);
        }

        private void pic6_Click(object sender, EventArgs e)
        {
            cargarProducto(sender);
        }

        private void pic7_Click(object sender, EventArgs e)
        {
            cargarProducto(sender);
        }

        private void pic8_Click(object sender, EventArgs e)
        {
            cargarProducto(sender);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dataGridView1.CurrentRow;
            int idProducto = Convert.ToInt32(fila.Cells[0].Value);

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            clsOrdenes orden = new clsOrdenes();
            clsConsultaVentas consultaVentas = new clsConsultaVentas();
            float total = 0;
            orden.id_Usuario = ClsSesion.id;
            orden.fecha = DateTime.Now;
            // registrar detalles int ord = consultaVentas.ventaRealizada(orden);
            MessageBox.Show("ID usuario que se envía: " + ClsSesion.id);

            /*foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                clsDetallesOrden detalles = new clsDetallesOrden();
                detalles.id_Orden = ord;
                //detalles.id_Producto = Convert.ToInt32(row.Cells[0].Value);
                detalles.cantidad = Convert.ToInt32(row.Cells[2].Value);
                detalles.precio = Convert.ToSingle(row.Cells[3].Value) / detalles.cantidad;
                
                consultaVentas.detalleOrden(detalles);


                total += orden.precio * orden.cantidad;

            }*/
            /*if (ord > 0)
                MessageBox.Show("Venta registrada con éxito. ID Orden: " + ord);
            else
                MessageBox.Show("No se pudo registrar la venta.");*/
        
        MessageBox.Show("Total: $" + total.ToString("0.00"), "Total de la venta");

        }
    }
}
