public class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int duration, int laps)
        : base(date, duration)
    {
        this.laps = laps;
    }

    public override double GetDistance() => (laps * 50) / 1000 * 0.62; // distance in miles
    public override double GetSpeed() => (GetDistance() / GetDuration()) * 60;
    public override double GetPace() => GetDuration() / GetDistance();

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Swimming - Laps: {laps}, Distance: {GetDistance():0.00} miles, Speed: {GetSpeed():0.00} mph, Pace: {GetPace():0.0} min per mile";
    }
}
