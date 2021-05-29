using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_de_circulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.1415, radius = 0, area = 0;
            Console.WriteLine("Ingresa el valor del radio");
            radius = double.Parse(Console.ReadLine());
            area = pi * (radius * radius);
            Console.WriteLine("El area del circulo es: " + area);
        }
    }
}
