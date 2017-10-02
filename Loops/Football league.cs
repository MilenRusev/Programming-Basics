using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var stadiumSeats = double.Parse(Console.ReadLine());
            var fans = double.Parse(Console.ReadLine());
            var counterA = 0.0;
            var counterB = 0.0;
            var counterV = 0.0;
            var counterG = 0.0;

            for (int i = 0; i < fans; i++)
            {
                var sector = Console.ReadLine().ToLower();

                if(sector == "a")
                {
                    counterA++;
                }
                if (sector == "b")
                {
                    counterB++;
                }
                if (sector == "v")
                {
                    counterV++;
                }
                if (sector == "g")
                {
                    counterG++;
                }
            }
            var stadiumFans = fans / stadiumSeats;
            
          Console.WriteLine($"{counterA / fans * 100:f2}%");
          Console.WriteLine($"{counterB / fans * 100:f2}%");
          Console.WriteLine($"{counterV / fans * 100:f2}%");
          Console.WriteLine($"{counterG / fans * 100:f2}%");
          Console.WriteLine($"{stadiumFans * 100:f2}%");
        }
    }
}
