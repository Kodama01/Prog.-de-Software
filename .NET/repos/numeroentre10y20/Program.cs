using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeroentre10y20
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            Console.WriteLine("Ingresa un numero");
            num = double.Parse(Console.ReadLine());
            if (num <= 20 && num >= 10)
            {
                Console.WriteLine("Esta en el rango 10 - 20");
            }
            else
            {
                Console.WriteLine("NO Esta en el rango 10 - 20");
            }
            Console.WriteLine("Fin D:");
        }
    }
}
