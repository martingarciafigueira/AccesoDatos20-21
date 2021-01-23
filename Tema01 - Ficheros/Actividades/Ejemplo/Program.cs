using System;
using System.IO;

namespace Ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader fichero;
            string linea;

            if (File.Exists("PruebaMontecastelo.txt"))
            {
                fichero = File.OpenText("PruebaMontecastelo.txt");
                linea = fichero.ReadLine();
                Console.WriteLine(linea);
                Console.WriteLine(fichero.ReadLine());
                fichero.Close(); 
            }

        }
    }
}
