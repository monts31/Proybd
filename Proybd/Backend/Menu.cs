using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proybd.Backend
{
    internal class Menu
    {
        public int id_Producto { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public float precio { get; set; }
        public int strock {  get; set; }
        public byte[] foto { get; set; }

    }
}
