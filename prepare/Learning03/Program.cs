using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        string f1String = f1.MakeStringFraction();
        Console.WriteLine(f1String);
        double f1Decimal = f1.CalcDecimal();
        Console.WriteLine(f1Decimal);

        Fraction f2 = new Fraction(6);
        string f2String = f2.MakeStringFraction();
        Console.WriteLine(f2String);
        double f2Decimal = f2.CalcDecimal();
        Console.WriteLine(f2Decimal);

        Fraction f3 = new Fraction(4, 7);
        string f3String = f3.MakeStringFraction();
        Console.WriteLine(f3String);
        double f3Decimal = f3.CalcDecimal();
        Console.WriteLine(f3Decimal);
        



        
    }
}