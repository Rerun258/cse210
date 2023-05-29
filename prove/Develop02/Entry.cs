public class Entry{
    private string text;
    private string date;

    

    public string newEntry(){
        Prompt.GetRandomPrompt();
        text = Console.Read();

        Console.Write("What is the Date: ");
        date = Console.Read();

        string x = ($"{date}, {text}");
        return x;

    }

}