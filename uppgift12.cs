using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Uppgift12
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int antalTal;
            int[] a = new int[100];

            Console.Write("Hur många tal vill du mata in? :");
            antalTal = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            for (i = 1; i < antalTal + 1; i++)
            {
                Console.Write("Ange tal {0}: ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nDu matade in: \n");
            for (i = 1; i < antalTal + 1; i++)
            {
                Console.Write("{0}  ", a[i]);
            }

            Console.Write("\n\nTalen i omvänd ordning:\n");
            for (i = antalTal; i >= 1; i--)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.Write("\n\n");
        }
    }
}