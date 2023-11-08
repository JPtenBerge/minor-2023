namespace ThreadingMinor;

public class SemaphoreDemo
{
    public static SemaphoreSlim semaphore = new(1);
    public static void Go()
    {
        for (int i = 0; i < 10; i++)
        {
            var t = new Thread(() =>
            {
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} is bij de club");
                semaphore.Wait();
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} ik mag naar binnen!");
                Thread.Sleep(new Random().Next(1, 10) * 1000);
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} ik ga naar huis");
                semaphore.Release();
            });
            t.Start();
        }
    }
}