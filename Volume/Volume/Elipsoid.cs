using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volume
{
    public class Elipsoid
    {
        public int a;
        public int b;
        public int c;
        public Elipsoid() //Default Ctor
        {
            a = 1;
            b = 1;
            c = 1;
        }
        public Elipsoid(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double V()
        {//Elipsoid Volume

            return (4d/3)*Math.PI*a*b*c;
        }

        public double Area()
        {
            float p = 1.6075f;
            //Elipsoid Area 
            return 4f * (float)Math.PI * (float)Math.Pow(Math.Pow(a * b, p) + Math.Pow(a * b, p) + Math.Pow(b * b, p), 1f / p);
           
        }
    }
}
