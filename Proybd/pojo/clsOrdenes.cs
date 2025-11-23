using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proybd.pojo
{
    public class clsOrdenes
    {
        public int id_Orden { get; set; }
        public int id_Producto { get; set; }
        public float precio { get; set; }
        public int cantidad { get; set; }
    }
}
