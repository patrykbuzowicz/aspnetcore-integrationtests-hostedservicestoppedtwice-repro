namespace WebApplication7
{
    public class MyService : IHostedService
    {
        public static volatile int StartedTimes = 0;
        public static volatile int StoppedTimes = 0;

        public Task StartAsync(CancellationToken cancellationToken)
        {
            Interlocked.Increment(ref StartedTimes);
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            Interlocked.Increment(ref StoppedTimes);
            return Task.CompletedTask;
        }
    }
}