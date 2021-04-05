using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariñoFidalgoMarcos_Tarea05.Entidades
{
    class Equipo
    {
        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public string Pais { get; set; }

        public int Goles { get; set; }

        public int Puntos { get; set; }

        public string PJ { get; set; }

        public int PG { get; set; }

        public int PE { get; set; }

        public int PP { get; set; }

        public string Estadio { get; set; }

        public string Ciudad { get; set; }

        public Equipo(string codigo, string nombre, string pais, int goles, int puntos, string pJ, int pG, int pE, int pP, string estadio, string ciudad)
        {
            Codigo = codigo;
            Nombre = nombre;
            Pais = pais;
            Goles = goles;
            Puntos = puntos;
            PJ = pJ;
            PG = pG;
            PE = pE;
            PP = pP;
            Estadio = estadio;
            Ciudad = ciudad;
        }

        public Equipo()
        {
        }

        public override string ToString()
        {
            return Codigo + " " + Nombre + " " + Pais + " " + Goles + " " + Puntos + " " + PJ + " " + PG + " " + PE + " " + PP + " " + Estadio + " " + Ciudad ;
        }

       public string equipos()
        {
            return Codigo + "/" + Nombre + " " + Pais;
        }
    }
}
