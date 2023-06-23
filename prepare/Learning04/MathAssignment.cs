public class MathAssignments : Assignment{
    private string _textbookSection = "pg. 2-3";
    private string _problems = "odds";
    

    public string getHomeworkList(){
        return $"Textbook Section: {_textbookSection}   Problems {_problems}";
    }

}