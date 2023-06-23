public class Assignment{
    private string _studentName = "John";
    private string _topic;

    public string getSummery(){
        return $"Student Name: {_studentName}   Topic: {_topic}";
    }

    public string getName(){
        return _studentName;
    }

    public void setTopic(string topic){
        _topic = topic;
    }
    public string getTopic(){
        return _topic;
    }

}