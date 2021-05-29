using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lists26may
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfStrings = new List<string>()
            {
                "hyundai",
                "honda",
                "mazda",
                "toyota",
                "hummer",
            };
            int select = 0;
            while(select != 4)
            {

            
                Console.WriteLine("Que deseas hacer ? Ingresa numero:\n1)Ingresar dato \n2)Mostrar los datos \n3)Eliminar dato \n4)Salir\n");
                switch(select = Int32.Parse(Console.ReadLine()))
                {
                    case 1:
                        string ndat;
                        Console.WriteLine("Ingresa el dato por favor.\n");
                        ndat = Console.ReadLine();
                        listOfStrings.Add(ndat);
                        break;
                    case 2:
                        foreach (string str in listOfStrings)
                            Console.WriteLine(str);
                            Console.WriteLine("\n");
                        break;
                    case 3:
                        int pdat;
                        Console.WriteLine("Ingresa la posicion del dato enumerando desde 0\n");
                        pdat = Int32.Parse(Console.ReadLine());
                        listOfStrings.RemoveAt(pdat);
                        //Console.ReadLine(listOfStrings.RemoveAt())
                        break;
                    case 4:
                        Console.WriteLine("Fin del Programa\n");
                        break;
                    default:
                        Console.WriteLine("Valor Invalido\n");
                        break;
                }
            }
        }
    }
}
