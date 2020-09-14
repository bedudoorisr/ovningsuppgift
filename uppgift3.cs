using System;

namespace uppgift3c
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv in ett tal: ");
            int inmatatTal = int.Parse(Console.ReadLine());

            if (inmatatTal < 100)
            {
                Console.WriteLine("Talet du skrev in är mindre än 100");
            }
            else if (inmatatTal == 100)
            {
                Console.WriteLine("talet du skrev in är lika med 100");
            }
            else
            {
                Console.WriteLine("talet du skrev in är större än 100");
            }

            Console.ReadKey();
        }
    }
}