using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _17_MultiplosDe3De1AUnNumeroDesconocido
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, a;
            a = 0;

            Console.WriteLine("Ingrese un numero: ");

            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {

                if (i % 3 == 0)
                {
                    a = a + 1;
                }
            }
            Console.WriteLine("La cantidad de multiplos de 3 es de: " + a);
            Console.ReadKey();
        }
    }
}
