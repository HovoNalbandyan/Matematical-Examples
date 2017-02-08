using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace y_ax_b
{
    class Program
    {
        
        static void Main(string[] args)
        {         
            
            Console.Write("A=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("B=");
            double b = double.Parse(Console.ReadLine());
            double dx = 0.5;
            double x=-5;         
            while
                (x<=5)
            {
                Console.Write("X=");
                Console.Write(x);
                Console.Write("Y=");
                Console.WriteLine( (a*x * x) + b);
               
                x += dx;
               
            }


        }
    }
}
