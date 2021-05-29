using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volumen_de_cubo
{
    class Program
    {
        static void Main(string[] args)
        {
            double l1, l2, l3, volCub;
            Console.WriteLine("Ingresa el valor del primer lado del cubo");
            l1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el valor del segundo lado del cubo");
            l2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el valor del tercer lado del cubo");
            l3 = Int32.Parse(Console.ReadLine());
            volCub = l1 * l2 * l3;
            Console.WriteLine("El valor del volumen del cubo es: " + volCub);

        }
    }
}
