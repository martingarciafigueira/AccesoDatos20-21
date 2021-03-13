using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploConexionDapper
{
    class Producto
    {
        int Codigo;
        string Nombre;
        double Precio;
        int Codigo_Fabricante;

        public Producto(int codigo, string nombre, double precio, int codigo_Fabricante)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Codigo_Fabricante = codigo_Fabricante;
        }

        public override string ToString()
        {
            return "Codigo: " + this.Codigo + " Nombre: " + this.Nombre + " Precio: " + this.Precio + " Codigo fabricante: " + this.Codigo_Fabricante;
        }

    }
}
