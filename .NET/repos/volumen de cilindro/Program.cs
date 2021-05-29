using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volumen_de_cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.1415, radius, areaBas, h, areaCil;
            Console.WriteLine("El siguiente programa calcula el volumen de un cilindro:");
            Console.WriteLine("Ingresa el valor del radio de la base del cilindro ");
            radius = double.Parse(Console.ReadLine());
            areaBas = pi * (radius * radius);
            Console.WriteLine("Ingresa la altura del cilindro");
            h = double.Parse(Console.ReadLine());
            areaCil = areaBas * h;
            Console.WriteLine("El columen del cilindro es: " + areaCil);
        }
    }
}
