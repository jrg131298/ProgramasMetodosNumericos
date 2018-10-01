using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoDeFalsaPosicion
{
    class Metodo
    {
        static void Main(string[] args)
        {
            bool Opcion = false;
            do
            {
                Console.Clear();
                Console.WriteLine("---------------------Metodo de falsa posicion---------------------");
                try
                {
                    Console.Write("Ingresa el exponente mas alto: ");
                    Int16 Exponentes = Convert.ToInt16(Console.ReadLine());
                    double[] Coeficientes = new double[(Exponentes + 1)];

                    if(Exponentes > 0)
                    {
                        for(int Contador = 0, Posicion = Exponentes; Contador <= Exponentes; Contador++, Posicion--)
                        {
                            if(Contador == Exponentes)
                            {
                                Console.Write("Ingresa el numero sin variable: ");
                                Coeficientes[Contador] = Convert.ToDouble(Console.ReadLine());
                            }
                            else
                            {
                                Console.Write("Ingresa el coeficiente de x^{0}: ", Posicion);
                                Coeficientes[Contador] = Convert.ToDouble(Console.ReadLine());
                            }
                        }

                        do
                        {
                            Console.Clear();
                            Console.WriteLine("---------------------Metodo de falsa posicion---------------------");
                            Console.Write("Ingresa el intervalo menor: ");
                            double Xi = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Ingresa el intervalo mayor: ");
                            double Xu = Convert.ToDouble(Console.ReadLine());

                            double Fxi = 0, Fxu = 0;
                            for (int Contador = 0, Posicion = Exponentes; Contador <= Exponentes; Contador++, Posicion--)
                            {
                                if (Contador == Exponentes)
                                {
                                    Fxi = Fxi + Coeficientes[Contador];
                                    Fxu = Fxu + Coeficientes[Contador];
                                }
                                else
                                {
                                    Fxi = Fxi + ((Math.Pow(Xi, Posicion)) * Coeficientes[Contador]);
                                    Fxu = Fxu + ((Math.Pow(Xu, Posicion)) * Coeficientes[Contador]);
                                }
                            }

                            if ((Fxi > 0 && Fxu > 0) || (Fxi < 0 && Fxu < 0))
                            {
                                Console.WriteLine("Ingresaste valores de Xi y Xu erroneos.\nPresiona un boton para continuar.");
                                Console.ReadKey();
                                Opcion = false;
                            }
                            else
                            {
                                do
                                {
                                    Console.Clear();
                                    Console.WriteLine("---------------------Metodo de falsa posicion---------------------");
                                    Console.WriteLine("Ingresa el numero de la opcion que desees: ");
                                    Console.WriteLine("1.- Realizar por iteracciones.");
                                    Console.WriteLine("2.- Realizar por error sugerido.");
                                    Console.Write("R: ");
                                    Int16 Cual = Convert.ToInt16(Console.ReadLine());
                                    Proceso P = new Proceso(Exponentes, Coeficientes, Xi, Xu);
                                    if (Cual == 1)
                                    {
                                        P.Iteraccion();
                                        Opcion = true;
                                    }
                                    else if(Cual == 2)
                                    {
                                        P.Procentaje();
                                        Opcion = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ingresa un porcentaje positivo.\nPresione una tecla para continuar.");
                                        Console.ReadKey();
                                    }
                                } while (Opcion == false);     
                            }
                        } while (Opcion == false);
                    }
                    else
                    {
                        Console.WriteLine("Ingresa otro valor.");
                    }
                }
                catch{ Console.WriteLine("A ocurrido un error, intente de nuevo.");}
                finally{ Console.WriteLine("Gracias por utilizar el programa."); }
                Console.WriteLine("Presiona una tecla para continuar.");
                Console.ReadKey();
            } while (Opcion == false);
        }
    }

    class Proceso
    {
        private double Xi, Xu, Xr = 0, Auxiliar, Error = 100, ValorAbsoluto;
        private Int16 Exponentes;
        private double[] Coeficientes;

        public Proceso(Int16 Exponentes, double[] Coeficientes, double Xi, double Xu)
        {
            this.Exponentes = Exponentes;
            this.Coeficientes = Coeficientes;
            this.Xi = Xi;
            this.Xu = Xu;
        }

        public void Iteraccion()
        {
            bool SalidaProceso = false;
            do
            {
                Console.Clear();
                Console.WriteLine("---------------------Metodo de falsa posicion---------------------");
                Console.Write("Ingresa el numero de iteraciones deseadas: ");
                Int16 Iteraciones = Convert.ToInt16(Console.ReadLine());
                if (Iteraciones > 0)
                {
                    Int16 Contador = 1;
                    do
                    {
                        double Fxi = 0, Fxu = 0, Fxr = 0;
                        for (int Contador2 = 0, Posicion = Exponentes; Contador2 <= Exponentes; Contador2++, Posicion--)
                        {
                            if (Contador2 == Exponentes)
                            {
                                Fxi = Fxi + Coeficientes[Contador2];
                                Fxu = Fxu + Coeficientes[Contador2];
                            }
                            else
                            {
                                Fxi = Fxi + ((Math.Pow(Xi, Posicion)) * Coeficientes[Contador2]);
                                Fxu = Fxu + ((Math.Pow(Xu, Posicion)) * Coeficientes[Contador2]);
                            }
                        }

                        Auxiliar = Xr;
                        Xr = (((Xi * Fxu) - (Xu * Fxi)) / (Fxu - Fxi));
                        for (int Contador2 = 0, Posicion = Exponentes; Contador2 <= Exponentes; Contador2++, Posicion--)
                        {
                            if (Contador2 == Exponentes)
                            {
                                Fxr = Fxr + Coeficientes[Contador2];
                            }
                            else
                            {
                                Fxr = Fxr + ((Math.Pow(Xr, Posicion)) * Coeficientes[Contador2]);
                            }
                        }

                        Console.WriteLine("----------Iteraccion {0}----------", Contador);
                        Console.WriteLine("Xi: {0:0.000000}", Xi);
                        Console.WriteLine("Xu: {0:0.000000}", Xu);
                        Console.WriteLine("f(Xi): {0:0.000000}", Fxi);
                        Console.WriteLine("f(Xu): {0:0.000000}", Fxu);
                        Console.WriteLine("Xr: {0:0.000000}", Xr);
                        Console.WriteLine("f(Xr): {0:0.000000}", Fxr);

                        if (Contador == 1)
                        {
                            Console.WriteLine("Error: 100%");
                        }
                        else
                        {
                            ValorAbsoluto = Xr - Auxiliar;
                            if(ValorAbsoluto < 0)
                            {
                                ValorAbsoluto = (ValorAbsoluto * (-1));
                            }
                            else{ }
                            Error = ((ValorAbsoluto / Xr) * 100);
                            Console.WriteLine("Error: {0:0.000000}%", Error);
                        }

                        if((Fxi * Fxr) > 0)
                        {
                            Xi = Xr;
                        }
                        else
                        {
                            Xu = Xr;
                        }
                        Contador++;
                    } while (Contador <= Iteraciones);
                    SalidaProceso = true;
                }
                else
                {
                    Console.WriteLine("Ingresa un valor mayor a 0.");
                    Console.ReadKey();
                }
            }
            while (SalidaProceso == false);
        }

        public void Procentaje()
        {
            bool SalidaProceso = false;
            do
            {
                Console.Clear();
                Console.WriteLine("---------------------Metodo de falsa posicion---------------------");
                Console.Write("Ingresa el error deseado: ");
                double ErrorSugerido = Convert.ToDouble(Console.ReadLine());
                if(ErrorSugerido > 0)
                {
                    Int16 Contador = 1;
                    do
                    {
                        double Fxi = 0, Fxu = 0, Fxr = 0;
                        for (int Contador2 = 0, Posicion = Exponentes; Contador2 <= Exponentes; Contador2++, Posicion--)
                        {
                            if (Contador2 == Exponentes)
                            {
                                Fxi = Fxi + Coeficientes[Contador2];
                                Fxu = Fxu + Coeficientes[Contador2];
                            }
                            else
                            {
                                Fxi = Fxi + ((Math.Pow(Xi, Posicion)) * Coeficientes[Contador2]);
                                Fxu = Fxu + ((Math.Pow(Xu, Posicion)) * Coeficientes[Contador2]);
                            }
                        }

                        Auxiliar = Xr;
                        Xr = (((Xi * Fxu) - (Xu * Fxi)) / (Fxu - Fxi));
                        for (int Contador2 = 0, Posicion = Exponentes; Contador2 <= Exponentes; Contador2++, Posicion--)
                        {
                            if (Contador2 == Exponentes)
                            {
                                Fxr = Fxr + Coeficientes[Contador2];
                            }
                            else
                            {
                                Fxr = Fxr + ((Math.Pow(Xr, Posicion)) * Coeficientes[Contador2]);
                            }
                        }

                        Console.WriteLine("----------Iteraccion {0}----------", Contador);
                        Console.WriteLine("Xi: {0:0.000000}", Xi);
                        Console.WriteLine("Xu: {0:0.000000}", Xu);
                        Console.WriteLine("f(Xi): {0:0.000000}", Fxi);
                        Console.WriteLine("f(Xu): {0:0.000000}", Fxu);
                        Console.WriteLine("Xr: {0:0.000000}", Xr);
                        Console.WriteLine("f(Xr): {0:0.000000}", Fxr);

                        if (Contador == 1)
                        {
                            Console.WriteLine("Error: 100%");
                        }
                        else
                        {
                            ValorAbsoluto = Xr - Auxiliar;
                            if (ValorAbsoluto < 0)
                            {
                                ValorAbsoluto = (ValorAbsoluto * (-1));
                            }
                            else { }
                            Error = ((ValorAbsoluto / Xr) * 100);
                            Console.WriteLine("Error: {0}%", Error);
                        }

                        if ((Fxi * Fxr) > 0)
                        {
                            Xi = Xr;
                        }
                        else
                        {
                            Xu = Xr;
                        }
                        Contador++;
                    } while (Error >= ErrorSugerido);
                    SalidaProceso = true;
                }
                else
                {
                    Console.WriteLine("Ingresa un Error Sugerido mayor a 0.\nPresione una tecla para continuar.");
                    Console.ReadKey();
                }
                
            }
            while (SalidaProceso == false);
        }
    }
}
