// string book
public class Refference{

    string _startBook = "";
    string _startChapter;
    string _startVerse;
    string _endVerse;


    public Refference(string startBook, string startChapter, string startVerse, string endVerse ){

        _startBook = startBook ;
        _startChapter = startChapter ;
        _startVerse = startVerse ;
        _endVerse =  endVerse;

    }



    // display
    public void display()
    {
        Console.WriteLine($"{_startBook} {_startChapter}: {_startVerse}-{_endVerse} ");
    }

    public string callreff(){
        return $"{_startBook} {_startChapter}: {_startVerse}-{_endVerse}";
    }
}

