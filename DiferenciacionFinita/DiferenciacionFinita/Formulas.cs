using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiferenciacionFinita
{
    class Formulas
    {
        double xi, h, a1, a2, a3, a4, c;
        string error, derivada;
        public Formulas(double xi, double h, double a1, double a2, double a3, double a4, double c, string error, string derivada)
        {
            this.xi = xi;
            this.h = h;
            this.a1 = a1;
            this.a2 = a2;
            this.a3 = a3;
            this.a4 = a4;
            this.c = c;
            this.error = error;
            this.derivada = derivada;
        }

        public double EfeDeEquis(double x)
        {
            return
                ((a4 * (Math.Pow(x, 4))) + (a3 * (Math.Pow(x, 3))) + (a2 * (Math.Pow(x, 2))) + (a1 * (Math.Pow(x, 1))) + c);
        }

        public double FormulasCentradas()
        {
            if (derivada == "1er Derivada")
            {
                if (error == "O(h^2)")
                {
                    return
                        ((EfeDeEquis(xi + h) - EfeDeEquis(xi - h)) / (2 * h));
                }
                else if (error == "O(h^4)")
                {
                    return
                        ((-(EfeDeEquis(xi + (h * 2))) + (8 * EfeDeEquis(xi + h)) - (8 * EfeDeEquis(xi - h)) + EfeDeEquis(xi - (h * 2))) / (2 * h));
                }
                else
                {
                    return 0;
                }
            }
            else if (derivada == "2da Derivada")
            {
                if (error == "O(h^2)")
                {
                    return
                        ((EfeDeEquis(xi + h) - (2 * EfeDeEquis(xi)) + EfeDeEquis(xi - 1)) / Math.Pow(h, 2));
                }
                else if (error == "O(h^4)")
                {
                    return
                        ((-(EfeDeEquis(xi + (h * 2))) + (16 * EfeDeEquis(xi + h)) - (30 * EfeDeEquis(xi)) + (16 * EfeDeEquis(xi - h)) - EfeDeEquis(xi - (h * 2))) / (12 * Math.Pow(h, 2)));
                }
                else
                {
                    return 0;
                }
            }
            else if (derivada == "3er Derivada")
            {
                if (error == "O(h^2)")
                {
                    return
                        ((EfeDeEquis(xi + (h * 2)) - (2 * EfeDeEquis(xi + h)) + (2 * EfeDeEquis(xi - h)) - EfeDeEquis(xi - (h * 2))) / (2 * Math.Pow(h, 3)));
                }
                else if (error == "O(h^4)")
                {
                    return
                        ((-(EfeDeEquis(xi + (h * 3))) + (8 * EfeDeEquis(xi + (h * 2))) - (13 * EfeDeEquis(xi + h)) + (13 * EfeDeEquis(xi - h)) - (8 * EfeDeEquis(xi - (h * 2))) + EfeDeEquis(xi - (h * 3))) / (8 * (Math.Pow(h, 3))));
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                if (error == "O(h^2)")
                {
                    return
                        ((EfeDeEquis(xi + (h * 2)) - (4 * EfeDeEquis(xi + h)) + (6 * EfeDeEquis(xi)) - (4 * EfeDeEquis(xi - h)) + EfeDeEquis(xi - (h * 2))) / Math.Pow(h, 4));
                }
                else if (error == "O(h^4)")
                {
                    return
                        ((-(EfeDeEquis(xi + (h * 3))) + (12 * EfeDeEquis(xi + (h * 2))) + (39 * EfeDeEquis(xi + h)) + (56 * EfeDeEquis(xi)) - (39 * EfeDeEquis(xi - h)) + (12 * EfeDeEquis(xi - (h * 2))) + EfeDeEquis(xi - (h * 3))) / (6 * Math.Pow(h, 4)));
                }
                else
                {
                    return 0;
                }
            }
        }

        public double FormulasAtras()
        {
            if(derivada == "1er Derivada")
            {
                if(error == "O(h)")
                {
                    return
                        ((EfeDeEquis(xi) - EfeDeEquis(xi - h)) / h);
                }
                else if(error == "O(h^2)")
                {
                    return
                        (((3 * EfeDeEquis(xi)) - (4 * EfeDeEquis(xi - h)) + EfeDeEquis(xi - (2 * h))) / (2 * h));
                }
                else
                {
                    return 0;
                }
            }
            else if(derivada == "2da Derivada")
            {
                if (error == "O(h)")
                {
                    return
                        ((EfeDeEquis(xi) -(2 * EfeDeEquis(xi - h)) + EfeDeEquis(xi - (h * 2))) / Math.Pow(h, 2));
                }
                else if (error == "O(h^2)")
                {
                    return
                        (((2 * EfeDeEquis(xi)) - (5 * EfeDeEquis(xi - h)) + (4 * EfeDeEquis(xi - (h * 2))) - EfeDeEquis(xi - (h * 3))) / Math.Pow(h, 2));
                }
                else
                {
                    return 0;
                }
            }
            else if(derivada == "3er Derivada")
            {
                if (error == "O(h)")
                {
                    return
                        ((EfeDeEquis(xi) - (3 * EfeDeEquis(xi - h)) + (3 * EfeDeEquis(xi - (h * 2))) - EfeDeEquis(xi - (h * 3))) / Math.Pow(h, 3));
                }
                else if (error == "O(h^2)")
                {
                    return
                        (((5 * EfeDeEquis(xi)) -(18 * EfeDeEquis(xi - h)) + (24 * EfeDeEquis(xi - (h * 2))) - (14 * EfeDeEquis(xi - (h * 3))) + (3 * EfeDeEquis(xi - (h * 4)))) / (2 * (Math.Pow(h, 3))));
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                if (error == "O(h)")
                {
                    return
                        ((EfeDeEquis(xi) - (4 * EfeDeEquis(xi - h)) + (6 * EfeDeEquis(xi - (h * 2))) - (4 * EfeDeEquis(xi - (h * 3))) + EfeDeEquis(xi - (h * 4))) / Math.Pow(h, 4));
                }
                else if (error == "O(h^2)")
                {
                    return
                        (((3 * EfeDeEquis(xi)) - (14 * EfeDeEquis(xi - h)) + (26 * EfeDeEquis(xi - (h * 2))) - (24 * xi - (h * 3)) + (11 * EfeDeEquis(xi - (h * 4))) - (2 * EfeDeEquis(xi - (h * 5)))) / Math.Pow(h, 4));
                }
                else
                {
                    return 0;
                }
            }
        }
























        public double FormulasDelante()
        {
            if (derivada == "1er Derivada")
            {
                if (error == "O(h)")
                {
                    return
                        ((EfeDeEquis(xi + h) - EfeDeEquis(xi)) / h);
                }
                else if (error == "O(h^2)")
                {
                    return
                        ((-(EfeDeEquis(xi + (h * 2))) + (4 * EfeDeEquis(xi + h)) - (3 * EfeDeEquis(xi))) / (2 * h));
                }
                else
                {
                    return 0;
                }
            }
            else if (derivada == "2da Derivada")
            {
                if (error == "O(h)")
                {
                    return
                        ((EfeDeEquis(xi + (h * 2)) - (2 * EfeDeEquis(xi + h)) + EfeDeEquis(xi)) / Math.Pow(h, 2));
                }
                else if (error == "O(h^2)")
                {
                    return
                        (((2 * EfeDeEquis(xi)) - (5 * EfeDeEquis(xi - h)) + (4 * EfeDeEquis(xi - (h * 2))) - EfeDeEquis(xi - (h * 3))) / Math.Pow(h, 2));
                }
                else
                {
                    return 0;
                }
            }
            else if (derivada == "3er Derivada")
            {
                if (error == "O(h)")
                {
                    return
                        ((EfeDeEquis(xi + (h * 3)) - (3 * EfeDeEquis(xi + (h * 2))) + (3 * EfeDeEquis(xi + h)) - EfeDeEquis(xi)) / Math.Pow(h, 3));
                }
                else if (error == "O(h^2)")
                {
                    return
                        ((-(3 * EfeDeEquis(xi + (h * 4))) + (14 * EfeDeEquis(xi + (h * 3))) - (24 * EfeDeEquis(xi + (h * 2))) + (18 * EfeDeEquis(xi + h)) - (5 * EfeDeEquis(xi))) / (2 * (Math.Pow(h, 3))));
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                if (error == "O(h)")
                {
                    return
                        ((EfeDeEquis(xi + (h * 4)) - (4 * EfeDeEquis(xi + (h * 3))) + (6 * EfeDeEquis(xi + (h * 2))) - (4 * EfeDeEquis(xi + h)) + EfeDeEquis(xi)) / Math.Pow(h, 4));
                }
                else if (error == "O(h^2)")
                {
                    return
                        ((-(2 * EfeDeEquis(xi + (h * 5))) + (11 * EfeDeEquis(xi + (h * 4))) - (24 * EfeDeEquis(xi + (h * 3))) + (26 * EfeDeEquis(xi + (h * 2))) - (14 * EfeDeEquis(xi + h)) + (3 * EfeDeEquis(xi))) / Math.Pow(h, 4));
                }
                else
                {
                    return 0;
                }
            }
        }

















    }
}
