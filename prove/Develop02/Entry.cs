public class Entry{
    private string _text;
    private string _date;
    private string _prompt;

    

    public void newEntry(){
        Prompt prompt = new Prompt();

        _prompt = prompt.GetRandomPrompt();
        Console.Write($"{_prompt}: ");
        _text = Console.ReadLine();
        
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();


        

    }
    public void display(){

        string x = ($"{_date},{_prompt}: {_text}");
        // Console.Write(_prompt);
        Console.WriteLine(x);
    }

    public string write(){

        string x = ($"{_date},{_prompt},{_text}");
        return x;
    }

    public void loadEntry(string date, string prompt, string text){
        _date = date;
        _prompt = prompt;
        _text= text;
        }

}