using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    // Add a new entry to the journal
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    // Display all journal entries
    public void DisplayEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries in the journal.");
        }
        else
        {
            foreach (Entry entry in _entries)
            {
                Console.WriteLine(entry.ToString());
            }
        }
    }

    // Save the journal to a file in CSV format
    public void SaveJournalAsCSV(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // Write header
            outputFile.WriteLine("Date,Prompt,Response");

            foreach (Entry entry in _entries)
            {
                // Escape any commas or quotes in the prompt or response
                string prompt = EscapeForCSV(entry.Prompt);
                string response = EscapeForCSV(entry.Response);

                outputFile.WriteLine($"{entry.Date},{prompt},{response}");
            }
        }
        Console.WriteLine("Journal saved successfully as CSV.");
    }

    // Load the journal from a CSV file
    public void LoadJournalFromCSV(string filename)
    {
        _entries.Clear();
        if (File.Exists(filename))
        {
            string[] lines = System.IO.File.ReadAllLines(filename);

            // Skip the header
            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] parts = SplitCSVLine(line);
                if (parts.Length == 3)
                {
                    Entry entry = new Entry(parts[1], parts[2], parts[0]);
                    _entries.Add(entry);
                }
            }
            Console.WriteLine("Journal loaded successfully from CSV.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    // Method to escape commas and quotation marks for CSV
    private string EscapeForCSV(string field)
    {
        if (field.Contains(",") || field.Contains("\""))
        {
            field = "\"" + field.Replace("\"", "\"\"") + "\"";
        }
        return field;
    }

    // Method to split a CSV line, handling escaped commas and quotes
    private string[] SplitCSVLine(string line)
    {
        List<string> parts = new List<string>();
        bool insideQuote = false;
        string current = "";

        foreach (char c in line)
        {
            if (c == '"' && !insideQuote)
            {
                insideQuote = true;
            }
            else if (c == '"' && insideQuote)
            {
                insideQuote = false;
            }
            else if (c == ',' && !insideQuote)
            {
                parts.Add(current);
                current = "";
            }
            else
            {
                current += c;
            }
        }
        parts.Add(current);
        return parts.ToArray();
    }
}
