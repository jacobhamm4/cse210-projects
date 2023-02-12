class Word {
    private string _word;
    private string _hidden;

    public void Hide(string[] scripture)
    {
        Random random = new Random();
        int randint = random.Next(scripture.Count());

        scripture[randint] = "_";

    }
    public void Display()
    {
        //add code to show, change void?
    }
    private void IsHidden()
    {
        //add code to make words hidden, change void?
    }
    public void GetRenderedText()
    {
        //add code to get rendered text, change void to string?
    }
}