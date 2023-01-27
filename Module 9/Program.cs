namespace DelegatePractices
{
    using System;

    class Program
    {
        static string[] names = new string[] { "Ivanov", "Petrov", "Williams", "Johnson", "Brown" };

        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 to sort names A-Z or 2 to sort names Z-A:");
            try
            {
                int sortOrder = int.Parse(Console.ReadLine());
                if (sortOrder != 1 && sortOrder != 2)
                {
                    throw new InvalidInputException("Invalid input. Please enter 1 or 2.");
                }
                if (sortOrder == 1)
                {
                    Array.Sort(names);
                }
                else
                {
                    Array.Sort(names, (a, b) => b.CompareTo(a));
                }
                Console.WriteLine("Sorted names:");
                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine(names[i]);
                }
            }
            catch (InvalidInputException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
            finally
            {
                Console.WriteLine("Program execution complete.");
            }
        }
        public class InvalidInputException : Exception
        {
            public InvalidInputException()
            { }
            public InvalidInputException(string message)
                : base(message)
            { }
        }
    }
}
