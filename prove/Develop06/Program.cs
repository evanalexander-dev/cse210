// I added a confirmation to the load goals option, so you don't accidentally overwrite your existing goals.

class Program
{
    static void Main(string[] args)
    {
        new GoalManager().Start();
    }
}