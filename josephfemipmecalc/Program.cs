using System;
using System.Runtime.ExceptionServices;

namespace josephfemipmecalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
              Console.WriteLine("Welcome to the simple calculator");
              Console.WriteLine("please Enter the first number");
                   
            
                Console.WriteLine("Select operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");

                Console.Write("Enter choice (1/2/3/4): ");
                char choice = Console.ReadKey().KeyChar;
                Console.WriteLine();

                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                switch (choice)
                {
                    case '1':
                        Console.WriteLine($"{num1} + {num2} = {Add(num1, num2)}");
                        break;
                    case '2':
                        Console.WriteLine($"{num1} - {num2} = {Subtract(num1, num2)}");
                        break;
                    case '3':
                        Console.WriteLine($"{num1} * {num2} = {Multiply(num1, num2)}");
                        break;
                    case '4':
                        if (num2 != 0)
                            Console.WriteLine($"{num1} / {num2} = {Divide(num1, num2)}");
                        else
                            Console.WriteLine("Cannot divide by zero");
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }

            static double Add(double x, double y)
            {
                return x + y;
            }

            static double Subtract(double x, double y)
            {
                return x - y;
            }

            static double Multiply(double x, double y)
            {
                return x * y;
            }

            static double Divide(double x, double y)
            {
                return x / y;
            }
        }
    }




