using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proybd.Backend;
using Proybd.pojo;

namespace Proybd.Frontend
{
    public partial class CrudProductos : Form
    {
        private List<clsProductos> Products;
        private clsProductos productoSeleccionado;
        private ProductosConsultas productosConsultas;

        public CrudProductos()
        {
            InitializeComponent();
            Products = new List<clsProductos>();
            productosConsultas = new ProductosConsultas();
            productoSeleccionado = new clsProductos();
            cargarProductos();
        }

        public void cargarProductos()
        {
            dgvProductos.Rows.Clear();
            dgvProductos.Refresh();

            Products = productosConsultas.getProductos();
            foreach (var producto in Products)
            {
                dgvProductos.RowTemplate.Height = 50;
                dgvProductos.Rows.Add(
                    producto.id_Producto,
                    producto.nombre,
                    producto.descripcion,
                    producto.precio,
                    producto.stock,
                    producto.foto
                );
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("El nombre no puede estar vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("Tiene que tener una descripcion el producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if ((!float.TryParse(txtPrecio.Text, out float precio)))
                {
                    MessageBox.Show("El precio debe ser un número válido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if ((!int.TryParse(txtStock.Text, out int stock)))
                {
                    MessageBox.Show("El stock debe ser un número válido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                clsProductos nuevoProducto = new clsProductos
                {
                    nombre = txtNombre.Text.Trim(),
                    descripcion = txtDescripcion.Text.Trim(),
                    precio = precio,
                    stock = stock,
                    foto = null
                };
                if (productosConsultas.agregarProducto(nuevoProducto))
                {
                    MessageBox.Show("Producto insertado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarProductos();
                    txtNombre.Clear();
                    txtDescripcion.Clear();
                    txtPrecio.Clear();
                    txtStock.Clear();

                }
                else
                {
                    MessageBox.Show("No se pudo insertar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al intentar insertar el producto:\n{ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrWhiteSpace(txtId_Producto.Text))
                {
                    MessageBox.Show("Seleccione un producto a modificar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("El nombre no puede estar vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("Tiene que tener una descripcion el producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if ((!float.TryParse(txtPrecio.Text, out float precio)))
                {
                    MessageBox.Show("El precio debe ser un número válido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if ((!int.TryParse(txtStock.Text, out int stock)))
                {
                    MessageBox.Show("El stock debe ser un número válido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                clsProductos productoModificado = new clsProductos
                {
                    id_Producto = int.Parse(txtId_Producto.Text.Trim()),
                    nombre =  txtNombre.Text.Trim(),
                    descripcion = txtDescripcion.Text.Trim(),
                    precio = precio,
                    stock = stock,
                    foto = null
                };
                if (productosConsultas.actualizarProducto(productoModificado))
                {
                    MessageBox.Show("Producto modificado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarProductos();
                    txtId_Producto.Clear();
                    txtNombre.Clear();
                    txtDescripcion.Clear();
                    txtPrecio.Clear();
                    txtStock.Clear();
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al intentar modificar el producto:\n{ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtId_Producto.Text)) { 
                 MessageBox.Show("Seleccione un producto a eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                DialogResult confirm = MessageBox.Show("¿Está seguro de que desea eliminar este producto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    int idProducto = int.Parse(txtId_Producto.Text.Trim());
                    if (productosConsultas.eliminarPRoducto(idProducto))
                    {
                        MessageBox.Show("Producto eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarProductos();
                        txtId_Producto.Clear();
                        txtNombre.Clear();
                        txtDescripcion.Clear();
                        txtPrecio.Clear();
                        txtStock.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al intentar eliminar el producto:\n{ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblStock_Click(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInicio inicio = new frmInicio();
            inicio.ShowDialog();
            this.Close();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];
            txtId_Producto.Text = Convert.ToString(fila.Cells[0].Value);
            txtNombre.Text = Convert.ToString(fila.Cells[1].Value);
            txtDescripcion.Text = Convert.ToString(fila.Cells[2].Value);
            txtPrecio.Text = Convert.ToString(fila.Cells[3].Value);
            txtStock.Text = Convert.ToString(fila.Cells[4].Value);

        }
    }
}
