// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    public static void Main()
    {
        int numberOfStudents = 4;
        double[] totalGrades = new double[numberOfStudents];
        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine($"Enter the number of subjects for Student {i + 1}:");
            int numberOfSubjects = int.Parse(Console.ReadLine());
            double[] grades = new double[numberOfSubjects];
            for (int j = 0; j < numberOfSubjects; j++)
            {
                Console.Write($"Enter grade for Subject {j + 1}: ");
                grades[j] = double.Parse(Console.ReadLine());
                totalGrades[i] += grades[j];
            }
        }
    }
}
