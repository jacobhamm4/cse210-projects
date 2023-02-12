using System;

class Program
{
    private string response;

    static void Main(string[] args)
    {


        //Create a while loop so that this code keeps running till its quit, but save off the rendered text
        {
        // Waiting for the user to press the enter key or quit
        Console.Write("Press -Enter- to [Hide Words] or Type 'Quit': ");
        string response = Console.ReadLine();

        // This will clear the console
        Console.Clear();

        // Display Prompt again
        Console.WriteLine("Press -Enter- to [Hide Words] or Type 'Quit': ");


        string _verse = "For God so bloved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";

        string[] scripture;

        scripture = _verse.Split(" ");

        Reference reference = new Reference();
        Scripture script = new Scripture();
        Word word = new Word();


        reference.Display(scripture);
        }
}
}