using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otsenki_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var broiQvilise = int.Parse(Console.ReadLine());
            var counter1 = 0.0;
            var counter2 = 0.0;
            var counter3 = 0.0;
            var counter4 = 0.0;
            var srednaOtsenka = 0.0;

            for (int otsenka = 0; otsenka < broiQvilise; otsenka++)
            {
                var otsenkaNaStudent = double.Parse(Console.ReadLine());

                if(otsenkaNaStudent >= 2 && otsenkaNaStudent < 3)
                {
                    counter1++;
                }
                if (otsenkaNaStudent >= 3 && otsenkaNaStudent < 4)
                {
                    counter2++;

                }
                if (otsenkaNaStudent >= 4 && otsenkaNaStudent < 5)
                {
                    counter3++;

                }
                if (otsenkaNaStudent >= 5)
                {
                    counter4++;

                }
                srednaOtsenka += otsenkaNaStudent;
            }
            Console.WriteLine($"Top students: {counter4 / broiQvilise * 100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {counter3 / broiQvilise * 100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {counter2 / broiQvilise * 100:f2}%");
            Console.WriteLine($"Fail: {counter1 / broiQvilise * 100:f2}%");
            Console.WriteLine($"Average: {srednaOtsenka / broiQvilise:f2}");
        }
    }
}
