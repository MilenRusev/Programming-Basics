using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            var player1Pokemons = int.Parse(Console.ReadLine());
            var player2Pokemons = int.Parse(Console.ReadLine());
            var maxNumOfBattles = int.Parse(Console.ReadLine());
            var counter = 0;
            for (int player1 = 1; player1 <= player1Pokemons; player1++)
            {
                for (int player2 = 1; player2 <= player2Pokemons; player2++)
                {
                    counter++;
                    if (maxNumOfBattles < counter)
                    {
                        break;
                    }
                    Console.Write($"({player1} <-> {player2}) ");
                    
                }
               
            }
            
        }
    }
}
