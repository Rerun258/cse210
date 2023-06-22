public class Word{
    private string _scripture;
    private List<string> _words;
    private List<string> _removedWords;

    private const string underscores = "__________";

    private int rando(){

        Random rand = new Random();
        int ran = rand.Next(_words.Count);
        return ran;
    }

    public Word(string scripture){
        _scripture = scripture;
        _words = _scripture.Split(" ").ToList();
        _removedWords = new List<string>();
        // display2();
    }

    public void refresh(){
        _words = _scripture.Split(" ").ToList();
    }

    private bool check(){
        foreach (string word in _words){
            if (word != underscores){
                // Console.WriteLine($"this is the problem word: {word}");
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
            } while (_words[ran] == underscores);

            _removedWords.Add(_words[ran]);
            _words[ran] = underscores;
            return true;
        }
        else{
            
            Console.WriteLine("You did it!");
            return false;
        }
    }

    public bool remove_words(){
        bool r = true;
        for (int i = 0; i < 5; i++){
           r =  remove_word();
           if (r == false){
            return r;
           }
        }
        //Console.Clear();
        return r;
    }

    public void display2(){
        foreach (string thing in _words){
            // Console.WriteLine(thing);
            Console.Write($"{thing} ");
        }
        Console.WriteLine();
    }

    // public void display(){
    //      (_words){
    //         Console.WriteLine("hello");
    //     }
    } 
