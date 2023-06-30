public class Listing : Activity
{
    private List<string> response= new List<string>();
    public Listing(string name) : base(name)
    {
            _discription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _activityName = "Listing";
    }

    private string RandomePrompt(){
        List<string> prompts = new List<string>();
        prompts.Add("Who are people that you appreciate?");
        prompts.Add("What are personal strengths of yours?");
        prompts.Add("Who are people that you have helped this week?");
        prompts.Add("When have you felt the Holy Ghost this month?");
        prompts.Add("Who are some of your personal heroes?");
        
        Random prompt = new Random();
        int x = prompt.Next(prompts.Count());
        return prompts[x];
    }

    private void displayNumInList(List<string> x){
        Console.Write( $" You listed {x.Count()} items");

    }

    public void activity(){
        StartMsg();
        Console.WriteLine(RandomePrompt());
        DateTime starttime = DateTime.Now;
        DateTime endTime = starttime.AddSeconds(_time);
        while (DateTime.Now <= endTime)
        {
            Console.Write(": ");
            string x = Console.ReadLine();
            response.Add(x);
        }
        displayNumInList(response);
        EndMsg();



    }
}