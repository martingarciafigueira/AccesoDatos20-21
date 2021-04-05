using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader lector;
            String linea;
            int contador = 0;

            lector = new StreamReader("../../../ejercicio4.txt");
           

            do
            {
                linea = lector.ReadLine();
                if (linea != null)
                {
                    Console.WriteLine(linea);
                    contador += 1;
                    if (contador == 23)
                    {
                        Console.WriteLine();
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - - -");
                        Console.WriteLine("Presione la tecla enter para continuar leyendo.");
                        Console.ReadLine();
                        contador = 0;
                    }
                }
            } while (linea != null);
            lector.Close();
            Console.ReadLine();
        }
    }
}
