public class Goal{
    protected string _goalName;
    protected string _goalDiscription;
    protected int _pointsIfDone;
    protected bool _compleated = false;
    protected string _goaltype = "Goal";


    // public virtual int CalcPoints(){
    //     return _pointsIfDone;
    // }

    public void SetGoalType(string goaltype){
        _goaltype = goaltype;
    }
    public string GetGoalType()
    {
        return _goaltype;
    }


    public virtual void SetGoal(){
        Console.Write("What is the name of the Goal: ");
        string a = Console.ReadLine();
        SetName(a);
        Console.Write("Discribe the Goal: ");
        string b = Console.ReadLine();
        SetDiscription(b);
        Console.Write("How many points will it be: ");
        string c = Console.ReadLine();
        SetPointsIfDone(int.Parse(c));
    }

    public virtual int CompleateGoal(){
        Console.WriteLine($"You compleated this Goal you Got {_pointsIfDone} ");
        SetIfCompleated(true);
        return _pointsIfDone;
    }

//getters and setters



    public string GetDiscription(){
        return _goalDiscription;
    }
    public void SetDiscription(string discription){
        _goalDiscription = discription;
    }
    public string GetName(){
        return _goalName;
    }
    public void SetName(string name){
        _goalName = name;
    }
    public int GetPointsIfDone(){
        return _pointsIfDone;
    }
    public void SetPointsIfDone(int points){
        _pointsIfDone = points;
    }
    public bool getIfCompleated(){
        return _compleated;
    }
    public void SetIfCompleated(bool compleated){
        _compleated = compleated;
    }

    public virtual void displaygoal(){
        Console.WriteLine($"Name of Goal: {_goalName}\nDiscription: {_goalDiscription}\n Compleated: {_compleated}\nPoint: {_pointsIfDone}");
    }





}
