using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public static void SaveFile(string _fileName, List<Entry> _entries)
    {
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            
            foreach (Entry singleEntry in _entries)
            {
                outputFile.WriteLine($"{singleEntry._entryDate} {singleEntry._prompt} {singleEntry._response}");
            }
        }
    }
    public static List<Entry> LoadFromFile(string _filename)
    {
        List<Entry> _entries = new List<Entry>();
        
        string[] lines = System.IO.File.ReadAllLines(_filename);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
        return _entries;
    }
}
//