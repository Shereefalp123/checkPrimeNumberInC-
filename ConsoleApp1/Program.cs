using System.Collections.Generic;
namespace ConsoleApp1

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int number =int.Parse(Console.ReadLine());
            if (number > 0 && number % 2 !=0)
            {
                Console.WriteLine("number is prime");
            }
            else
            {
                Console.WriteLine("number is not prime");
            }

        }
    }
}