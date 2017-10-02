using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazbivaneNaParola
{
    class Program
    {
        static void Main(string[] args)
        {
            //111111
            //123456
            //999999
            var myPass = "123456";
            for (int first = 1; first <= 9; first++)
            {
                for (int second = 1; second <= 9; second++)
                {
                    for (int third = 1; third <= 9; third++)
                    {
                        for (int forth = 1; forth <= 9; forth++)
                        {
                            for (int fifth = 1; fifth <= 9; fifth++)
                            {
                                for (int sixth = 1; sixth <= 9; sixth++)
                                {
                                    var currentPass = $"{first}{second}{third}{forth}{fifth}{sixth}";
                                    Console.WriteLine(currentPass);
                                    if (currentPass == myPass)
                                    {
                                        Console.WriteLine("HACKED");
                                        Console.ReadKey();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
