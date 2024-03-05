using System;

class Program
{
    static void Main(string[] args)
    {
        int inputNumber = 0;
        int sum = 0;
        int largest = 0;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter number: ");
            inputNumber = int.Parse(Console.ReadLine());
            numbers.Add(inputNumber);
        } while (inputNumber != 0);

        int smallest = numbers[0];
        foreach (int number in numbers)
        {
            sum += number;
            if (number >= largest)
            {
                largest = number;
            }
            if (number > 0 && number <= smallest)
            {
                smallest = number;
            }
        }

        double counter = numbers.Count() - 1;
        double average = sum / counter;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallest}");
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }


    }
}