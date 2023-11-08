namespace ThreadingMinor;

public class BasicThreads
{
    public static void Go()
    {
        var t1 = new Thread(() =>
        {
            for (int i = 0; i < 10000; i++)
            {
                Console.Write(".");
            }
        });
        var t2 = new Thread(() =>
        {
            for (int i = 0; i < 10000; i++)
            {
                Console.Write("*");
            }
        });
        t1.Priority = ThreadPriority.Highest;
        t2.Priority = ThreadPriority.Lowest;
        t1.Start();
        t2.Start();

        Console.WriteLine("even wachten tot ze klaar zijn");
        t1.Join();
        t2.Join();
        Console.WriteLine("threads zijn klaar!");
    }
}