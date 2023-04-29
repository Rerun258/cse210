using System;

class Program
{
    static void Main(string[] args)
    {
        int x = 0;
        List<int> numbers = new List<int>();
        int max = 0;
        int count = 0;
        int sum = 0;


        do 
        {
            Console.Write("Please enter a number: ");
            string answer = Console.ReadLine();

            x = int.Parse(answer);
            numbers.Add(x);
            count = count + 1;
        }while (x != 0);

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
            sum = sum + numbers[i];

            
        }
        float average = (sum / count);

        Console.WriteLine($"The Average was: {average}");
        Console.WriteLine($"the Max was {max}");
        Console.WriteLine($"the Sum is {sum}");
        

    }
}