using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebas26may
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad = 0, n = 0;
            double sumatoria = 0.0, valor = 0.0, promedio = 0.0;
            string dato = "";
            //Pedir cantidad de datos que se va a promediar
            Console.WriteLine("Ingresa con un valor enteo la cantidad de numeros que se debe promediar");
            dato = Console.ReadLine();
            cantidad = Int32.Parse(dato);
            for (n = 0; n < cantidad; n++)
            {
                Console.WriteLine("Ingresa valor");
                dato = Console.ReadLine();
                valor = Int32.Parse(dato);

                sumatoria += valor;
            }
            promedio = sumatoria / cantidad;
            Console.WriteLine("El promedio es {0}",promedio);
        }
    }
}
