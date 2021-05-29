using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercf
{
    class Program
    {
        static void Main(string[] args)
        {
            string gen;
            Console.WriteLine("Elige el sexo del usuario F o M");
            gen = Console.ReadLine();
            if (gen == "F" || gen == "f")
            {
                Console.WriteLine("El sexo es Femenino");
            }
            else if (gen == "M" || gen == "m")
            {
                Console.WriteLine("El sexo es Masculino");
            }
            else
            {
                Console.WriteLine("No aplica.");
            }
        }
    }
}
