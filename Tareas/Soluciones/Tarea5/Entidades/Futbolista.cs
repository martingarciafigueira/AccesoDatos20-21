using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariñoFidalgoMarcos_Tarea05.Entidades
{
    class Futbolista
    {
        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public string Equipo { get; set; }

        public string CodigoEquipo { get; set; }

        public string Posicion { get; set; }

        public int Edad { get; set; }

        public int Goles { get; set; }

        public int TA { get; set; }

        public int TR { get; set; }

        public int Minutos { get; set; }

        public string PrecioMercado { get; set; }

        public int Dorsal { get; set; }

        public int Peso { get; set; }

        public Futbolista(string codigo, string nombre, string equipo, string codigoEquipo, string posicion, int edad, int goles, int tA, int tR, int minutos, string precioMercado, int dorsal, int peso)
        {
            Codigo = codigo;
            Nombre = nombre;
            Equipo = equipo;
            CodigoEquipo = codigoEquipo;
            Posicion = posicion;
            Edad = edad;
            Goles = goles;
            TA = tA;
            TR = tR;
            Minutos = minutos;
            PrecioMercado = precioMercado;
            Dorsal = dorsal;
            Peso = peso;
        }

        public Futbolista()
        {
        }

        public override string ToString()
        {
            return Codigo + " " + Nombre + " " + Equipo + " " + CodigoEquipo + " " + Posicion + " " + Edad + " " + Goles + " " + TA + " " + TR + " " + Minutos + " " + PrecioMercado + " " + Dorsal + " " + Peso;
        }

        public string datosFutbolista()
        {
            return Codigo + "/" + Nombre + " " + Equipo + " " + Posicion + " " + Edad;
        }

        public string futbolistaEquipo()
        {
            return CodigoEquipo + "/" + Nombre + " " + Posicion + " " + Edad + " " + Goles;
        }
    }
}
