public abstract class Goal(string name, string description, int points)
{
    protected string _shortName = name;
    protected string _description = description;
    protected int _points = points;

    public string GetName()
    {
        return _shortName;
    }

    public abstract int RecordEvent();
    protected abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        var checkbox = IsComplete() ? "[X]" : "[ ]";
        return $"{checkbox} {_shortName} ({_description})";
    }
    public abstract string GetStringRepresentation();


}