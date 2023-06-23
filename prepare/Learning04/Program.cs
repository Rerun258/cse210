using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignments math = new MathAssignments();
        WritingAssignment writing = new WritingAssignment();
    
        Console.WriteLine(math.getHomeworkList());
        Console.WriteLine("");
        Console.WriteLine(writing.getInformation());
    }
}