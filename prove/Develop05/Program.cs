using System;
class Program
{
    static void Main(string[] args)
    {
        Menu program = new Menu();
    

        List<Goal> goals = new List<Goal>();
        while (true){
            string answer = program.PullMenu();

            if (answer == "1" || answer == "2" || answer == "3"){
                goals.Add(program.makeGoal(answer));
            }
            else if(answer == "4"){
                program.markGoalCompleated(goals);
            }
            else if (answer == "5"){
                program.DisplayGoals(goals);
            }
            else if (answer == "6"){
                break;
            }
            
        }




    
    }




}