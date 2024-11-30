public class Video
{
    private readonly string _title;
    private readonly string _author;
    private readonly int _length;
    private readonly List<Comment> _comments = [];

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public int NumberOfComments()
    {
        return _comments.Count;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void Display()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length / 60}:{_length % 60:D2} ({_length}s)");
        Console.WriteLine($"Comments: {NumberOfComments()}");
        _comments.ForEach(comment => comment.Display());
        Console.WriteLine("----------");
    }
}