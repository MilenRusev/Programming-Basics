using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOnFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            if (((0 < x) && (x < 3 * h) && (0 < y) && (y < h) || ((h < x) && (x < 2 * h) && (4 * h > y) && (y > h))))
            {
                Console.WriteLine("inside");
            }
            else 
            {
                Console.WriteLine("outside");
            }

        }
    }
}
