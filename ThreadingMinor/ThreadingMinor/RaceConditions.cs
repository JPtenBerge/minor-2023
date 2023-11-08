namespace ThreadingMinor;

public class RaceConditions
{
    private static object lockObj = new { };

    public static int s_getalletje = 0;

    public static void Go()
    {
        var t1 = new Thread(() =>
        {
            for (int i = 0; i < 1_000_000_000; i++)
            {
                try
                {
                    Monitor.Enter(lockObj);
                    s_getalletje++;
                }
                finally
                {
                    Monitor.Exit(lockObj);
                }
            }
        });
        var t2 = new Thread(() =>
        {
            for (int i = 0; i < 1_000_000_000; i++)
            {
                lock (lockObj)
                {
                    s_getalletje++;
                }
            }
        });
        t1.Start();
        t2.Start();
        t1.Join();
        t2.Join();
        Console.WriteLine($"Getalletje: {s_getalletje}");
    }
}