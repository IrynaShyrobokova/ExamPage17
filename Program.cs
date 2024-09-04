namespace ExamPage17
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter(10);
            EventListener listener = new EventListener(counter);

            counter.Add(5);  
            counter.Add(5);  
        }
    }
}
