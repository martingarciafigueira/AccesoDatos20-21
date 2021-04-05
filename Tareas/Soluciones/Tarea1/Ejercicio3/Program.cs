using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader lector;
            StreamWriter escritor;

            string nombreArchivoA;
            string nombreArchivoB;
            string linea;

            Console.WriteLine("Introduzca el nombre del archivo A (ejercicio1 o ejercicio2)");
            nombreArchivoA = Console.ReadLine() + ".txt";

            Console.WriteLine("Introduzca el nombre del archivo B");
            nombreArchivoB = Console.ReadLine() + ".txt";

            lector = new StreamReader("../../../" + nombreArchivoA);
            escritor = File.CreateText("../../../" + nombreArchivoB);
            

            do
            {
                linea = lector.ReadLine();
                bool siguienteLinea = false;
                if (linea != null)
                {
                    for (int i = 0; i < linea.Length; i++)
                    {
                        escritor.Write(linea[i]);
                    }
                    escritor.WriteLine();
                }
            } while (linea != null);
            lector.Close();
            escritor.Close();
            Console.WriteLine("Se ha copiado el contenido.");
            Console.ReadLine();

        }
    }
}
