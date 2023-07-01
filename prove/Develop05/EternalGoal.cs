public class EternalGoal: Goal{

    public EternalGoal(){
        SetGoalType("EternalGoal");
    }

    // public override int CalcPoints()
    // {
    //     return _pointsIfDone;
    // }
    public override int CompleateGoal()
    {
        Console.WriteLine($"You compleated this Goal you Got {_pointsIfDone}");
        return _pointsIfDone;
    }

}