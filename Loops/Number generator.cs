using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGenerator_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var M = int.Parse(Console.ReadLine());
            var N = int.Parse(Console.ReadLine());
            var L = int.Parse(Console.ReadLine());
            var specialNum = int.Parse(Console.ReadLine());
            var controlNum = int.Parse(Console.ReadLine());           
            var flag = false;

            for (int i = M; i >= 1; i--)
            {
                for (int g = N; g >= 1; g--)
                {
                    for (int k = L; k >= 1; k--)
                    {
                        if ((i + g + k) % 3 == 0)
                        {
                            specialNum += 5;
                        }
                        else if (k == 5)
                        {
                            specialNum -= 2;
                        }
                        else if (k % 2 == 0)
                        {
                            specialNum *= 2;
                        }
                        if (specialNum >= controlNum)
                        {
                            Console.WriteLine($"Yes! Control number was reached! Current special number is {specialNum}.");
                            flag = true;
                            break;

                        }
                        
                    }
                    if (flag == true)
                    {
                        break;
                    }
                }
                if (flag == true)
                {
                    break;
                }
            }
            if (flag == false)
            {
                Console.WriteLine($"No! {specialNum} is the last reached special number.");
            }
            
        }
    }
}
