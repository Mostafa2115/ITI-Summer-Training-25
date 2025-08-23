using System;

class myClass
{
    public static void Main()
    {
        Console.WriteLine("Enter first number:");
        int num1 = Console.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int num2 = Console.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number:");
        int num3 = Console.Parse(Console.ReadLine());
        Console.WriteLine("Enter fourth number:");
        int num4 = Console.Parse(Console.ReadLine());
        Console.WriteLine("Enter fifth number:");
        int num5 = Console.Parse(Console.ReadLine());

        int max = num1;
        int min = num1;

        if (num2 > max)
        {
            max = num2;
        }
        if (num2 < min)
        {
            min = num2;
        }

        if (num3 > max)
        {
            max = num3;
        }
        if (num3 < min)
        {
            min = num3;
        }

        if (num4 > max)
        {
            max = num4;
        }
        if (num4 < min)
        {
            min = num4;
        }

        if (num5 > max)
        {
            max = num5;
        }
        if (num5 < min)
        {
            min = num5;
        }

        Console.WriteLine("Max number is: " + max);
        Console.WriteLine("Min number is: " + min);
    }
}
