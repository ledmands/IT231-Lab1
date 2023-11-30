using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intOne;
            int intTwo;

            Console.WriteLine("Please enter an integer: ");
            intOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another integer: ");
            intTwo = Convert.ToInt32(Console.ReadLine());

            int product = Multiply(intOne, intTwo);

            int sum = Add(intOne, intTwo);

	    Console.WriteLine("Product: " + product);
            Console.WriteLine("Sum: " + sum);
        }

        private static int Add(int a, int b) 
        {
            return a + b;
            
	}

        private static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
