public class Prompt
{
    

    // List<string> _prompts;
    static Random rand = new Random();


    public string GetRandomPrompt()
    {
        List<string> prompts = new List<string> {"Who was the most interesting person i talked to today?", "What is the best part of the day?", "How did i see the hand of the lord today?", "What was the strongest emotion i felt today?", "what would i do differently today?"};
        int r = rand.Next(prompts.Count);
        return ($"{prompts[r]}");
    }

    
}