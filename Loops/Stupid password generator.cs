using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stupidPassGen
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            var magicalNumber = 0;

            for (int i = 1; i <= 9; i++)
            {
                for (int g = 1; g <= 9; g++)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        for (int j = 1; j <= 9; j++)
                        {
                            for (int l = 1; l <= 9; l++)
                            {
                                for (int f = 1; f <= 9; f++)
                                {
                                    sum = i * g * k * j * l * f;

                                    if (sum == n)
                                    {
                                        Console.Write($" {i}{g}{k}{j}{l}{f}");
                                    }
                                }                        
                            }
                        }
                    }
                }
            }
        }
    }
}
