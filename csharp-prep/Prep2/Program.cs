using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }

        string sign = "";
        if (grade > 59 && grade < 97 && grade % 10 >= 7)
        {
            sign = "+";
        }
        else if (grade > 56 && grade % 10 < 7)
        {
            sign = "-";
        }

        Console.WriteLine($"Your grade is {letter}{sign}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations for passing!");
        }
        else
        {
            Console.WriteLine("You can do it next time!");

        }
    }
}