public class Scripture{
    // Refference john = new Refference("john", "1", "1", "2");
    private string _text = "";
    private Word word;

    public Scripture(string book, string chap, string start_verse, string end_verse, string text){
        Refference test = new Refference(book, chap, start_verse, end_verse);
        _text = text;
        Word word = new Word(_text);

    }

    public void menu(){
        word.display2();
        while (true){
            Console.WriteLine("1 refresh scriptre");
            Console.WriteLine("2 memorize scripture");
            Console.WriteLine("3 quit");
            string answer = Console.ReadLine();

            if (answer == "1"){
                word.refresh();
                Console.Clear();
                // word.display2();
            }
            else if (answer == "2"){
                bool check = true;
                if (check == true){
                    check = word.remove_words();
                }
                else if (check == false){
                    break;
                }
                Console.Clear();
                // word.display2();

            }
            else if (answer == "3"){
                break;
            }
        }
    }
}



