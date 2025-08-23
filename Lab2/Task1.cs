using System;
class MyClass
{
    static void Main()
    {
        int grade;
        Console.Write("Enter grade: ");
        grade = int.Parse(Console.ReadLine());
        if (grade >= 90)
        {
            Console.WriteLine("A");
        }
        else
        {
            if (grade >= 80)
            {
                Console.WriteLine("B");
            }
            else
            {
                if (grade >= 60)
                {
                    Console.WriteLine("C");
                }
                else
                {
                    Console.WriteLine("Fail");
                }
            }
        }
    }
}
