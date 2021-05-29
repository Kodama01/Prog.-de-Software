using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase21may
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int load;
            Console.WriteLine("Ingresar numero 99.");
            load = Int32.Parse(Console.ReadLine());
            while (load != 99)
            {
                Console.WriteLine("Ingresar numero 99.");
                load = Int32.Parse(Console.ReadLine());
            }
            /----------/
            int lim, ini = 0;
            Console.WriteLine("Ingresa valor: ");
            lim = Int32.Parse(Console.ReadLine());
            while (ini <= lim)
            {
                Console.WriteLine(ini);
                ini++;
            }*/
            int nnum, last, sum = 0;
            Console.WriteLine("Ingresa nuevo numero nnum");
            nnum = Int32.Parse(Console.ReadLine());
            while(nnum != 0)
            {

                last = nnum;
                Console.WriteLine("Escribir nuevo valor");
                sum = last + sum;
                nnum = Int32.Parse(Console.ReadLine());
                if(nnum == 0)
                {
                    Console.WriteLine(sum);
                }
            }
        }
    }
}