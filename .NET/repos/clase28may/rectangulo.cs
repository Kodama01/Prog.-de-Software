using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase28may
{
    class rectangulo
    {
        private double baseRec;
        private double altRec;

        public rectangulo(double x, double y)
        {
            baseRec = x;
            altRec = y;
        }
        public double calcArea()
        {
            double area = baseRec * altRec;
            return area;
        }
    }
}
