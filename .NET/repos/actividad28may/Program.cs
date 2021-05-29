using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividad28may
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, h;
            Console.WriteLine("Escribe el radio del cilindro");
            r = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Escribe la altura del cilindro");
            h = Int32.Parse(Console.ReadLine());
            cilindro fig = new cilindro(r, h);
            double areafig = fig.calcArea();
            double volfig = fig.calcVol();
            Console.WriteLine("\nVolumen: {0}\nArea: {1}", volfig, areafig);

        }
    }
}
