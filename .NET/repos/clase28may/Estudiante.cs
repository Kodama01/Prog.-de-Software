using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase28may
{
    class Estudiante
    {
        private string Nombre;
        private string Direccion;
        private int Edad;
        private int Nivel;

        public Estudiante(string x, string y, int z, int n)
        {
            Nombre = x;
            Direccion = y;
            Edad = z;
            Nivel = n;
        }
    }
}
