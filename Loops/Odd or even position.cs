using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());

            var oddSum = 0.0;
            var evenSum = 0.0;

            var evenMin = double.MaxValue;
            var evenMax = double.MinValue;

            var OddMin = double.MaxValue;
            var OddMax = double.MinValue;


            for (int i = 1; i <= n; i++)
            {
                var currentNumber = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    if (currentNumber < evenMin)
                    {
                        evenMin = currentNumber;
                    }
                    if (currentNumber > evenMax)
                    {
                        evenMax = currentNumber;
                    }
                    evenSum += currentNumber;
                }
                else
                {
                    if (currentNumber < OddMin)
                    {
                        OddMin = currentNumber;
                    }
                    if (currentNumber > OddMax)
                    {
                        OddMax = currentNumber;
                    }
                    oddSum += currentNumber;

                }
            }
            Console.WriteLine($"OddSum = {oddSum},");

            if(OddMin == double.MaxValue)
            {
                Console.WriteLine("OddMin = No,");
            }
            else
            {
                Console.WriteLine($"OddMin = {OddMin},");
            }

            if (OddMax == double.MinValue)
            {
                Console.WriteLine("OddMax = No,");
            }
            else
            {
                Console.WriteLine($"OddMax = {OddMax},");
            }    
            
            Console.WriteLine($"EvenSum = {evenSum},");

            if (evenMin == double.MaxValue)
            {
                Console.WriteLine("EvenMin = No,");
            }
            else
            {
                Console.WriteLine($"EvenMin = {evenMin},");
            }

            if (evenMax == double.MinValue)
            {
                Console.WriteLine("EvenMax = No,");
            }
            else
            {
                Console.WriteLine($"EvenMax = {evenMax}");
            }            
        }
    }
}
