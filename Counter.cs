using ExamPage17;

public class Counter
{
    private int _count;
    private int _threshold;

    public delegate void ThresholdReachedEventHandler(object sender, ThresholdReachedEventArgs e);

    public event ThresholdReachedEventHandler ThresholdReached;

    public Counter(int threshold)
    {
        _threshold = threshold;
    }

    public void Add(int value)
    {
        _count += value;

        if (_count >= _threshold)
        {
            OnThresholdReached(new ThresholdReachedEventArgs(_threshold, DateTime.Now));
        }
    }

    protected virtual void OnThresholdReached(ThresholdReachedEventArgs e)
    {
        ThresholdReached?.Invoke(this, e);
    }
}