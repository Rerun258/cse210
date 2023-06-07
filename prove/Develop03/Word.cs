public class Word{
    public string _scripture;
    public List<string> _words;
    public List<string> _removedWords;



    public Word(string scripture){
        _scripture = scripture;
        _words = _scripture.Split(" ").ToList();
    }




// Test function
    public void displayList(){
        foreach (string word in _words){
                  Console.WriteLine(word);
        }
  
    }

    
}