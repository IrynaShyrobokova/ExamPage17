using ExamPage17;

public class EventListener
{
    private readonly Counter _counter;

    public EventListener(Counter counter)
    {
        _counter = counter;

        _counter.ThresholdReached += HandleThresholdReached;
    }

    private void HandleThresholdReached(object sender, ThresholdReachedEventArgs e)
    {
        Console.WriteLine($"Threshold of {e.Threshold} was reached at {e.TimeReached}.");
    }
}
