public class ChecklistGoal(string name, string description, int points, int target, int bonus, int completed=0) : Goal(name, description, points)
{
    private int _amountCompleted = completed;

    public override int RecordEvent()
    {
        var pointsToAdd = _points;

        _amountCompleted++;
        if (_amountCompleted >= target)
        {
            pointsToAdd += bonus;
        }

        return pointsToAdd;
    }

    protected override bool IsComplete()
    {
        return _amountCompleted >= target;
    }

    public override string GetDetailsString()
    {
        var checkbox = IsComplete() ? "[X]" : "[ ]";
        return $"{checkbox} {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{name},{description},{points},{target},{bonus},{_amountCompleted}";
    }
}