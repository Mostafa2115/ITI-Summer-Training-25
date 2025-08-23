// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    public static int FindMax(int num1, int num2, int num3, int num4, int num5)
    {
        int max = num1;
        if (num2 > max) max = num2;
        if (num3 > max) max = num3;
        if (num4 > max) max = num4;
        if (num5 > max) max = num5;
        return max;
    }

    public static void Main()
    {
        Console.WriteLine("Please enter 5 numbers:");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());
        int num4 = int.Parse(Console.ReadLine());
        int num5 = int.Parse(Console.ReadLine());

        int max = FindMax(num1, num2, num3, num4, num5);
        Console.WriteLine("The maximum number is: " + max);
    }
}
