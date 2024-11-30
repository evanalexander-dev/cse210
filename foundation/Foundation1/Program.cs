class Program
{
    static void Main(string[] args)
    {
        var video1 = new Video("Test Video 1", "A Cow", 302);
        video1.AddComment(new Comment("The Pig", "Nice video!"));
        video1.AddComment(new Comment("Quacking Duck", "awesome"));
        video1.AddComment(new Comment("Fish", "Blub Blub"));
        video1.Display();

        var video2 = new Video("Test Video 2", "The Pig", 153);
        video2.AddComment(new Comment("A cow", "You rock"));
        video2.AddComment(new Comment("Quacking Duck", "cool video"));
        video2.AddComment(new Comment("Fish", "Blub Blub"));
        video2.Display();

        var video3 = new Video("Test Video 3", "Quacking Duck", 361);
        video3.AddComment(new Comment("A cow", "Awesome video"));
        video3.AddComment(new Comment("The Pig", "amazing"));
        video3.AddComment(new Comment("Fish", "Blub Blub"));
        video3.Display();

        var video4 = new Video("Test Video 4", "Fish", 162);
        video4.AddComment(new Comment("A cow", "Swim on"));
        video4.AddComment(new Comment("The Pig", "Keep swimming"));
        video4.AddComment(new Comment("Quacking Duck", "Share the food!"));
        video4.Display();
    }
}