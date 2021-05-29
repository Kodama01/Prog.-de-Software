using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase12may_framework
{
    class Program
    {
        static void Main(string[] args)
        {

            int b, h, area;
            Console.WriteLine("Este programa calcula el area de un rectangulo");
            Console.WriteLine("Ingresa el valor de la base");
            b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el valor de la altura");
            h = Int32.Parse(Console.ReadLine());
            area = b * h;
            Console.WriteLine("El valor del area es: {0}", area);

        }
    }
}
