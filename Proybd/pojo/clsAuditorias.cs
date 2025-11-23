using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Proybd.pojo
{
    public class clsAuditorias
    {
            public int id_Auditorias {  get; set; }
            public int id_Usuario { get; set; }
            public string cambio { get; set; }
            public float valor_Anterior {  get; set; }
            public float valor_Nuevo { get; set; }
            public DateTime fecha { get; set; }

    }
}
