using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClientDays
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateDaysClassClient client = new CalculateDaysClassClient();
            Console.WriteLine("Enter birthday (YYYY-MM-DD):");
            var date = Console.ReadLine();
            Console.WriteLine(client.GetNextDateWhen1000(date));
            Console.ReadKey();
        }
    }
}
