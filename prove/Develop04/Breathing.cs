public class Breathing : Activity
{
    public Breathing(string name) : base(name)
    {
        _discription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing";
        _activityName = "Breathing";       
    }


public void breathing(){
    Console.WriteLine("Breath In");
    animation(5);
    Console.WriteLine("Breath Out");
    animation(5);
}

public void activity(){
    base.StartMsg();
        DateTime starttime = DateTime.Now;
        DateTime endTime = starttime.AddSeconds(_time);
        while (DateTime.Now <= endTime)
        {
            breathing();
        }
    base.EndMsg();
}

}