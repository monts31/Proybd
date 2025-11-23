using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proybd.pojo
{
    public class clsEmpleados
    {
        public int id_Empleado { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }
        public byte rol { get; set; }
        public int horas { get; set; }
        public float sueldo { get; set; }
        public DateTime fecha_Contrato { get; set; }
    }
}
