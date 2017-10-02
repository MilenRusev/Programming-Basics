using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgraNaIntervali
{
    class Program
    {
        static void Main(string[] args)
        {
            var broiHodove = int.Parse(Console.ReadLine());
            var score = 0.0;

            var firstInterval = 0.0;
            var secondInterval = 0.0;
            var thirdInterval = 0.0;
            var fourthInterval = 0.0;
            var fifthInterval = 0.0;
            var sixthInterval = 0.0;

            for (int i = 0; i < broiHodove; i++)
            {
                var currentNum = int.Parse(Console.ReadLine());
                if (currentNum >= 0 && currentNum <= 9)
                {
                    score += currentNum * 20 / 100.00;
                    firstInterval++;
                }
                else if (currentNum > 9 && currentNum <= 19)
                {
                    score += currentNum * 30 / 100.00;
                    secondInterval++;
                }
                else if (currentNum > 19 && currentNum <= 29)
                {
                    score += currentNum * 40 / 100.00;
                    thirdInterval++;                
                }
                else if (currentNum > 29 && currentNum <= 39)
                {
                    score += 50;
                    fourthInterval++;
                }
                else if (currentNum > 39 && currentNum <= 50)
                {
                    score += 100;
                    fifthInterval++;
                }
                else if (currentNum < 0 || currentNum > 50)
                {
                    score /= 2.0;
                    sixthInterval++;
                }
                


            }
            Console.WriteLine($"{score:f2}");
            Console.WriteLine($"From 0 to 9: {firstInterval / broiHodove * 100:f2}%");
            Console.WriteLine($"From 10 to 19: {secondInterval / broiHodove * 100:f2}%");
            Console.WriteLine($"From 20 to 29: {thirdInterval / broiHodove * 100:f2}%");
            Console.WriteLine($"From 30 to 39: {fourthInterval / broiHodove * 100:f2}%");
            Console.WriteLine($"From 40 to 50: {fifthInterval / broiHodove * 100:f2}%");
            Console.WriteLine($"Invalid numbers: {sixthInterval / broiHodove * 100:f2}%");
        }
    }
}
