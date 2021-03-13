using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad9
{
    public class Fabricante
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }

        public Fabricante(int codigo, string nombre)
        {
            Codigo = codigo;
            Nombre = nombre;
        }

        public override string ToString()
        {
            return "Codigo: " + this.Codigo + ", Nombre: " + this.Nombre;
        }

    }
}
