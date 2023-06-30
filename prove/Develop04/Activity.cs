public class Activity
{
    protected int _time;
    protected string _activityName ;
    protected string _discription ;
    private string _name;
    

public Activity(string name){
    _name = name;
    
}
// methods
    public void EndMsg(){
        Console.WriteLine($"Good Job {_name}");
        animation(5);
        Console.WriteLine($"You Took {_time} seconds");
        animation(5);
    }

    public void StartMsg(){

        Console.Write($"You chose {_activityName} \nDiscription: {_discription}\nHow Long Do You Want To Take: ");
        string answer = Console.ReadLine();
        int dtime = int.Parse(answer);
        _time = dtime;
        Console.WriteLine("Prepare to begin");
        animation(5);
    }


    protected void animation(int atime)
    {
        DateTime starttime = DateTime.Now;
        DateTime endTime = starttime.AddSeconds(atime);
        int i = 0;
        while (DateTime.Now <= endTime)
        {
            List<string> spinner = new List<string> { "|", "/", "-", "\\" };
            string s = spinner[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;
            if (i == 4)
            {
                i = 0;
            }
        }
    }



//getters and setters
    public int GetTime()
    {
        return _time;
    }
    public void SetTime(int time)
    {
        _time = time;
    }
    // public string GetStartMsg()
    // {
    //     return _startMessage;
    // }
    // public void SetStartMsg(string startMessage)
    // {
    //     _startMessage = startMessage;
    // }
    // public string GetEndMsg()
    // {
    //     return _endMessage;
    // }
    // public void SetEndMsg(string endMsg)
    // {
    //     _endMessage = endMsg;
    // }
    public string GetActivityName()
    {
        return _activityName;
    }
    public void SetActivityName(string activityName)
    {
        _activityName = activityName;
    }
    public string GetDiscription()
    {
        return _discription;
    }
    public void SetDiscrption(string discription)
    {
        _discription = discription;
    }
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }




}