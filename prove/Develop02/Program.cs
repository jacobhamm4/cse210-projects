using System;
using System.Collections.Generic;

//WHY IS MY CODE PROMPTING WORDS THAT ARE NO LONGER THERE?? RUN CODE TO SEE. "BEGIN WRITING> ENTER THE DATE> WHAT IS THE DATE>DAY# CHOOSE A VALUE
class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        Entry entry = new Entry();

        menu.Display();


       // bool show = false;

        //while (value != 4);
        //    show = true;
    }
}

class Menu
{
    public void Display()
    {
        bool i = false;

        while (i == false) {

        System.Console.Write("Choose a Value: ");
        string number = Console.ReadLine();
        int value = Int32.Parse(number);
        //https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number

        System.Console.WriteLine("------ MENU -------");
        System.Console.WriteLine("1) Write");        
        System.Console.WriteLine("2) Display");        
        System.Console.WriteLine("3) Load");        
        System.Console.WriteLine("4) Save"); 
        System.Console.WriteLine("5) Quit");       
        System.Console.WriteLine("-------------------");

        if (value == 1)
            i = true;
            Console.WriteLine("Start Typing: ");
            string entry = Console.ReadLine();

        async Task ExampleAsync()
    {
        string text =
            ($"{entry}");
            //HOW TO SAVE INPUT FROM #1 TO THIS??

        await File.WriteAllTextAsync("journal.txt", text);
        // source-->https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-write-to-a-text-file
        
        


        if (value == 2)
        i = true;
            Console.WriteLine("What Journal entry would you like to read: ");
            string data = Console.ReadLine();
            string newEntry = System.IO.File.ReadAllText(@"C:\Users\Public\TestFolder\journal.txt");
            // source-->https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-read-from-a-text-file

        if (value == 3)
        i = true;
            Console.WriteLine("What file to read: ");
            string file = Console.ReadLine();

        if (value == 4)
        i = true;
            Console.WriteLine("Save the File: ");
            string save = Console.ReadLine();
        async Task ExampleAsync()
    {
        using StreamWriter file = new("journal.txt", append: true);
        await file.WriteLineAsync($"{entry}");
    }
    //WHY IS THERE ERRORS HERE
        //HOW TO APPEND NEW JOURNALS TO THIS??
        // source-->https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-write-to-a-text-file

        else if (value > 4)
        i = false;
            Console.WriteLine("Have a Good Day!");
        }
    }
}
}


class Day
{
    private void Display()
    {
    
    }
}

class Entry
{
    public List<Day> _inputs = new List<Day>();
}