using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var currentSum = 0.0;
                {
                    var num1 = double.Parse(Console.ReadLine());
                    var num2 = double.Parse(Console.ReadLine());
                    currentSum = num1 + num2;
                }
                Console.WriteLine(currentSum);
            }
        }
    }
}
