using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var doktors = 7;
            var treatedPatients = 0;
            var nonTreatedPatients = 0;
            var sumUntreated = 0;
            var sumTreated = 0;
            for (int i = 1; i <= n; i++)
            {
                var dayPatients = int.Parse(Console.ReadLine());

                if (i % 3 == 0 && sumUntreated > sumTreated)
                {
                    doktors++;
                }
                if (dayPatients > doktors)
                {                    
                    treatedPatients = doktors;
                    nonTreatedPatients = dayPatients - doktors;
                    sumUntreated += nonTreatedPatients;                                      
                }
                else
                {
                    treatedPatients = dayPatients;
                }
                sumTreated += treatedPatients;
                
            }
           Console.WriteLine($"Treated patients: {sumTreated}.");
           Console.WriteLine($"Untreated patients: {sumUntreated}.");
        }
    }
}
