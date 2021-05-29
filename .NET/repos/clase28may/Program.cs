using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase28may
{
    class Program
    {
        static void Main(string[] args)
        {


            rectangulo fig = new rectangulo(2.3, 5.7);
            double areafig = fig.calcArea();
            Console.WriteLine(areafig);





            /*
            Estudiante objt = new Estudiante("Pedro","Casa",15,10);
            */
            /*
            objt.Nombre = "El pepe";
            objt.Direccion = "La casa pai";
            objt.Edad = 15;
            objt.Nivel = 3;
            */

            /*
            Estudiante objt2 = new Estudiante();
            objt2.Nombre = "El pana";
            objt2.Direccion = "La casa pai";
            objt2.Edad = 16;
            objt2.Nivel = 4;*/
        }
    }
}
