public class Activity{
    List<string> prompt = new List<string> {"List as many good things as you can think of that is apart of your life:", "list all that you can that is positive in your life", "Prompt 2", "Prompt 3"};
    

    public void callPrompt(){
        Random rprompt = new Random();
        int rnum = rprompt.Next(prompt.Count());
        Console.WriteLine(prompt[rnum]);
    }

}