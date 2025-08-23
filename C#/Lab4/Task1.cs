// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    public static int Power(int num1, int num2)
    {
        if (num2 == 0)
            return 1;
        return num1 * Power(num1, num2 - 1);
    }
    public static void Main()
    {
        Console.WriteLine(Power(2, 3));
    }
}
