using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment19_Part2
{
    // Step 1: Create a generic delegate named Operation<T>
    public delegate T Operation<T>(T num1, T num2);

    internal class Program
    {
        // Step 2: Implement four static methods: Add, Subtract, Multiply, and Divide
        static T Add<T>(T num1, T num2)
        {
            dynamic a = num1;
            dynamic b = num2;
            return a + b;
        }

        static T Subtract<T>(T num1, T num2)
        {
            dynamic a = num1;
            dynamic b = num2;
            return a - b;
        }

        static T Multiply<T>(T num1, T num2)
        {
            dynamic a = num1;
            dynamic b = num2;
            return a * b;
        }

        static T Divide<T>(T num1, T num2)
        {
            dynamic a = num1;
            dynamic b = num2;
            if (b == 0)
            {
                throw new ArgumentException("Cannot divide by zero.");
            }
            return a / b;
        }


        static void Main(string[] args)
        {
            // Step 3: Create instances of the Operation<T> delegate
            Operation<double> addDelegate = Add;
            Operation<double> subtractDelegate = Subtract;
            Operation<double> multiplyDelegate = Multiply;
            Operation<double> divideDelegate = Divide;

            // Step 4: Ask the user to input two values of the same data type

            Console.WriteLine("Enter two values of the same data type:");
            string inputType = Console.ReadLine();
            Console.WriteLine("Enter the first value:");
            dynamic value1 = Convert.ChangeType(Console.ReadLine(), Type.GetType(inputType));
            Console.WriteLine("Enter the second value:");
            dynamic value2 = Convert.ChangeType(Console.ReadLine(), Type.GetType(inputType));

            // Step 5: Select the option by user
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid choice.");
                return;
            }

            // Step 6: Call the corresponding method through the generic delegate based on user's choice
            try
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"Result: {addDelegate(value1, value2)}");
                        break;
                    case 2:
                        Console.WriteLine($"Result: {subtractDelegate(value1, value2)}");
                        break;
                    case 3:
                        Console.WriteLine($"Result: {multiplyDelegate(value1, value2)}");
                        break;
                    case 4:
                        Console.WriteLine($"Result: {divideDelegate(value1, value2)}");
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Error: Invalid input or operation.");
            }
        }
    }
}
