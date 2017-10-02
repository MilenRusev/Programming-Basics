using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaOtDveChisla
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            var magicNumber = int.Parse(Console.ReadLine());

            var counter = 0;
            var sum = 0;
            var combinationExist = false;
            for (int i = start; i <= end; i++)
            {
                for (int g = start; g <= end; g++)
                {
                    counter++;
                    sum = i + g;
                    if (sum == magicNumber)
                    {
                        combinationExist = true;
                        Console.WriteLine($"Combination N:{counter} ({i} + {g} = {sum})");
                        break;
                    }
                    
                }
                if (sum == magicNumber)
                {
                    break;
                }
            }
            if (combinationExist == false)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
            }
        }
    }
}
