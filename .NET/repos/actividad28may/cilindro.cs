using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividad28may
{
    class cilindro
    {
        private double radius;
        private double height;

        public cilindro(double x, double y)
        {
            radius = x;
            height = y;
        }
        public double calcVol()
        {
            double Vol = Math.PI * (radius * radius) * height;
            return Vol;
        }
        public double calcArea()
        {
            double Area = 2 * Math.PI * radius * (radius + height);
            return Area;
        }
    }
}
