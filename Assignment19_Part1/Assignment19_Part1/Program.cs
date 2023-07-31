using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment19_Part1
{
    // Assignment: Part-1 

    // Step 1: Create a delegate named ArithmeticOperation
    public delegate int ArithmeticOperation(int num1, int num2);

    internal class Program
    {
        // Step 2: Implement four static methods: Add, Subtract, Multiply, and Divide
        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        static int Divide(int num1, int num2)
        {
            if (num2 == 0)
            {
                throw new ArgumentException("Cannot divide by zero.");
            }
            return num1 / num2;
        }
        static void Main(string[] args)
        {
            // Step 3: Create instances of the ArithmeticOperation delegate
            ArithmeticOperation addDelegate = Add;
            ArithmeticOperation subtractDelegate = Subtract;
            ArithmeticOperation multiplyDelegate = Multiply;
            ArithmeticOperation divideDelegate = Divide;

            // Step 4:Ask the user to input two integers.
            Console.WriteLine("Enter the Number1:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Number2:");
            int num2 = int.Parse(Console.ReadLine());

            // Step 5:Choose the options by user.
            Console.WriteLine("Choose an arithmetic operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            int choice = int.Parse(Console.ReadLine());

            // Step 6: Call the corresponding method through the delegate based on user's choice
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Addition of given Numbers are  {addDelegate(num1, num2)}");
                    break;
                case 2:
                    Console.WriteLine($"Subtraction of given Numbers are {subtractDelegate(num1, num2)}");
                    break;
                case 3:
                    Console.WriteLine($"Multiplication of given Numbers are {multiplyDelegate(num1, num2)}");
                    break;
                case 4:
                    try
                    {
                        Console.WriteLine($"Division of given Numbers are {divideDelegate(num1, num2)}");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
