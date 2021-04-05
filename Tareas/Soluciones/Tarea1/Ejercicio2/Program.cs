using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Cuente las haches intercaladas");
            Console.WriteLine("2. Cuente sólo las palabras con hache intercalada.");
            int opcion = Int32.Parse(Console.ReadLine());

            StreamReader fichero;
            string linea;
            int contador = 0;

            fichero = File.OpenText("../../../ejercicio2.txt");


            switch (opcion)
            {
                case 1:
                {
                    do
                    {
                        linea = fichero.ReadLine();
                        if (linea != null)
                        {
                            string[] regs = linea.Split(' ');
                            char letraAnterior = 'z';
                                foreach (string palabra in regs)
                            {
                                if (palabra.Contains('h'))
                                {
                                    for (int i = 0; i < palabra.Length; i++)
                                    {
                                        if (palabra[i] == 'h' && (i != 0 && i != palabra.Length && letraAnterior != 'c'))
                                        {
                                            contador += 1;
                                        }

                                        letraAnterior = palabra[i];
                                    }
                                }
                            }

                        }
                    } while (linea != null);

                    fichero.Close();
                    Console.WriteLine("Hay " + contador + " haches intercaladas.");
                    break;
                }


                case 2:
                {
                    do
                    {
                        linea = fichero.ReadLine();
                        if (linea != null)
                        {
                            string[] regs = linea.Split(' ');
                            char letraAnterior = 'z';
                            foreach (string palabra in regs)
                            {
                                if (palabra.Contains('h'))
                                {
                                    for (int i = 0; i < palabra.Length; i++)
                                    {
                                        if (palabra[i] == 'h' && (i != 0 && i != palabra.Length && letraAnterior != 'c'))
                                        {
                                            contador += 1;
                                            break;
                                        }

                                        letraAnterior = palabra[i];
                                    }
                                }
                            }

                        }
                    } while (linea != null);
                    
                    fichero.Close(); 
                    Console.WriteLine("Hay " + contador + " palabras con haches intercaladas."); 
                    break;
                }

            }

            Console.ReadLine();
        }
    }
}
