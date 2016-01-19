using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClientAge
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateAgeClassClient client = new CalculateAgeClassClient();
            Console.WriteLine("Enter a date! (exempel 1991-09-11)");
            var result = DateTime.Parse(Console.ReadLine());
            var answer = client.GetDays(result);
            Console.WriteLine($"DU är {answer} år gammal!");
            Console.ReadLine();
        }
    }
}
