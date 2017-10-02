using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruiut = Console.ReadLine().ToLower();
            var day = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());
            var price = -1.0;

            if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                if (fruiut == "banana") price = 2.50;
                else if (fruiut == "apple") price = 1.20;
                else if (fruiut == "orange") price = 0.85;
                else if (fruiut == "grapefruit") price = 1.45;
                else if (fruiut == "kiwi") price = 2.70;
                else if (fruiut == "pineapple") price = 5.50;
                else if (fruiut == "grapes") price = 3.85;
            }
            else if (day == "saturday" || day == "sunday")
            {
                if (fruiut == "banana") price = 2.70;
                else if (fruiut == "apple") price = 1.25;
                else if (fruiut == "orange") price = 0.90;
                else if (fruiut == "grapefruit") price = 1.60;
                else if (fruiut == "kiwi") price = 3.00;
                else if (fruiut == "pineapple") price = 5.60;
                else if (fruiut == "grapes") price = 4.20;
            }
            if (price >= 0)
            {
                Console.WriteLine("{0:f2}", price * quantity);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
