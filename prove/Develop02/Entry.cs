public class Entry{
    private string text;
    private string date;
    private string _prompt;

    

    public void newEntry(){
        Prompt prompt = new Prompt();

        _prompt = prompt.GetRandomPrompt();
        Console.Write(_prompt);
        text = Console.ReadLine();
        
        DateTime theCurrentTime = DateTime.Now;
        date = theCurrentTime.ToShortDateString();
        // Console.Write("What is the Date: ");
        // date = Console.ReadLine();

        

    }
    public void display(){

        string x = ($"{date}, {text}");
        Console.Write(_prompt);
        Console.WriteLine(x);
    }

        public string write(){

        string x = ($"{date},{_prompt},{text}");
        return x;
    }

}