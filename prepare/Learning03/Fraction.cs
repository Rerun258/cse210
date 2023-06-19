public class Fraction{
    private int _top=1;
    private int _bottom=1;


    public Fraction(){

    }

    public Fraction(int top){
        _top = top;
    }

    public Fraction(int top, int bottom){
        _top = top;
        _bottom = bottom;
    }


    public void getTop(){
        Console.Write("Numerator");
        string answer = Console.ReadLine();
        int intanswer = int.Parse(answer);
        _top = intanswer;
    }
    public void getbottom(){
        Console.Write("denominator");
        string answer = Console.ReadLine();
        int intanswer = int.Parse(answer);
        _bottom = intanswer;
    }
}