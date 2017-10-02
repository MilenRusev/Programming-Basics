using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var projekciya = Console.ReadLine().ToLower();
            var redove = int.Parse(Console.ReadLine());
            var koloni = int.Parse(Console.ReadLine());
            var mesta = redove * koloni;

            if (projekciya == "premiere")
            {
                Console.WriteLine("{0:f2}", mesta * 12);
            }
            else if (projekciya == "normal")
            {
                Console.WriteLine("{0:f2}", mesta * 7.50);            
            }
            else if (projekciya == "discount")
            {
                Console.WriteLine("{0:f2}", mesta * 5);       
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
