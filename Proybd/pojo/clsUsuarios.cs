using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proybd.pojo
{
    public class clsUsuarios
    {
        public int id_Usuario;
        private string usuario;
        private string contraseña;
        private string correo;
        private int id_Empleado;

        public int Id_Usuario
        {
            get
            {
                return id_Usuario;
            }
            set
            {
                id_Usuario = value;
            }
        }

        public string Usuario
        {
            get
            {
                return usuario;
            }
            set
            {
                usuario = value;
            }
        }

        public string Contraseña
        {
            get
            {
                return contraseña;
            }
            set
            {
                contraseña = value;
            }
        }

        public string Correo
        {
            get
            {
                return correo;
            }
            set
            {
                correo = value;
            }
        }

        public int Id_Empleado
        {
            get
            {
                return id_Empleado;
            }
            set
            {
                id_Empleado = value;
            }
        }


    }
}
