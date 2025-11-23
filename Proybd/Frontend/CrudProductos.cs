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

namespace Proybd.Frontend
{
    public partial class CrudProductos : Form
    {
        private List<Productos> Products;
        private Productos productoSeleccionado;
        private ProductosConsultas productosConsultas;

        public CrudProductos()
        {
            InitializeComponent();
            Products = new List<Productos>();
            productosConsultas = new ProductosConsultas();
            productoSeleccionado = new Productos();
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
        
            
           
        
    }
}
