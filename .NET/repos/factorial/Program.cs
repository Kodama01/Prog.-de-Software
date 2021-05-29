using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, rest, fact;
            Console.WriteLine("Este programa calcula el factor de un digito ingresado por teclado.");
            Console.WriteLine("A continuacion ingresa el valor: ");
            num = Int32.Parse(Console.ReadLine());
            if (num == 0)
            {
                Console.WriteLine("El factorial de {0} es 1.",num);
            }
            else
            {
                fact = num;
                for (rest = num; rest > 1; rest--)
                {
                    fact = fact * (rest - 1);
                }
                Console.WriteLine("El factorial de {0} es {1}.", num, fact);
            }
            Console.ReadKey();
        }
    }
}
