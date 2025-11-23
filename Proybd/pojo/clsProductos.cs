using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proybd.pojo
{
    public class clsProductos
    {
        public int id_Producto { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public float precio { get; set; }
        public int stock {  get; set; }
        public byte[] foto { get; set; }

    }
}
