class Entry
{
    string _date;
    string prompt;
    string _response;
    
    public string GetPrompt() {
        Random pmt = new Random();
        prompt = prompts[pmt.Next(0,4)];
        DateTime today = DateTime.Today;
        _date = today.ToString("dd/MM/yyyy");
        Console.WriteLine(_date);
        Console.WriteLine(prompt);
        _response = Console.ReadLine();
        return _date + _response;
    }

/*
    public string UserResponses() {
        return _date + _response;
        
    }
*/

    public List<string> prompts = new List<string>() {
        "Best thing that happened today: ",
        "Worst thing that happened today: ",
        "Best person to influence your life today: ",
        "Worst experience to impact your day: ",
        "Best food you ate today: "
    };
}