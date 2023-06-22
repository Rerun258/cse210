public class Word{
    private string _scripture;
    private List<string> _words;
    private List<string> _removedWords;

    private int rando(){

        Random rand = new Random();
        int ran = rand.Next(_words.Count);
        return ran;
    }

    public Word(string scripture){
        _scripture = scripture;
        refresh();
    }

    public void refresh(){
        _words = _scripture.Split(" ").ToList();
    }

    private bool check(){
        foreach (string word in _words){
            if (word != "__________"){
                return true;
            }
        }
        return false;
    }

    private bool remove_word(){
        bool checke = check();
        if (checke == true){
            int ran;
            do {
                ran = rando();
            }while (_words[ran] == "__________");

            _removedWords.Add(_words[ran]);
            _words[ran] = "__________";
            return true;
        }
        else{
            Console.WriteLine("You did it!");
            return false;
        }
    }

    public bool remove_words(){
        bool r = true;
        for (int i = 0; i < 10; i++){
           r =  remove_word();
        }
        Console.Clear();
        return r;
    }

    public void display2(){
        foreach (string thing in _words){
            Console.WriteLine(thing);
        }
    }

    // public void display(){
    //      (_words){
    //         Console.WriteLine("hello");
    //     }
    } 
