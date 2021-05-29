using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerca
{
    class Program
    {
        static void Main(string[] args)
        {
            double deg;
            Console.WriteLine("Ingresa el valor del angulo");
            deg = double.Parse(Console.ReadLine());
            if ( deg == 90)
            {
                Console.WriteLine("Es un angulo recto!");
            }
            else
            {
                Console.WriteLine("No es un angulo recto! :(");
            }
        }
    }
}
