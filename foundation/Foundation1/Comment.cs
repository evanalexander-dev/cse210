public class Comment
{
    private readonly string _author;
    private readonly string _content;

    public Comment(string author, string content)
    {
        _author = author;
        _content = content;
    }

    public void Display()
    {
        Console.WriteLine($"{_author}: {_content}");
    }
}