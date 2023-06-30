public class Video{

    private string _title;
    private string _author;
    private int _length;
    private List<Comments> _comments = new List<Comments>();

    public Video(string title, string author, int length, string commentName, string commentText){
        _title = title;
        _author =author;
        _length = length;
        Comments coment = new Comments(commentName, commentText);
        _comments.Add(coment);
    }
        public void addcomment(){
        
    }
    




}
