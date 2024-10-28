public class Cycling : Activity
{
    private double speed; // in mph or kph

    public Cycling(DateTime date, int duration, double speed)
        : base(date, duration)
    {
        this.speed = speed;
    }

    public override double GetDistance() => (speed * GetDuration()) / 60;
    public override double GetSpeed() => speed;
    public override double GetPace() => 60 / speed;

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Cycling - Speed: {speed} mph, Pace: {GetPace():0.0} min per mile";
    }
}
