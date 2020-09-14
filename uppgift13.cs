using System;
using System.Linq;

namespace Uppgift13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mata in din text: ");
            string userInput = Console.ReadLine();

            string resultString = string.Join(" ", userInput.Split(' ').Select(x => new string(x.Reverse().ToArray())));

            Console.WriteLine("din text i omvänd ordning :" + resultString);

        }
    }
}