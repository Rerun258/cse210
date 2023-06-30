public class Reflection : Activity
{
    public Reflection(string name) : base(name)
    {
        _discription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _activityName = "Reflection";
    }

    private string RandomePrompt(){
        List<string> prompts = new List<string>();
        prompts.Add("Think of a time when you stood up for someone else.");
        prompts.Add("Think of a time when you did something really difficult.");
        prompts.Add("Think of a time when you helped someone in need.");
        prompts.Add("Think of a time when you did something truly selfless.");
        
        Random prompt = new Random();
        int x = prompt.Next(prompts.Count());
        return prompts[x];
    }
    private void questions(){
        Console.WriteLine(RandomePrompt());
        int timePerQuestion = _time / 9;
        Console.WriteLine("Why was this experience meaningful to you?");
        animation(timePerQuestion);
        Console.WriteLine("Have you ever done anything like this before?");
        animation(timePerQuestion);
        Console.WriteLine("How did you get started?");
        animation(timePerQuestion);
        Console.WriteLine("How did you feel when it was complete?");
        animation(timePerQuestion);
        Console.WriteLine("What made this time different than other times when you were not as successful?");
        animation(timePerQuestion);
        Console.WriteLine("What is your favorite thing about this experience?");
        animation(timePerQuestion);
        Console.WriteLine("What could you learn from this experience that applies to other situations?");
        animation(timePerQuestion);
        Console.WriteLine("What did you learn about yourself through this experience?");
        animation(timePerQuestion);
        Console.WriteLine("How can you keep this experience in mind in the future?");
        animation(timePerQuestion);
    }

    public void activity(){
        StartMsg();
        questions();
        EndMsg();

    }
}