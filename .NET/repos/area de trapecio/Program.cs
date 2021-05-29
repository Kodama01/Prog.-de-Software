using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_de_trapecio
{
    class Program
    {
        static void Main(string[] args)
        {
            double b1, b2, h, area;
            Console.WriteLine("Este programa calcula el area de un trapecio");
            Console.WriteLine("Ingresa el valor de la base 1");
            b1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el valor de la base 2");
            b2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el valor de la altura");
            h = double.Parse(Console.ReadLine());
            /*La prioridad de ejecucion de las operaciones aritmeticas es:
             Exponente -> Producto -> Division -> Suma -> Resta -> Modulo*/
            area = h * ((b1 + b2) / 2);
            Console.WriteLine("El valor del area es: " + area);

        }
    }
}
