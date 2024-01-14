using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What was your grade percentage?");
        string userinput = Console.ReadLine();
        int percent = int.Parse(userinput);
        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade: {letter}");

        if (letter == "A" || letter == "B" || letter == "C")
        {
            Console.WriteLine("Congrats! You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }

    }
}