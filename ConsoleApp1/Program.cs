using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int number = int.Parse(Console.ReadLine());

            if (IsPrime(number))
            {
                Console.WriteLine("Number is prime");
            }
            else
            {
                Console.WriteLine("Number is not prime");
            }
        }

        static bool IsPrime(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }
    }
}
