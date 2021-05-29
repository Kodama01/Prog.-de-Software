using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Numero de 1 al 20 de 2 en 2");
            for (num = 1; num <= 20; num += 2)
            {
                Console.WriteLine(num);
                //Para cumplir la inicializacion en 1. En esta condicion se le resta 1 solamente al inicio y num pasa a ser 0
                if (num == 1)
                {
                    num--;
                }
            }
        }
    }
}
