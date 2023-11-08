namespace ThreadingMinor;

public class ReaderWriterLockDemo
{
    private ReaderWriterLockSlim _lock = new();

    public int Tellertje { get; set; }
    
    // buffers
    public void Reader(object state)
    {
        var name = (string)state;
        Thread.Sleep(new Random().Next(2, 8) * 1000);
        _lock.EnterReadLock();
        Console.WriteLine($"[{name}]Teller: {Tellertje}");
        _lock.ExitReadLock();
    }

    public void Writer()
    {
        Thread.Sleep(new Random().Next(2, 8) * 1000);
        _lock.EnterWriteLock();
        Tellertje += 5;
        _lock.ExitWriteLock(); // try-finally
    }

    public static void Go()
    {
        var locky = new ReaderWriterLockDemo();

        for (int i = 0; i < 5; i++)
        {
            new Thread(locky.Reader).Start("Reader 1");
            new Thread(locky.Writer).Start();
            new Thread(locky.Reader).Start("Reader 2");
        }
    }
}