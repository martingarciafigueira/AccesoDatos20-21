using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploConexionDapper
{
    public class Fabricante
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }

        public Fabricante(string nombre)
        {
            this.Nombre = nombre;
        }

        public Fabricante(int codigo, string nombre)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
        }

        public override string ToString()
        {
            return "Codigo: " +this.Codigo + " Nombre: " + this.Nombre;
        }
    }
}
