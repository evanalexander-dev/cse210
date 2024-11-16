public class PromptGenerator
{
    private readonly List<string> _prompts = [
        "What was the most important thing I learned today?",
        "What was the most beautiful thing I saw today?",
        "What small moment made me feel grateful today?",
        "How did I practice patience today?",
        "If today were a chapter in my life story, what would its title be?"
    ];

    public string SelectPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}