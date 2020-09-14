using System;

namespace Uppgift4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mata in ditt namn: ");
            string UserName = Console.ReadLine();
            Console.Write("Skriv in ett tal: ");
            int tal = int.Parse(Console.ReadLine());

            for (int i = 0; i < tal; i++)
            {
                Console.WriteLine("Hej " + UserName + "!");
            }

            Console.ReadKey();
        }
    }
}