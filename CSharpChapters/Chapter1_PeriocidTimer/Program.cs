class Program
{
    static int secs = 0, mins = 0;
    static async Task Main(string[] args)
    {
        Console.WriteLine("secs: 00");
        Console.WriteLine("mins: 00");

        var secondTicks = SecondTicker();
        var minuteTicks = MinuteTicker();
        await Task.WhenAll(secondTicks, minuteTicks);
    }

    static async Task SecondTicker()
    {
        PeriodicTimer secondTimer = new PeriodicTimer(new TimeSpan(0, 0, 1));

        while (await secondTimer.WaitForNextTickAsync())
        {
            secs++;
            Console.SetCursorPosition(0, 0);
            Console.Write($"secs: {secs.ToString("00")}");
        }
    }

    static async Task MinuteTicker()
    {
        PeriodicTimer minuteTimer = new PeriodicTimer(new TimeSpan(0, 1, 0));

        while (await minuteTimer.WaitForNextTickAsync())
        {
            mins++;
            secs = 0;
            Console.SetCursorPosition(0, 1);
            Console.Write($"mins: {mins.ToString("00")}");
        }
    }
}