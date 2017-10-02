using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeComissions
{
    class Program
    {
        static void Main(string[] args)
        {
            var town = Console.ReadLine().ToLower();
            var prodajbi = double.Parse(Console.ReadLine());
            var komisionna = 0.0;

            if (town == "sofia")
            {
                if (prodajbi >= 0 && prodajbi <= 500) Console.WriteLine("{0:f2}", prodajbi * 0.05);
                else if (prodajbi > 500 && prodajbi <= 1000) Console.WriteLine("{0:f2}", prodajbi * 0.07);
                else if (prodajbi > 1000 && prodajbi <= 10000) Console.WriteLine("{0:f2}", prodajbi * 0.08);
                else if (prodajbi > 10000) Console.WriteLine("{0:f2}", prodajbi * 0.12);
                else Console.WriteLine("error");
            }
            else if (town == "varna")
            {
                if (prodajbi >= 0 && prodajbi <= 500) Console.WriteLine("{0:f2}", prodajbi * 0.045);
                else if (prodajbi > 500 && prodajbi <= 1000) Console.WriteLine("{0:f2}", prodajbi * 0.075);
                else if (prodajbi > 1000 && prodajbi <= 10000) Console.WriteLine("{0:f2}", prodajbi * 0.10);
                else if (prodajbi > 10000) Console.WriteLine("{0:f2}", prodajbi * 0.13);
                else Console.WriteLine("error");
            }
            else if (town == "plovdiv")
            {
                if (prodajbi >= 0 && prodajbi <= 500) Console.WriteLine("{0:f2}", prodajbi * 0.055);
                else if (prodajbi > 500 && prodajbi <= 1000) Console.WriteLine("{0:f2}", prodajbi * 0.08);
                else if (prodajbi > 1000 && prodajbi <= 10000) Console.WriteLine("{0:f2}", prodajbi * 0.12);
                else if (prodajbi > 10000) Console.WriteLine("{0:f2}", prodajbi * 0.145);
                else Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
