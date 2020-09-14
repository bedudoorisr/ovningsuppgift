using System;

namespace Uppgift9
{
    class Program
    {
        static void Main(string[] args)

        {
            Random random = new Random();
            int randomNummer = random.Next(1, 100);


            Console.WriteLine("Skriv in ett heltal");
            int.TryParse(Console.ReadLine(), out int userInput);

            while (userInput != randomNummer)
            {

                if (userInput < randomNummer)
                {
                    Console.WriteLine("du får gissa högre");

                    int.TryParse(Console.ReadLine(), out userInput);
                }

                if (userInput > randomNummer)
                {

                    Console.WriteLine("du får gissa lägre");
                    int.TryParse(Console.ReadLine(), out userInput);
                }
            }
            Console.WriteLine("Wow du vann");
        }
    }
}