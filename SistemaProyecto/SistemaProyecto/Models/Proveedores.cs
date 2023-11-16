using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaProyecto.Models
{
    public class Proveedores
    {
        
        private string nombre;
        private string direccion;
        private string telefono;
        private string mail;

        public string Nombre { get => nombre; set => nombre = value; }  // PK
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Mail { get => mail; set => mail= value; }

        public Proveedores() { }
        public Proveedores (string nombre, string direccion, string telefono, string mail)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.mail = mail;
        }
    }
}
