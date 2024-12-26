using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char choice;
            do
            {
               
                    Console.WriteLine("\n--- Basic Calculator ---");
                    Console.WriteLine("1. Addition (+)");
                    Console.WriteLine("2. Subtraction (-)");
                    Console.WriteLine("3. Multiplication (*)");
                    Console.WriteLine("4. Division (/)");
                    Console.WriteLine("5. Exit");
                    Console.Write("Enter your choice: ");
                    int menuChoice = int.Parse(Console.ReadLine());

                   
                    if (menuChoice == 5)
                    {
                        Console.WriteLine("Exiting the program. Goodbye!");
                        break;
                    }

                    
                    Console.Write("Enter the first number: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter the second number: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                   
                    double result;
                    switch (menuChoice)
                    {
                        case 1:
                            result = num1 + num2;
                            Console.WriteLine($"Result: {num1} + {num2} = {result}");
                            break;

                        case 2:
                            result = num1 - num2;
                            Console.WriteLine($"Result: {num1} - {num2} = {result}");
                            break;

                        case 3:
                            result = num1 * num2;
                            Console.WriteLine($"Result: {num1} * {num2} = {result}");
                            break;

                        case 4:
                            if (num2 != 0)
                            {
                                result = num1 / num2;
                                Console.WriteLine($"Result: {num1} / {num2} = {result}");
                            }
                            else
                            {
                                Console.WriteLine("Error: Division by zero is not allowed.");
                            }
                            break;

                        default:
                            Console.WriteLine("Invalid choice! Please select a valid option.");
                            break;
                    }
                
                Console.Write("Do you want to perform another calculation? (y/n): ");
                choice = Console.ReadKey().KeyChar;
                Console.WriteLine();
            } while (char.ToLower(choice) == 'y');
        }
    }
}
