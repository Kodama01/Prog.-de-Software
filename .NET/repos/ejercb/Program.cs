using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercb
{
    class Program
    {
        static void Main(string[] args)
        {
            double temp;
            Console.WriteLine("Ingresa el valor de la temperatura");
            temp = double.Parse(Console.ReadLine());
            if(temp >= 100)
            {
                Console.WriteLine("Sobre el punto de ebullicion del agua");
            }
            else
            {
                Console.WriteLine("Abajo del punto de ebullicion del agua");
            }
        }
    }
}
