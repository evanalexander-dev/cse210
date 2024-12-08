public class ListingActivity() : Activity(
    "Listing",
    "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
    )
{
    private int _count;
    private readonly List<string> _prompts = [
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    ];

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($" --- {GetRandomPrompt()} --- ");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        _count = GetListFromUser().Count;
        Console.WriteLine($"You listed {_count} items!");

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        return _prompts[new Random().Next(_prompts.Count)];
    }

    private List<string> GetListFromUser()
    {
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        List<string> responses = [];

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            responses.Add(Console.ReadLine());
        }

        return responses;
    }
}