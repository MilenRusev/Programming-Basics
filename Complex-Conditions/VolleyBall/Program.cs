using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolleyBall
{
    class Program
    {
        static void Main(string[] args)
        {
            var typeOfYear = Console.ReadLine().ToLower();
            var hollydays = int.Parse(Console.ReadLine());
            var weekendInHomeTown = int.Parse(Console.ReadLine());
            var numberOfPlaysForYear = 48;

            if (typeOfYear == "normal")
            {
                double broiIgriVSofia = (numberOfPlaysForYear - weekendInHomeTown) * 3.0 / 4;
                double broiIgriVTqh = weekendInHomeTown;
                double broiIgriNaPraznici = hollydays * 2.0 / 3;
                double totalGames = broiIgriNaPraznici + broiIgriVSofia + broiIgriVTqh;
                Console.WriteLine(Math.Truncate(totalGames));
            }
            else if (typeOfYear == "leap")
            {
                double broiIgriVSofia = (numberOfPlaysForYear - weekendInHomeTown) * 3.0 / 4;
                double broiIgriVTqh = weekendInHomeTown;
                double broiIgriNaPraznici = hollydays * 2.0 / 3;
                double totalGames = broiIgriNaPraznici + broiIgriVSofia + broiIgriVTqh;                
                double realTotalGames = totalGames * 1.15;               
                Console.WriteLine(Math.Truncate(realTotalGames));
            }
        }
    }
}
