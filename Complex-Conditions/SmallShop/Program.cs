using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var produkt = Console.ReadLine();
            var grad = Console.ReadLine();            
            var quantity = double.Parse(Console.ReadLine());

            if (grad == "Sofia")
            {
                if (produkt == "coffee") Console.WriteLine(quantity * 0.50);
                else if (produkt == "water") Console.WriteLine(quantity * 0.80);
                else if (produkt == "beer") Console.WriteLine(quantity * 1.2);
                else if (produkt == "sweets") Console.WriteLine(quantity * 1.45);
                else if (produkt == "peanuts") Console.WriteLine(quantity * 1.60);
            }
            else if (grad == "Plovdiv")
            {
                if (produkt == "coffee") Console.WriteLine(quantity * 0.40);
                else if (produkt == "water") Console.WriteLine(quantity * 0.70);
                else if (produkt == "beer") Console.WriteLine(quantity * 1.15);
                else if (produkt == "sweets") Console.WriteLine(quantity * 1.30);
                else if (produkt == "peanuts") Console.WriteLine(quantity * 1.50);
            }
            else if (grad == "Varna")
            {
                if (produkt == "coffee") Console.WriteLine(quantity * 0.45);
                else if (produkt == "water") Console.WriteLine(quantity * 0.70);
                else if (produkt == "beer") Console.WriteLine(quantity * 1.10);
                else if (produkt == "sweets") Console.WriteLine(quantity * 1.35);
                else if (produkt == "peanuts") Console.WriteLine(quantity * 1.55);
            }
        }
    }
}
