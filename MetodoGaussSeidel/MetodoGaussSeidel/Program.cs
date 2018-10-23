using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoGaussSeidel
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] Numeros = new double[3, 4];
            double[] Incognitas = new double[3];
            int TipoParada;
            double Valor;
            bool Salir = false, SalirProceso = false;
            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("\t\t\t\tMetodo Gauss-Seidel");
                    Console.WriteLine("\t\t\t   a11x1 + a12x2 + a13x3 = a14\n" +
                                      "\t\t\t   a21x1 + a22x2 + a23x3 = a24\n" +
                                      "\t\t\t   a31x1 + a32x2 + a33x3 = a34\n");
                    try
                    {
                        for (int Contador1 = 1; Contador1 < 4; Contador1++)
                        {
                            for (int Contador2 = 1; Contador2 < 5; Contador2++)
                            {
                                Console.Write("Ingrese a" + Contador1 + Contador2 + ": ");
                                Numeros[(Contador1 - 1), (Contador2 - 1)] = Convert.ToDouble(Console.ReadLine());
                            }
                        }
                        SalirProceso = true;
                    }
                    catch
                    {
                        SalirProceso = false;
                        Console.WriteLine("Ocurrio un error.\nPresione una tecla para continuar.");
                        Console.ReadKey();
                    }
                } while (SalirProceso == false);

                do
                {
                    Console.Clear();
                    Console.WriteLine("\t\t\t\tMetodo Gauss-Seidel");
                    Console.WriteLine("\t\t\t   a11x1 + a12x2 + a13x3 = a14\n" +
                                      "\t\t\t   a21x1 + a22x2 + a23x3 = a24\n" +
                                      "\t\t\t   a31x1 + a32x2 + a33x3 = a34\n");
                    try
                    {
                        for (int Contador1 = 1; Contador1 < 4; Contador1++)
                        {
                            Console.Write("Ingrese x" + Contador1 + ": ");
                            Incognitas[(Contador1 - 1)] = Convert.ToDouble(Console.ReadLine());
                        }
                        SalirProceso = true;
                    }
                    catch
                    {
                        SalirProceso = false;
                        Console.WriteLine("Ocurrio un error.\nPresione una tecla para continuar.");
                        Console.ReadKey();
                    }
                } while (SalirProceso == false);

                Proceso P = new Proceso(Numeros, Incognitas);
                do
                {
                    Console.Clear();
                    Console.WriteLine("\t\t\t\tMetodo Gauss-Seidel");
                    Console.WriteLine("\t\t\t   a11x1 + a12x2 + a13x3 = a14\n" +
                                      "\t\t\t   a21x1 + a22x2 + a23x3 = a24\n" +
                                      "\t\t\t   a31x1 + a32x2 + a33x3 = a34\n");
                    Console.WriteLine("Ingresa el numero de la opcion que desee:");
                    Console.WriteLine("1.- Por error");
                    Console.WriteLine("2.- Por iteraccion");
                    Console.Write("R: ");
                    try
                    {
                        TipoParada = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ingresa el valor: ");
                        Valor = Convert.ToDouble(Console.ReadLine());
                        if (TipoParada == 1)
                        {
                            P.Solucion(TipoParada, Valor);
                            SalirProceso = true;
                        }
                        else if (TipoParada == 2)
                        {
                            P.Solucion(TipoParada, Valor);
                            SalirProceso = true;
                        }
                        else
                        {
                            Console.WriteLine("A ocurrido un error, intentelo de nuevo por favor.\nPresione una tecla para continuar.");
                            Console.ReadKey();
                            SalirProceso = false;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("A ocurrido un error, intentelo de nuevo por favor.\nPresione una tecla para continuar.");
                        Console.ReadKey();
                        SalirProceso = false;
                    }
                } while (SalirProceso == false);
                Console.ReadKey();
            } while (Salir == false);
        }
    }
}
