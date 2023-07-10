public class Video{

    private string _title;
    private string _author;
    private int _length;
    private List<Comments> _comments = new List<Comments>();

    public Video(string title, string author, int length){
        _title = title;
        _author =author;
        _length = length;


    }

    // num of comments
    // 
        public void addcomment(string commentName, string commentText){
        Comments coment = new Comments(commentName, commentText);
        _comments.Add(coment);
    }

        public void displayNumComments(){
            int count = 0;
            foreach (Comments comment in _comments){
                count++;
            }
            Console.WriteLine($"You have {count} comments");
        }
    
        public void display(){
            Console.WriteLine($"Video name: {_title}");
            Console.WriteLine($"Video Author: {_author}");
            Console.WriteLine($"Video Length: {_length}");
            displayNumComments();
            Console.WriteLine();
            Console.WriteLine("Here Are the Comments");
            foreach (Comments coment in _comments){
                coment.display();
            }
        }




}
