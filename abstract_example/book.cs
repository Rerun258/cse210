public class book
{
    private string _author;
    private string _name;
    private int _timesRead = 0;
    private bool _available = false;

    public book(string name, string author)
    {
        _name = name;
        _author = author;
    }

    public void Display()
    {
        Console.WriteLine($"{_name} by {_author}");
        if(!_available)
        {
            Console.WriteLine("[Checked out]");
            Console.WriteLine("hey");
        }
    }

    public bool isAvailable()
    {
        return _available;
    }

}