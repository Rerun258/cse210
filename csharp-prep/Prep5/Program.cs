using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayMessage()
        {
            Console.WriteLine("welcom to the program");
        }
        static string username()
        {
            Console.Write("What is your name: ");
            string answer = Console.ReadLine();
            return answer;
        }
        static int UserNumber()
        {
            Console.Write("what is your user number: ");
            string number = Console.ReadLine();
            int answer = int.Parse(number);
            return answer;
        }
        static int SquareNumber(int UserNumber)
        {
            int calc = UserNumber * UserNumber;
            return calc;
        }
        static void DisplayResult(string name, int SquaredNumber)
        {
            Console.WriteLine($"Your name is {name} And your number squared is {SquaredNumber}");
        }
        DisplayMessage();
        string x = username();
        int y = UserNumber();
        int z = SquareNumber (y);
        DisplayResult (x, z);


    }
}