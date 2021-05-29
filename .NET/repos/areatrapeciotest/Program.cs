using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areatrapeciotest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables Auxiliares
            double area = 0, b1 = 0, b2 = 0, h = 0;

            //Explicacion del ejercicio
            Console.WriteLine("Encontrar el Area de un Trapecio.");

            //Pediendo datos
            Console.Write("Ingrese la base mayor del trapecio: ");

            //Convierte de texto a tipo entero
            b1 = Int32.Parse(Console.ReadLine());

            //Pediendo datos
            Console.Write("Ingrese la base menor del trapecio: ");

            //Convierte de texto a tipo entero
            b2 = Int32.Parse(Console.ReadLine());

            //Pediendo datos
            Console.Write("Ingrese la altura del trapecio: ");

            //Convierte de texto a tipo entero
            h = Int32.Parse(Console.ReadLine());

            //Realiza la operacion
            area = (b1 + b2) * h / 2;

            //Imprimiendo el resultado
            Console.WriteLine("El Area del trapecio es: " + area);

            //El programa espera a que se reciba una tecla
            //La funcion de esto es que no se cierre el programa
            Console.ReadKey();
        }
    }
}
