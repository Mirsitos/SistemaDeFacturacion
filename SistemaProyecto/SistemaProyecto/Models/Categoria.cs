using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaProyecto.Models
{
    internal class Categoria
    {
        private int codigo;
        private string nombre;
        private int cantidad;

        public int Codigo { get => codigo; set => codigo = value; }  // PK
        public string Nombre { get => nombre; set => nombre = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        
        public Categoria() { }
        public Categoria(int codigo,string nombre, int cantidad)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Cantidad = cantidad;


        }
    }
}
