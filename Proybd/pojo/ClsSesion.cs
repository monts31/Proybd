using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proybd.pojo
{
    public static class ClsSesion
    {
        public static clsUsuarios UsuarioActual { get; set; }
        public static clsEmpleados EmpleadoActual { get; set; }
        public static int id { get; set; }
        public static string tipo { get; set; }
    }
}
