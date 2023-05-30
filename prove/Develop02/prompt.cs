public class Prompt
{
    

    List<string> _prompts;
    static Random rand = new Random();


    public string GetRandomPrompt()
    {
        List<string> prompts = new List<string> {"Who was the most interesting person i talked to today?", "What is the best part of the day?", "How did i see the hand of the lord today?", "What was the strongest emotion i felt today", "If i had one thing I could do over today i would:"};
        int r = rand.Next(prompts.Count);
        return ($"{prompts[r]}");
    }

    
}