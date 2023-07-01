public class Menu{
    public int _points = 0;


    public string PullMenu()
    {
        Console.WriteLine("What Do You Want to Do?");
        Console.WriteLine("1. Make general Goal");
        Console.WriteLine("2. Make Eternal Goal");
        Console.WriteLine("3. Make Checklist Goal");
        Console.WriteLine("4. Mark Goal As compleated");
        Console.WriteLine("5. Display Goals");
        Console.WriteLine("6. Quit");
        string answer = Console.ReadLine();
        return answer;
        
    }

    public void markGoalCompleated(List<Goal> Goals){
        Console.WriteLine("What Goal do you Want to Mark As Compleat?");
        int number = 1;
        foreach (Goal element in Goals){
            Console.WriteLine($"{number}. {element.GetName()}");
            number++;
        }
        int answer = int.Parse(Console.ReadLine());
        Goal completgoal = Goals[answer-1];
        _points += completgoal.CompleateGoal();
    }

    public Goal makeGoal(string menuAnswer){
        if (menuAnswer == "1"){
            Goal normalgoal = new Goal();
            normalgoal.SetGoal();
            return normalgoal;
        }
        else if (menuAnswer == "2"){
            EternalGoal eternal = new EternalGoal();
            eternal.SetGoal();
            return eternal;
        }
        else if (menuAnswer == "3"){
            ChecklistGoal check = new ChecklistGoal();
            check.SetGoal();
            return check;
        }
        else{
            return null;
        }
    }
    public void DisplayGoals(List<Goal> Goals){
        Console.WriteLine($"You Have {_points} points");
        int number = 1;
        foreach (Goal element in Goals){
            Console.WriteLine($"{number}. {element.GetName()}");
            number++;
        }
        Console.Write("What goal do you want to display:");
        int answer = int.Parse(Console.ReadLine());
        Goal displaygoal = Goals[answer-1];
        displaygoal.displaygoal();
        }
    public Goal CreateGoal(List<string> parts){

        if (parts[0] == "Goal" ){
            Goal newgoal = new Goal();
            newgoal.SetName(parts[1]);
            newgoal.SetDiscription(parts[2]);
            newgoal.SetPointsIfDone(int.Parse(parts[3]));
            newgoal.SetIfCompleated(bool.Parse(parts[4]));
            newgoal.SetGoalType(parts[0]);
            return newgoal;
        }
        else if (parts[0] == "ChecklistGoal"){
            ChecklistGoal newgoal = new ChecklistGoal();
            newgoal.SetName(parts[1]);
            newgoal.SetDiscription(parts[2]);
            newgoal.SetPointsIfDone(int.Parse(parts[3]));
            newgoal.SetIfCompleated(bool.Parse(parts[4]));
            newgoal.SetGoalType(parts[0]);
            newgoal.SetHowManyToCompleate(parts[5]);
            newgoal.SetNumberCompleted(parts[6]);
            // newgoal.SetBonus(parts[7]);
            return newgoal;
        }
        else if (parts[0] == "EternalGoal"){
            EternalGoal newgoal = new EternalGoal();
            newgoal.SetName(parts[1]);
            newgoal.SetDiscription(parts[2]);
            newgoal.SetPointsIfDone(int.Parse(parts[3]));
            newgoal.SetIfCompleated(bool.Parse(parts[4]));
            newgoal.SetGoalType(parts[0]);
            return newgoal;
        }
        else {
            return null;
        }
    }
    public virtual void read(){
        string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");


        }
    }
    public virtual void write(Goal write){
        if (write.GetGoalType() == "Goal"){
            string filename = "mygoals.txt";
            string writestring = $"{write.GetGoalType()}, {write.GetName()}, {write.GetDiscription()}, {write.GetPointsIfDone()}, {write.getIfCompleated()} ";

            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                // You can add text to the file with the WriteLine method
                outputFile.WriteLine(writestring);
            }
        }
        else if (write.GetGoalType() == "EternalGoal"){
            string filename = "mygoals.txt";
            string writestring = $"{write.GetGoalType()}, {write.GetName()}, {write.GetDiscription()}, {write.GetPointsIfDone()}, {write.getIfCompleated()} ";

            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                // You can add text to the file with the WriteLine method
                outputFile.WriteLine(writestring);
            }
        }
    }
}
