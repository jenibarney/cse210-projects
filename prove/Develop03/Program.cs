using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Scripture Memorizer");
        
        Reference reference1 = new Reference("John","3","16");
        string writtenReference = reference1.GetReference();
        Console.Write(writtenReference);
        
        
        






    }
}