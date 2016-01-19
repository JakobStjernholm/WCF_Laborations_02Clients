using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClientBMI
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateBMIClient client = new CalculateBMIClient();
            Console.WriteLine("Type length: ");
            var length = double.Parse(Console.ReadLine());
            Console.WriteLine("Type weight: ");
            var weight = double.Parse(Console.ReadLine());
            var result = client.CalculateBmi(length,weight);
            Console.WriteLine($"Your BMI is: {result}");
            Console.ReadKey();
        }
    }
}
