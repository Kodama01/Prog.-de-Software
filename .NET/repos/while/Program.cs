using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            while (num <= 100)
            {
                Console.WriteLine(num);
                num = num + 5;
            }
        }
    }
}
