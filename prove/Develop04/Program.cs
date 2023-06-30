using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your Name");
        string name = Console.ReadLine();

        while (true)
        {
            Console.WriteLine("What do you Want to do?");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Quit");

            string answer = Console.ReadLine();
            if (answer == "1"){
                Breathing breath1 = new Breathing(name);
                breath1.activity();
            }
            else if (answer == "2"){
                Reflection reflect1 = new Reflection(name);
                reflect1.activity();
            }
            else if (answer == "3"){
                Listing list1 = new Listing(name);
                list1.activity();
            }
            else if (answer == "4"){
                break;
            }
        }
    }



        // Console.WriteLine("");
        // Console.WriteLine("");
        // Console.WriteLine("");
        // Console.WriteLine("");
        // Console.WriteLine("");
}
