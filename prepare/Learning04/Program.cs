using System;

class Program
{
    static void Main(string[] args)
    {

        Assignment assignment = new("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine("\n");


        MathAssignment mathAssignment = new("Roberto Rodriguez", "Fraction", "Section 7.3", "Problems 8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine("\n");

        WritingAssignment writingAssignment = new("Mary Waters", "European History", "The Cause of World War II");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());



    }
}