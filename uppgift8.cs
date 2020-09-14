using System;

namespace Uppgift8
{
    class Program
    {
        static void Main(string[] args)
        {
            int siffra = 1;
            for (int i = 1; i <= 16; i++)
            {
                siffra = i * i;
                Console.WriteLine(siffra);
            }

        }
    }
}
