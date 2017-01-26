using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volume
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallelepiped Parallelepiped1= new Parallelepiped();
            Console.WriteLine("Parallelepiped Volume = " + Parallelepiped1.V());
            Console.WriteLine("Parallelepiped  Area = " + Parallelepiped1.Area());


            Elipsoid Elipsoid1 = new Elipsoid();
            Console.WriteLine("Elipsoid Volume = " + Elipsoid1.V());
            Console.WriteLine("Elipsoid Area = " + Elipsoid1.Area());
        }
    }
}
