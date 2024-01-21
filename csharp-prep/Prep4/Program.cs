using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        List<int> numbers = new List<int>();

        int usernumber = -1;
        while (usernumber != 0)
        {
            Console.Write("Enter number: ");
            string userInput =Console.ReadLine();
            usernumber = int.Parse(userInput);

            if (usernumber != 0)
            {
                numbers.Add(usernumber);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum = sum + number;
        }
        Console.WriteLine($"The sum is: {sum}");

        float floatSum = sum;
        float average = floatSum / numbers.Count;
        Console.WriteLine($"The average is {average}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");
    }
}