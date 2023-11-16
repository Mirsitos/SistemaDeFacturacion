using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaProyecto.Models
{
    public class Empleado
    {
        // Datos por cada tabla

        
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; } // PK
        public string Posicion { get; set; }
        public string Mail{ get; set; }
        
        
    }
}
