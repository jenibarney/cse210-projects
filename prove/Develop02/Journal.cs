using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void SaveFile(_fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(_fileName))
{
    outputFile.WriteLine(_entries);
    }
}