using System;
using System.Collections.Generic;

class Journal {
    public List<Entry> _records = new List<Entry>();

//-----------------------------------------------------
    public void Display() {
        System.Console.WriteLine("Here are the Entries: ");
        foreach (Entry record in _records) {
            record.GetPrompt();
            _records.Add(record);
        System.Console.WriteLine($"{_records}");
        }
    }
//-----------------------------------------------------




}


// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-write-to-a-text-file