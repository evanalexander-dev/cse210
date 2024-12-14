public class Running(string date, int minutes, float distance) : Activity("Running", date, minutes)
{
    protected override float GetDistance()
    {
        return distance;
    }

    protected override float GetSpeed()
    {
        return (GetDistance() / _minutes) * 60;
    }
}