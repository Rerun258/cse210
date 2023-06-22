public class Scripture{
    // Refference john = new Refference("john", "1", "1", "2");
    private string _text = "";
    private Word word;

    public Scripture(string book, string chap, string start_verse, string end_verse, string text){

        Refference test = new Refference(book, chap, start_verse, end_verse);
        _text = text;
        word = new Word(_text);

    }

    public void menu(){
        bool check = true;
        while (check){
            Console.WriteLine("1 refresh scriptre");
            Console.WriteLine("2 memorize scripture");
            Console.WriteLine("3 quit");
            word.display2();
            string answer = Console.ReadLine();

            if (answer == "1"){
                word.refresh();
                Console.Clear();
                //word.display2();
            }
            else if (answer == "2"){
                if (check == true){
                    Console.Clear();
                    check = word.remove_words();
                }
                //Console.Clear();
                // word.display2();
            }
            else if (answer == "3"){
                break;
            }
        }
    }
}



