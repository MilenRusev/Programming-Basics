using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
             
            for (int f = 1; f <= 9; f++)
            {
                for (int g = 1; g <= 9; g++)
                {
                    for (int h = 1; h <= 9; h++)
                    {
                        for (int j = 1; j <= 9; j++)
                        {
                            if(n % f == 0 && n % g == 0 && n % h == 0 && n % j == 0)
                            {
                                Console.Write($" {f}{g}{h}{j}");
                            }
                             
                        }
                    }
                }
            }
        }
    }
}
