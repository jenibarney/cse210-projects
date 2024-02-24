using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Assignment one = new Assignment("Samuel Bennett", "Multiplication");
        string firstSummary = one.GetSummary();
        Console.WriteLine(firstSummary);

        MathAssignment two = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        string secondSummary = two.GetSummary();
        Console.WriteLine(secondSummary);
        string secondHWList = two.GetHomeworkList();
        Console.WriteLine(secondHWList);

        WritingAssignment three = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        string thirdSummary = three.GetSummary();
        Console.WriteLine(thirdSummary);
        string thirdWritingInfo = three.GetWritingInfo();
        Console.WriteLine(thirdWritingInfo);

    }
}