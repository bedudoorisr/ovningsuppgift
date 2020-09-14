using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Type in a string:");
                string input = Console.ReadLine();
                long sum = 0;
                Console.ForegroundColor = ConsoleColor.Gray;
                for (int i = 0; i < input.Length; i++)
                {
                    if (Char.IsNumber(input, i))
                    {

                        char bookend = input[i];
                        for (int j = i + 1; j < input.Length; j++)
                        {
                            if (!Char.IsNumber(input, j))
                            {
                                break;
                            }
                            if (input[j] == bookend)
                            {
                                string pre = input.Substring(0, i);
                                string mid = input.Substring(i, j - i + 1);
                                string end = input.Substring(j + 1, input.Length - j - 1);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write(pre);
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write(mid);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine(end);
                                sum += sum + long.Parse(mid);
                                break;
                            }

                        }
                    }
                }
                Console.WriteLine($"The sum of your string is: {sum}");
                Console.ReadKey();
            }
        }
    }

