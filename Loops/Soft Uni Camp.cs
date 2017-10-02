using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            var numOfGroups = int.Parse(Console.ReadLine());

            var groupOf5 = 0.0;
            var groupOf12 = 0.0;
            var groupOf25 = 0.0;
            var groupOf40 = 0.0;
            var groupOfMore = 0.0;

            for (int i = 0; i < numOfGroups; i++)
            {
                var numOfMems = int.Parse(Console.ReadLine());
                if(numOfMems <= 5)   
                {

                    groupOf5+=numOfMems; //lek avtomobil
                }
                if(numOfMems > 5 && numOfMems <= 12)
                {
                    groupOf12 += numOfMems; //mikrobus
                }
                if (numOfMems > 12 && numOfMems <= 25)
                {
                    groupOf25 += numOfMems;  //malyk avtonus
                }
                if (numOfMems > 25 && numOfMems <= 40)
                {
                    groupOf40 += numOfMems;  //golqm avtobus
                }
                if (numOfMems > 40)
                {
                    groupOfMore += numOfMems;   //vlak
                }                
            }
            var totalMems = groupOf5 + groupOf12 + groupOf25 + groupOf40 + groupOfMore;
            Console.WriteLine($"{groupOf5 / totalMems * 100:f2}%");
            Console.WriteLine($"{groupOf12 / totalMems * 100:f2}%");
            Console.WriteLine($"{groupOf25 / totalMems * 100:f2}%");
            Console.WriteLine($"{groupOf40 / totalMems * 100:f2}%");
            Console.WriteLine($"{groupOfMore / totalMems * 100:f2}%");
        }
    }
}
