using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClientWords
{
    class Program
    {
        static void Main(string[] args)
        {
            WordClassClient client = new WordClassClient();
            Console.WriteLine("Skriv in en text, så räknar vi ut antalet ord!");
            var result = client.GetNumberOfWords(Console.ReadLine());
            Console.WriteLine("Antalet ord: " + result);
            Console.ReadKey();


        }
    }
}
