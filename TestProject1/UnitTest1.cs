using Microsoft.AspNetCore.Mvc.Testing;
using WebApplication7;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var factory = new WebApplicationFactory<Program>();
            // Initiate the application.
            _ = factory.Server;

            // Shut down the application.
            factory.Dispose();

            Assert.Equal(1, MyService.StartedTimes);
            Assert.Equal(1, MyService.StoppedTimes);
        }
    }
}