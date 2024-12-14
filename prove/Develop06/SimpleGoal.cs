public class SimpleGoal(string name, string description, int points, bool complete=false) : Goal(name, description, points)
{
    private bool _isComplete = complete;

    public override int RecordEvent()
    {
        _isComplete = true;
        return _points;
    }

    protected override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{name},{description},{points},{_isComplete}";
    }
}