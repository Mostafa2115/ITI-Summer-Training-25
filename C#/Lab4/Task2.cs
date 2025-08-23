// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
    public static int Subtract(int a, int b)
    {
        return a - b;
    }
    public static int Multiply(int a, int b)
    {
        return a * b;
    }
    public static int Divide(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            return 0;
        }
        return a / b;
    }

    public static void Main()
    {
        do
        {
            Console.WriteLine("1 ) ADD");
            Console.WriteLine("2 ) SUBTRACT");
            Console.WriteLine("3 ) MULTIPLY");
            Console.WriteLine("4 ) DIVIDE");
            Console.WriteLine("5 ) EXIT");
            Console.Write("Please Enter a number from 1 to 5 :");
            int number = int.Parse(Console.ReadLine());
            if (number < 1 || number > 5)
            {
                Console.WriteLine("Invalid option. Please try again.");
                continue;
            }
            if (number == 5)
            {
                Console.WriteLine("Exiting...");
                break;
            }
            Console.Write("Please Enter the first number :");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Please Enter the second number :");
            int num2 = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.WriteLine("Result: " + Add(num1, num2));
                    break;
                case 2:
                    Console.WriteLine("Result: " + Subtract(num1, num2));
                    break;
                case 3:
                    Console.WriteLine("Result: " + Multiply(num1, num2));
                    break;
                case 4:
                    Console.WriteLine("Result: " + Divide(num1, num2));
                    break;
                default:
                    break;
            }
        } while (true);
    }
}
