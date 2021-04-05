using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader fichero;
            string linea;
            int contador = 0; 

            fichero = File.OpenText("../../../ejercicio1.txt");

            do
            {
                linea = fichero.ReadLine();
                if (linea != null)
                {
                    string[] regs  = linea.Split(' ');
                    foreach (string palabra in regs)
                    {
                        contador += 1;
                    }

                }
            } while (linea != null);
            Console.WriteLine("Hay " + contador + " palabras en este archivo de texto.");
            fichero.Close();
            Console.ReadLine();
        }
    }
}
