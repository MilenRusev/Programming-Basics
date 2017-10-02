﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyGift
{
    class Program
    {
        static void Main(string[] args)
        {
            var projectParts = int.Parse(Console.ReadLine());
            var moneyPerPoint = double.Parse(Console.ReadLine());
            var sumOfEvenPoints = 0.0;
            var sumOfOddPoints = 0.0;
            

            for (int i = 1; i <= projectParts; i++)
            {
                var pointsPerPart = int.Parse(Console.ReadLine());

                if(i % 2 == 0)
                {
                    sumOfEvenPoints += pointsPerPart * 2;
                }
                else
                {
                    sumOfOddPoints += pointsPerPart;
                }
                //var totalSum = sumOfEvenPoints + sumOfOddPoints;
                //Console.WriteLine(totalSum);
            }
            var totalSum = sumOfEvenPoints + sumOfOddPoints;
            Console.WriteLine($"The project prize was {moneyPerPoint * totalSum:f2} lv.");
        }
    }
}
