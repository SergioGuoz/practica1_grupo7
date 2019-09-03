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
            System.Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine("++============================================++");
            Console.WriteLine("||       ANALISIS Y DISEÑO DE SISTEMAS 1      ||");
            Console.WriteLine("++============================================++");
            System.Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("||         LABORATORIO PRACTICA 1             ||");
            Console.WriteLine("||         CALIFICACION PRACTICA 1            ||");
            Console.WriteLine("++--------------------------------------------++");

            System.Console.ForegroundColor = ConsoleColor.White;

            int opcion;
            do
            {
                Console.WriteLine("*****************************************");
                Console.WriteLine("Ingrese la opcion a la que desea ir ....");
                Console.WriteLine("1) Numero Primo");
                Console.WriteLine("2) Discriminante");
                Console.WriteLine("3) Valor Absoluto");
                Console.WriteLine("4) Potencia al Cubo");
                Console.WriteLine("5) Raiz al Cubo");
                Console.WriteLine("6) Division");
                Console.WriteLine("7) Multiplicacion");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        numero_Primo();
                        break;
                    case 2:
                        Discriminante();
                        break;
                    case 3:
                        ValorAbsoluto();
                        break;
                    case 4:
                        Potencia_al_cubo();
                        break;
                    case 5:
                        RaizAlCubo();
                        break;
                    case 6:
                        Division();
                        break;
                    case 7:
                        Multiplicacion();
                        break;
                }
                Console.ReadKey();
            } while (opcion!=8);
            
        }

        static void numero_Primo()
        {
            bool seguir = true;

            while (seguir)
            {


                Console.WriteLine("--------------NUMERO PRIMO-------------");
                Console.WriteLine("Ingrese el número");
                int Numero = int.Parse(Console.ReadLine());
                int j = 0;
                for (int i = 1; i < (Numero + 1); i++)
                {
                    if (Numero % i == 0)
                    {
                        j++;
                    }
                }
            

                if (j != 2)
                {
                    Console.WriteLine("No Primo");
                }
                else
                {
                    Console.WriteLine("Primo");
                }
                Console.WriteLine("¿Desea Comprobar otro numero?s/n");

                string r = Console.ReadLine();
                if (r.Equals("s"))
                {

                }
                else
                {
                    seguir = false;
                }

            }
        }

        static void Discriminante()
        {
            Console.WriteLine("\n\t\t -- Funcion de division (dividendo/divisor) --\n");
            Console.WriteLine("el discriminante de un polinomio es una cierta expresión de los coeficientes de dicho polinomio ");
            Console.WriteLine("que es igual a cero si y solo si el polinomio tiene raíces múltiples en el plano complejo.\n");

            double a, b, c, discriminante, x1, x2;
            Console.Write("Ingrese El Coeficiente de A");
            a = double.Parse(Console.ReadLine());
            Console.Write("Ingrese El Coeficiente de B");
            b = double.Parse(Console.ReadLine());
            Console.Write("Ingrese El Coeficiente de C");
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
            string opcion;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("La siguinte funcion describe el como calcular un valor absoluto");
            Console.WriteLine("Un Valor absoluto es es tomar un numero sin importar su signo");
            Console.Write("\n");
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Porfavor Ingresar un numero");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("El valor absulito de ({0}) es {1} ", numero, Math.Abs(numero));
            Console.Write("\n");
            Console.Write("Desea repetir la funcion? Escriba y/n (y=yes n=no)");
            Console.Write("\n");
            opcion = Console.ReadLine();
            if (opcion == "y")
            {
                ValorAbsoluto();
            }
            else if (opcion == "n")
            {
                Console.WriteLine("Saliendo....");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            else
            {
                Console.WriteLine("Opcion no valida");
            }
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

            //COLOREAR EL TEXTO DE ROJO
            System.Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("RESULTADO:\nRaiz Cubica de {0} es {1}" ,radicando,resultado);
            //COLOREAR EL TEXTO DE BLANCO
            System.Console.ForegroundColor = ConsoleColor.White;
            //Esto es para poder ver el resultado y no se cierre la consola
            Console.ReadKey();
        }

        static void Division()
        {
            Console.WriteLine("\n\t\t -- Funcion de division (dividendo/divisor) --\n");
            Console.WriteLine("Descripcion:  la división es una operación parcialmente definida en el conjunto de los ");
            Console.WriteLine("números naturales y los números enteros; en cambio, en el caso de los números racionales, ");
            Console.WriteLine("reales y complejos es siempre posible efectuar la división, exigiendo que el divisor sea distinto de cero.\n");
            Console.Write("Ingrese el dividendo: ");

            double a = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el divisor: ");
            double b = double.Parse(Console.ReadLine());

            if (b == 0)
            {
                try
                {
                    Console.WriteLine("El resultado es: " + a / b);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Division de {0} por cero no se puede realizar.", a);
                }
            }
            else
            {
                Console.WriteLine("El resultado es: " + a / b);
            }
            


            Console.ReadLine();
        }

        static void Multiplicacion()
        {
            Console.WriteLine("\n\t\t -- Funcion de multiplicacion --\n");
            Console.WriteLine(" Descripcion: La multiplicación es una operación binaria que se establece en un conjunto numérico.2​ ");
            Console.WriteLine(" Tal el caso de números naturales, consiste en sumar un número tantas veces como indica otro número.\n");

            double a, b;
            string s;
            while (true)
            {
                Console.Write(" Ingrese el primer valor: ");
                a = double.Parse(Console.ReadLine());
                Console.Write(" Ingrese el segundo valor: ");
                b = double.Parse(Console.ReadLine());

                Console.WriteLine(" El resultado es: " + a * b);

                Console.Write("\n Desea realizar otra multiplicacion (Si presione Y, No presione otra tecla): ");
                s = Console.ReadLine();
                if (!s.Equals("Y",StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
            }

            Console.WriteLine(" -- Fin de la funcion --");
            Console.ReadLine();
        }

    }
    
}
