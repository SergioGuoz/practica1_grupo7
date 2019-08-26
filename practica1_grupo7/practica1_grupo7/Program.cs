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
            numero_Primo();
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

    }
}
