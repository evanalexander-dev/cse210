public class EternalGoal(string name, string description, int points) : Goal(name, description, points)
{
    public override int RecordEvent()
    {
        return _points;
    }

    protected override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{name},{description},{points}";
    }
}