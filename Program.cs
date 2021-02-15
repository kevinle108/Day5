using System;
using System.Collections.Generic;
using System.Linq;

namespace Day5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter a positive number (or 0 to quit): ");
                string input = Console.ReadLine();
                if (input == "0") break;
                if (Int32.TryParse(input, out int num) && num >= 1)
                {
                    if (num == 1 || num == 2) Console.WriteLine($"{num} = {num}");
                    else
                    {
                        string output = $"{num} = ";
                        int origin = num;
                        int factor = 2;
                        List<int> primesList = new List<int>();
                        while (factor <= Math.Ceiling(Math.Sqrt(Convert.ToDouble(origin))))   // loop from 2 -> sqrt(n)
                        {
                            if (isPrime(num))
                            {
                                primesList.Add(num);
                                break;
                            }
                            if (num % factor == 0)
                            {
                                primesList.Add(factor);
                                num /= factor;
                            }
                            else
                            {
                                // find the next prime factor
                                factor = factor == 2 ? factor + 1 : factor + 2;
                                while (!isPrime(factor))
                                {
                                    factor += 2;
                                }
                                Console.WriteLine($"The next prime factor is {factor}");                               
                            }
                        }    
                        output += String.Join(" x ", primesList);
                        Console.WriteLine(output);
                    }
                }
                else Console.WriteLine("Invalid input!");
            }
            Console.WriteLine("Goodbye!");
            
            // checks to see if a number is prime or not
            bool isPrime(int num)
            {
                int factor = 2;
                while (factor <= Math.Sqrt(num))
                {
                    if (num % factor == 0) return false;
                    else factor++;
                }
                return true;
            }
        }
    }
}
