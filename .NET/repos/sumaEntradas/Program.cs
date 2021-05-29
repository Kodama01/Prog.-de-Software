using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumaEntradas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int nnum, last, sum = 0;
            Console.WriteLine("Ingresa un valor entero");
            nnum = Int32.Parse(Console.ReadLine());
            while (nnum != 0)
            {

                last = nnum;
                Console.WriteLine("Escribir nuevo valor");
                sum = last + sum;
                nnum = Int32.Parse(Console.ReadLine());
                if (nnum == 0)
                {
                    Console.WriteLine(sum);
                }
            }*/
            int num;
            Console.WriteLine("Ingresa cualquier valor entero");
            num = Int32.Parse(Console.ReadLine());
            while (num != 0)
            {
                Console.WriteLine("Ingresar nuevo valor");
                int negnum = 0;
                num = negnum;
                if (negnum < 0)
                {
                    negnum = negnum += 1;
                }
                else if(num == 0)
                {
                    Console.WriteLine(negnum);
                }
            }
        }
    }
}
