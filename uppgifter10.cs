using System;

namespace uppgifter10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mata in ett ord: ");
            string inmatat = Console.ReadLine();

            for (int i = 0; i < inmatat.Length; i++)
            {
                Console.WriteLine(inmatat[i]);
            }
        }
    }
}

