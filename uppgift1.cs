using System;

namespace Uppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mata in ditt namn: ");
            string UserName = Console.ReadLine();
            Console.WriteLine("Hej " + UserName + "!");
            Console.ReadKey();
        }
    }
}