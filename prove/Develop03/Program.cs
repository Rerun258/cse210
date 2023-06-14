using System;

class Program
{
    static void Main(string[] args)
    {
        Word test = new Word("I, Nephi, having been born of goodly parents, therefore I was taught somewhat in all the learning of my father; and having seen many afflictions in the course of my days, nevertheless, having been highly favored of the Lord in all my days; yea, having had a great knowledge of the goodness and the mysteries of God, therefore I make a record of my proceedings in my days.");

        string menu(){
            Console.WriteLine("1 new scripture");
            Console.WriteLine("2 add scripture");
            Console.WriteLine("3 memorize scripture");
            Console.WriteLine("4 refresh scripture");
            Console.WriteLine("5 quit");
            string answer = Console.ReadLine();
            return answer;
        }

        while (true){
            string answer = menu();
            if (answer == "1"){
                
            }
        }
       // test.displayList();
    }
}