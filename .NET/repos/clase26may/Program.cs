using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase26may
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;             x = 0;
            while(x != 99 && x != 4)
            {
                Console.WriteLine("Que deseas hacer? Ingresa numero:\n1)Sumar \n2)Multiplicar \n3)Restar \n4)Salir\n");
                double var1, var2, res;
                switch (x = Int32.Parse(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine("Ejecutando SUMA");
                        Console.WriteLine("Ingresa primer valor");
                        var1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa segundo valor");
                        var2 = double.Parse(Console.ReadLine());
                        res = var1 + var2;
                        Console.WriteLine("La suma de {0} + {1} es: {2}\n", var1, var2, res);
                        break;
                    case 2:
                        Console.WriteLine("Ejecutando MULTIPLICACION");
                        Console.WriteLine("Ingresa primer valor");
                        var1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa segundo valor");
                        var2 = double.Parse(Console.ReadLine());
                        res = var1 * var2;
                        Console.WriteLine("La multiplicacion de {0} * {1} es: {2}\n", var1, var2, res);
                        break;
                    case 3:
                        Console.WriteLine("Ejecutando RESTA");
                        Console.WriteLine("Ingresar primer valor");
                        var1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresar segundo valor");
                        var2 = double.Parse(Console.ReadLine());
                        res = var1 - var2;
                        Console.WriteLine("La resta de {0} - {1} es: {2}\n", var1, var2, res);
                        break;
                    case 4:
                        Console.WriteLine("FIN DEL PROGRAMA\n");
                        break;
                    default:
                        Console.WriteLine("Caso INVALIDO, prueba de nuevo.\n");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
