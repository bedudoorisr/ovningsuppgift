using System;

namespace uppgift7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv in en månad: ");
            string månad = Console.ReadLine();

            switch (månad)
            {
                case "januari":
                    Console.WriteLine("Du skrev in månad 1.");
                    break;
                case "februari":
                    Console.WriteLine("Du skrev in månad 2.");
                    break;
                case "mars":
                    Console.WriteLine("Du skrev in månad 3.");
                    break;
                case "april":
                    Console.WriteLine("Du skrev in månad 4.");
                    break;
                case "maj":
                    Console.WriteLine("Du skrev in månad 5.");
                    break;
                case "juni":
                    Console.WriteLine("Du skrev in månad 6.");
                    break;
                case "juli":
                    Console.WriteLine("Du skrev in månad 7.");
                    break;
                case "augusti":
                    Console.WriteLine("Du skrev in månad 8.");
                    break;
                case "september":
                    Console.WriteLine("Du skrev in månad 9.");
                    break;
                case "oktober":
                    Console.WriteLine("Du skrev in månad 10.");
                    break;
                case "november":
                    Console.WriteLine("Du skrev in månad 11.");
                    break;
                case "december":
                    Console.WriteLine("Du skrev in månad 12.");
                    break;
            }
            Console.ReadKey();
        }
    }
}

