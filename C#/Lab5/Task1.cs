// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    public static void Main()
    {
        int numberOfStudents = 4;
        int numberOfSubjects = 3;
        double[,] grades = new double[numberOfStudents, numberOfSubjects];
        double[] totalGrades = new double[numberOfStudents];
        double[] averageGrades = new double[numberOfSubjects];
        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine($"Enter grades for Student {i + 1}:");
            for (int j = 0; j < numberOfSubjects; j++)
            {
                Console.Write($"Subject {j + 1}: ");
                grades[i, j] = double.Parse(Console.ReadLine());
                totalGrades[i] += grades[i, j];
            }
        }

        for (int j = 0; j < numberOfSubjects; j++)
        {
            for (int i = 0; i < numberOfStudents; i++)
            {
                averageGrades[j] += grades[i, j];
            }
            averageGrades[j] /= numberOfStudents;
        }

        Console.WriteLine("\nTotal Grades for each student:");
        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine($"Student {i + 1}: {totalGrades[i]}");
        }

        Console.WriteLine("\nAverage Grades for each subject:");
        for (int j = 0; j < numberOfSubjects; j++)
        {
            Console.WriteLine($"Subject {j + 1}: {averageGrades[j]}");
        }
    }
}
