class Reference {
    private string _book = "John";
    private string _chapter = "3";
   
    public void Display(string[] scripture)
    {
        foreach (string word in scripture) {
            Console.Write($" {word}");
        }
    }

    public void HideWord(string[] scripture)
    {
        
    }

}