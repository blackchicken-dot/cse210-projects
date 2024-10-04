using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;


public class Journal
{
    public List<Entry> Entries { get; set; }

    public Journal()
    {
        Entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        Entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (var entry in Entries)
        {
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}");
            Console.WriteLine();
        }
    }

    public void SaveToFile(string filename)
    {
        using (var writer = new StreamWriter(filename))
        {
            foreach (var entry in Entries)
            {
                writer.WriteLine($"{entry.Date}~{entry.Prompt}~{entry.Response}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        Entries.Clear();
        var lines = File.ReadAllLines(filename);
        foreach (var line in lines)
        {
            var parts = line.Split('~');
            var entry = new Entry(parts[0], parts[1], parts[2]);
            Entries.Add(entry);
        }
    }
}
