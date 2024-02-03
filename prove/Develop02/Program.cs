using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string userChoice = "1";

        while(userChoice != "5")
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select from the following menu");
            Console.WriteLine("1. New");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    PromptGenerator promptGenerator = new PromptGenerator
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    string response = Console.ReadLine();
                    
                    // entry
                    Entry entry = new Entry();
                    entry._prompt = prompt;
                    entry._response = response;
                    entry._entryDate = DateTime.Now;

                    // journal
                    journal._entries.Add(entry);
                    break;

                case "2":
                    foreach (Entry singleEntry in journal._entries)
                    {
                        Console.WriteLine($"{singleEntry._entryDate} {singleEntry._prompt} {singleEntry._response}");
                    }
                    break;

                case "3":
                    //save
                    Console.WriteLine("Enter filename (format -> fileName.txt):");
                    string _filename = Console.ReadLine();
                    SaveFile(_filename);
                    break;

                case "4":
                    //load
                    break;

                

                
            


            }
}
}