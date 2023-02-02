public class Menu
{
    public void Display()
    {
        bool i = true;

        while (i == true) 
        {
            System.Console.WriteLine("------ MENU -------");
            System.Console.WriteLine("1) Write");        
            System.Console.WriteLine("2) Display");        
            System.Console.WriteLine("3) Load");        
            System.Console.WriteLine("4) Save"); 
            System.Console.WriteLine("5) Quit");       
            System.Console.WriteLine("-------------------");
            System.Console.Write("Choose a Value: ");
            string value = Console.ReadLine();

            if (value == "1") {
                Entry entry = new Entry();

                entry.GetPrompt();
                Console.WriteLine("Start Typing: ");
            }

            else if (value == "2") {
                Journal journal = new Journal();

                journal.Display();
            }

            else if (value == "3") {
                Console.WriteLine("What file to read: ");
                string file = Console.ReadLine();
            }

            else if (value == "4") {
                Console.WriteLine("Save the File: ");
                string save = Console.ReadLine();
            }

            else if (value == "5") {
                i = false;
                Console.WriteLine("Have a Good Day!");
            }

            else {
                Console.WriteLine("Please Enter an Acceptable Value");
            }

        
        }
    }
}