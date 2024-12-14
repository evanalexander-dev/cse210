public class Swimming(string date, int minutes, int laps) : Activity("Swimming", date, minutes)
{
    protected override float GetDistance()
    {
        return laps * 50 / (float)1000;
    }

    protected override float GetSpeed()
    {
        return (GetDistance() / _minutes) * 60;
    }
}