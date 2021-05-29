using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forCases
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int num;
            Console.WriteLine("Numeros del 1 al 20");
            for(num = 1;num < 21; num++)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
            //---------------------------
            int num;
            Console.WriteLine("Numero de 1 al 20 de 2 en 2");
            for(num = 1; num <= 20; num += 2)
            {
                Console.WriteLine(num);
                //Para cumplir la inicializacion en 1. En esta condicion se le resta 1 solamente al inicio y num pasa a ser 0
                if(num == 1)
                {
                    num--;
                }
            }
            int num;
            Console.WriteLine("Numero de 1 al 100 de 5 en 5");
            for (num = 1; num <= 100; num += 5)
            {
                Console.WriteLine(num);
                if (num == 1)
                {
                    num--;
                }
            }
            int num;
            Console.WriteLine("Numeros del 20 al 1");
            for (num = 20; num > 0; num --)
            {
                Console.WriteLine(num);
            }
            int num;
            Console.WriteLine("Numeros del 20 al 1 de 2 en 20");
            for (num = 20; num >= 1; num -= 2)
            {
                Console.WriteLine(num);
                if(num == 2)
                {
                    num--;
                    Console.WriteLine(num);
                }
            }
            double num;
            Console.WriteLine("Numero de 1.0 al 16.2 de 0.2");
            for (num = 1.0; num <= 16.2; num += 0.2)
            {
                Console.WriteLine(num);
            }*/
            double num;
            Console.WriteLine("Numero de 20.0 a 10.0 de 0.1");
            for (num = 20.0; num <= 10.0; num -= .1)
            {
                Console.WriteLine(num);
            }
        }
    }
}
