using System;

namespace Lab3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("This app takes two numbers (a and b) and prints out the remainder of a % b");
            try
            {
                Console.Write("Please Input the first number (a) : ");
                int firstUserInput = int.Parse(Console.ReadLine());

                Console.Write("Please Input the Second number (b) : ");
                int secondUserInput = int.Parse(Console.ReadLine());

                int result = firstUserInput % secondUserInput;
                Console.WriteLine($"The remainder of {firstUserInput} % {secondUserInput} is {result}");
            }
            catch
            {
                Console.WriteLine("One of the input was not a number. Please try again.");
                Main();
            }
        }
    }
}
