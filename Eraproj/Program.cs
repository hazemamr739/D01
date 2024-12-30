using System.ComponentModel;
using System.Diagnostics.Metrics;

namespace Eraproj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Islam's Carpet cleaning Service\n $25 per small\n $35 per large " +
                "\n Sales Tax rate is 6%\n" +
                " Estimates are valid for 30 days");

            Console.WriteLine("price per small carpet is : $25\nprice for large carpet is :$35"  );
            Console.WriteLine(" How many small carpet do you have ?");
            int smallCarpet = int.Parse(Console.ReadLine());
            Console.WriteLine(" How many Large carpet do you have ?");
            int largeCarpet = int.Parse(Console.ReadLine());
            int largeCarpetBill = largeCarpet * 35;
            int smallCarpetBill = smallCarpet * 25;
            double smallCarpetTax = 6% smallCarpetBill;
            double largeCarpetTax = 6% largeCarpetBill;
            double totalsmallcarpetcost = smallCarpetBill + smallCarpetTax;
            double totallargecarpetcost = largeCarpetBill + largeCarpetTax;

            Console.WriteLine($"Price for small Carpets is {smallCarpetBill} Tax is : ({smallCarpetTax})\n" +
                $"Total small carpets estimate is {totalsmallcarpetcost}");
            Console.WriteLine($"Price for Large Carpets is {largeCarpetBill} Tax is : ({largeCarpetTax})\n" +
                $"Total Large Carpets estimate {totallargecarpetcost}");
             

            Console.WriteLine($"Total estimate is {totalsmallcarpetcost+totallargecarpetcost}" +
                $" \nThis estimate is valid for 30 days");
            

        }
    }
}
