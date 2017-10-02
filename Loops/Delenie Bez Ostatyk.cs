using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelenieBezOstatyk
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var counter = 0;
            var p2 = 0.0;
            var p3 = 0.0;
            var p4 = 0.0;

            for (int i = 0; i < n; i++)
            {
                var currentNum = int.Parse(Console.ReadLine());
                if(currentNum % 2 == 0)
                {                     
                    p2++;             
                }
                if (currentNum % 3 == 0)
                {
                    p3++;
                }
                if (currentNum % 4 == 0)
                {
                    p4++;
                }           
            }
            Console.WriteLine($"{p2 / n * 100:f2}%");
            Console.WriteLine($"{p3 / n * 100:f2}%");
            Console.WriteLine($"{p4 / n * 100:f2}%");
        }
    }
}
