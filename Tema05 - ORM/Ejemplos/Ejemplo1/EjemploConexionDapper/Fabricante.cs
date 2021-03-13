using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploConexionDapper
{
    class Fabricante
    {
        int Codigo;
        string Nombre;

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
