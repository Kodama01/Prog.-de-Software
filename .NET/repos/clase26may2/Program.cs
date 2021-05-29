using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase26may2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "rojo", "amarillo", "azul" };
            int[] array2 = { 1, 2, 3, 4 };
            array[2] = "moradi";
            Console.WriteLine(array[2]);
            Console.WriteLine("Tamaño del arreglo {0}",array2.Length);
            Console.WriteLine(array2[2]);
        }
    }
}
