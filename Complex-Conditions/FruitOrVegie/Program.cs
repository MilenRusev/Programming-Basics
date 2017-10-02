using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitOrVegie
{
    class Program
    {
        static void Main(string[] args)
        {
            var produk = Console.ReadLine();

            if (produk == "banana" || produk == "apple" || produk == "kiwi" || produk == "cherry" || produk == "lemon" || produk == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (produk == "tomato" || produk == "cucumber" || produk == "pepper" || produk == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
