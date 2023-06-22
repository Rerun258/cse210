public class Points{
    private int points;
    private int _prioraty1 = 5;
    private int _prioraty2 = 10;
    private int _prioraty3 = 50;

    public Points(int prioraty){
        if (prioraty == 1){
            points = points + _prioraty1;
        }
        else if (prioraty == 2){
            points = points + _prioraty2;
        }
        else if (prioraty == 3){
            points = points + _prioraty2;
        }
    }


    public void display(){
        Console.WriteLine($"You Have {points} points");
    }


}



