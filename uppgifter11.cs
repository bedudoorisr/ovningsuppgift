using System;

namespace uppgifter11
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] array = new string[10] { "noll", "ett", "två", "tre", "fyra", "fem", "sex", "sju", "åtta", "nio" };

            Console.Write("Ange en siffra mellan 0 till 9: ");
            int inmatat = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(array[inmatat]);

        }
    }
}