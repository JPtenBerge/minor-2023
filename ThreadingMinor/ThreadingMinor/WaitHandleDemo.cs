namespace ThreadingMinor;

public class WaitHandleDemo
{
    private static ManualResetEventSlim resetEvent = new ();
    
    public static void Go()
    {
        for (int i = 0; i < 5; i++)
        {
            var t = new Thread(() =>
            {
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} setten");
                Thread.Sleep(8000);
                Console.WriteLine("ik kom nu pas aan");
                resetEvent.Wait();
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} na de wait");
            });
            t.Start();
        }

        new Thread(() =>
        {
            Thread.Sleep(3000);
            Console.WriteLine("timeout voorbij");
            resetEvent.Set();
        }).Start();
        
        // Console.WriteLine("Druk eens op enter");
        // Console.ReadLine();
        // resetEvent.Set();
    }
}