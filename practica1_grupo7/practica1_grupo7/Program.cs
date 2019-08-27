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
            //Discriminante();
            //ValorAbsoluto();
            //Potencia_al_cubo();
            RaizAlCubo();
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
        static void ValorAbsoluto()
        {
            int numero;

            Console.WriteLine("Porfavor Ingresar un numero");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("El valor absulito de ({0}) es {1} ", numero, Math.Abs(numero));

            //Esto es para poder ver el resultado y no se cierre la consola
            Console.ReadKey();
        }

        static void Potencia_al_cubo()
        {
            double numero;

            Console.WriteLine("Porfavor Ingresar un numero");
            numero = double.Parse(Console.ReadLine());
            Console.WriteLine("El cubo de ({0}) es {1} ", numero, Math.Pow(numero,3));

            //Esto es para poder ver el resultado y no se cierre la consola
            Console.ReadKey();
        }

        static void RaizAlCubo() {

            Console.WriteLine("****** RAIZ CUBICA *******");
            Console.WriteLine("Ingrese un número");

            double radicando = double.Parse(Console.ReadLine());
            double potencia = 1.0 / 3.0;
            double resultado = Math.Pow(radicando, potencia);

            Console.WriteLine("RESULTADO: Raiz Cubica de {0} es {1}" ,radicando,resultado);

            //Esto es para poder ver el resultado y no se cierre la consola
            Console.ReadKey();
        }
    }
    
}
