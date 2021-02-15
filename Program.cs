using System;
using System.Collections.Generic;
using System.Linq;

namespace Day5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            while (true)
            {
                Console.Write("Enter a positive number (or 0 to quit): ");

                if (int.TryParse(Console.ReadLine(), out num) && num >= 0)
                {

                    if (num == 0) break;
                    string output = $"{num} = ";
                    if (num == 1)
                    {
                        Console.WriteLine(output += '1');
                        return;
                    }
                    List<int> primesList = new List<int>();
                    int factor = 2;
                    while (num != 1)
                    {
                        if (num % factor == 0)
                        {
                            primesList.Add(factor);
                            num = num / factor;
                        }
                        else
                        {
                            factor++;
                        }
                    }
                    output += String.Join(" x ", primesList.ToArray());
                    Console.WriteLine(output);

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            Console.WriteLine("Goodbye!");


        }
    }
}
