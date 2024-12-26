using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calculator
    {
        static void Main(string[] args)
        {
            
                Console.Write("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                
                Console.Write("Enter the operation (+, -, *, /): ");
                string operation = Console.ReadLine();

                
                double result;
                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"The result is: {result}");
                        break;

                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"The result is: {result}");
                        break;

                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"The result is: {result}");
                        break;

                    case "/":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            Console.WriteLine($"The result is: {result}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                        }
                        break;

                    default:
                        Console.WriteLine("Error: Invalid operation. Please use +, -, *, or /.");
                        break;
                }
            
        }
    }
}
