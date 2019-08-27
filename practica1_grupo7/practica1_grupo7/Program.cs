using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica1_grupo7
{
    class Program
    {
        static void Main(string[] args)
        {
            //numero_Primo();
            Discriminante();
        }

        static void numero_Primo()
        {
            Console.WriteLine("Ingrese el número");
            int Numero = int.Parse(Console.ReadLine());
            if((Numero % 2) == 0)
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("INPar");
            }
        }

        static void Discriminante()
        {
            double a, b, c, discriminante, x1, x2;
            Console.WriteLine("Ingrese El Coeficiente de A");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese El Coeficiente de B");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese El Coeficiente de C");
            c = double.Parse(Console.ReadLine());
            discriminante = ((b * b) - (4 * (a * c)));

            Console.WriteLine("El discriminante es: "+discriminante);

            if (discriminante < 0)
            {
                Console.WriteLine("La Ecuacion No Tiene Soluciones Reales");
            }

            if (discriminante == 0)
            {
                Console.WriteLine("La ecuacion tiene solo una raiz real");
                x1 = (-b) / (2 * a);
                Console.WriteLine("La Solucion es, X1 = X2 : " +x1);
            }

            if (discriminante > 0)
            {
                Console.WriteLine("La ecuacion tiene dos raizes reales");
                x1 = (-b) + Math.Sqrt(discriminante) / (2 * a);
                x2 = (-b) - Math.Sqrt(discriminante) / (2 * a);
                Console.WriteLine("La Solucion es, X1 = " + x1 + " y, X2 = " + x2);
            }

            Console.ReadLine();
        }
    




}



}
