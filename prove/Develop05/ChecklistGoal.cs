public class ChecklistGoal: Goal{
    private int howManyToCompleat;
    private int howManyCompleated;
    private int bonus;
    // public override int CalcPoints(){
    //     return 5;
    // }

    public void SetNumberCompleted(string numberCompleated){
        howManyCompleated = int.Parse(numberCompleated);
    }
    // public void SetBonus(string _bonus){
    //     bonus = int.Parse(_bonus);
    // }

    public override void SetGoal()
    {
        base.SetGoal();
        Console.Write("How many times till the goal is compleated: ");
        string d = Console.ReadLine();
        howManyToCompleat = int.Parse(d);
        Console.Write("How many bonus Points: ");
        string e = Console.ReadLine();
        bonus = int.Parse(e);
        
    }
    public void SetHowManyToCompleate(string HowManuToCompleat){
        howManyToCompleat = int.Parse(HowManuToCompleat);
    }

    public override int CompleateGoal(){
        // int onebefore = howManyCompleated -1;
        if (howManyToCompleat - 1 == howManyCompleated){
            howManyCompleated = howManyCompleated + 1;
            Console.WriteLine($"Congragulations you have compleated your goal to {GetName()}\n You get {_pointsIfDone + bonus} points");
            SetIfCompleated(true);
            return _pointsIfDone + bonus;
        }

        else if(howManyToCompleat > howManyCompleated){
            howManyCompleated = howManyCompleated + 1;
            Console.WriteLine($"You have Compleated this goal {howManyCompleated} out of {howManyToCompleat} times Keep up the Good Work!\nYou Get {_pointsIfDone} points!");
            return _pointsIfDone;

        }
        else if (howManyToCompleat == howManyCompleated){
            Console.WriteLine($"You have already compleated this goal {howManyCompleated} out of {howManyToCompleat} times\n You Get 0 points");
            return 0;
        }
        else{
            Console.WriteLine("Something Went Wrong!!! you get 0 points");
            return 0;
        }
    }



    public override void displaygoal(){
    Console.WriteLine($"Name of Goal: {_goalName}\nDiscription: {_goalDiscription}\n Compleated: {howManyCompleated} out of {howManyToCompleat} times\nPoints each time: {_pointsIfDone} once Compleated: {bonus}");
    


    }}


