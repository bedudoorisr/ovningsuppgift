using System;

namespace Uppgift2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string hemligLösenord = "zaq12wsx";

                Console.Write("Skriv in ett lösenord: ");
                string userLösenord = Console.ReadLine();

                if (userLösenord == hemligLösenord)
                {
                    Console.WriteLine("Du skrev in rätt lösenord!");
                }
                else
                {
                    Console.WriteLine("Du skrev in fel lösenord.");
                }

                Console.ReadKey();
            }
        }
    }
}m