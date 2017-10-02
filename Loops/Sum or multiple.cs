using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOrMultiple
{
    class Program
    {
        static void Main(string[] args)
        {
            var controlNum = int.Parse(Console.ReadLine());

            var sum = 0;
            var multi = 0;
            var flag = false;

            for (int i = 1; i <= 30; i++)
            {
                for (int g = 1; g <= 30; g++)
                {
                    for (int k = 1; k <= 30; k++)
                    {
                        sum = i + g + k;
                        multi = i * g * k;
                        if(sum == controlNum && i < g && g < k)
                        {
                            Console.WriteLine($"{i} + {g} + {k} = {sum}");
                            flag = true;
                        }
                        if (multi == controlNum && i > g && g > k)
                        {
                            Console.WriteLine($"{i} * {g} * {k} = {multi}");
                            flag = true;
                        }
                    }
                }
            }
            if(flag == false)
            {
                Console.WriteLine("No!");
            }
        }
    }
}
