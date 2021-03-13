using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad9
{
    public class Producto
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Codigo_Fabricante { get; set; }

        public Producto(int codigo, string nombre, double precio, int codigo_Fabricante)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Codigo_Fabricante = codigo_Fabricante;
        }

        public override string ToString()
        {
            return "Codigo: " + this.Codigo + ", Nombre: " + this.Nombre + ", Precio: " + this.Precio;
        }

    }
}
