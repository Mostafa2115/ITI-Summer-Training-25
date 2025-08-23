// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    public static void Add()
    {
        Console.Write("Enter first number:");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter second number:");
        int num2 = int.Parse(Console.ReadLine());
        if (num1 == num2)
        {
            Console.WriteLine("Both numbers are equal.");
        }
        Console.WriteLine($"Result: {num1 + num2}");
    }
    public static void Subtract()
    {
        Console.Write("Enter first number:");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter second number:");
        int num2 = int.Parse(Console.ReadLine());
        if (num1 < num2)
        {
            Console.WriteLine("The Result is negative.");
        }
        Console.WriteLine($"Result: {num1 - num2}");
    }
    public static void Multiply()
    {
        Console.Write("Enter first number:");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter second number:");
        int num2 = int.Parse(Console.ReadLine());
        if (num1 == 1 || num2 == 1)
        {
            Console.WriteLine("Multiplication by 1 does not change the value.");
        }
        Console.WriteLine($"Result: {num1 * num2}");
    }
    public static void Divide()
    {
        Console.Write("Enter first number:");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter second number:");
        int num2 = int.Parse(Console.ReadLine());
        if (num2 == 0)
        {
            Console.WriteLine("Cannot divide by zero.");
            return;
        }
        Console.WriteLine($"Result: {num1 / num2}");
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
            switch (number)
            {
                case 1:
                    Add();
                    break;
                case 2:
                    Subtract();
                    break;
                case 3:
                    Multiply();
                    break;
                case 4:
                    Divide();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    continue;
            }
        } while (true);
    }
}
