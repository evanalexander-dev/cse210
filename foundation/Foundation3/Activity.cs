public abstract class Activity(string name, string date, int minutes)
{
    protected int _minutes = minutes;

    protected abstract float GetDistance();
    protected abstract float GetSpeed();
    private float GetPace()
    {
        return _minutes / GetDistance();
    }

    public string GetSummary()
    {
        return $"{date} {name} ({_minutes} min): Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}