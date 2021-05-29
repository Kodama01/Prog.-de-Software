using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculoSueldo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar las variables que se van a utilizar
            int horasTrab;
            float costoHora;
            float sueldo;
            string linea;
            //inicia el programa y muestra el mensaje para ingresar un valor
            Console.Write("Ingrese Horas trabajadas por el operario:");
            //linea lee y guarda el valor que se ingrese en la variable horasTrab 
            linea = Console.ReadLine();
            horasTrab = int.Parse(linea);
            //ahora muestra otro mensaje para ingresar nuevamente un valor
            Console.Write("Ingrese pago x hora:");
            //linea lee y guarda el valor ingresado en costoHora
            linea = Console.ReadLine();
            costoHora = float.Parse(linea);
            //se inicia la variable sueldo calculando las horas trabajadas por el costo de la hora
            sueldo = horasTrab * costoHora;
            //se escribe un mensaje antes de escribir el valor del sueldo
            Console.Write("El sueldo total es: ");
            //se escribe en pantalla el valor gaurdado en la variable sueldo
            Console.Write(sueldo);
            //readkey espera que ingrese cualquier tecla "()" antes de que ciere el programa
            Console.ReadKey();

        }
    }
}
