using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КонтролноЧисло
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var controllNumber = int.Parse(Console.ReadLine());
            var sum = 0;
            var counter = 0;

            for (int firstNumber = 1; firstNumber <= n; firstNumber++)
            {
                for (int secondNumber = m; secondNumber >= 1; secondNumber--)
                {
                    sum += firstNumber * 2 + secondNumber * 3;
                    counter++;
                    if (sum >= controllNumber)
                    {
                        break;
                    }
                    
                }
                if (sum >= controllNumber)
                {
                    break;
                }
            }
            Console.WriteLine($"{counter} moves");
            if(sum >= controllNumber)
            {
                Console.WriteLine($"Score: {sum} >= {controllNumber}");
            }
        }
    }
}
