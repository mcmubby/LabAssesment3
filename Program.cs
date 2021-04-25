using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            Console.WriteLine("Please Input the first number");
            int firstUserInput = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Input the Second number");
            int secondUserInput = int.Parse(Console.ReadLine());
                
                var result = number1 % number2;
                System.Console.WriteLine($"The remainder of {number1} and {number2} is {result}");
            }
            catch
            {
                Console.WriteLine("The value you passed in was not able to process. Please provide another number");
            }
        }
    }
}
