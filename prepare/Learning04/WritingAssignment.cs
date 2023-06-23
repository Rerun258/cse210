public class WritingAssignment : Assignment{
    private string _title = "ww2";
    

    public string getInformation(){
        base.setTopic("name close victoms of holocaust.");
        return $"Name: {base.getName()} Title: {_title} Topic {base.getTopic()}";

    }

}