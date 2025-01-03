using Microsoft.AspNetCore;

namespace ClaimEasy
{
    public static class Program
    {
        public static IConfiguration configuration { get; } = new ConfigurationBuilder().Build();
        public static void Main(string[] args)
        {
            
            CreateBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        }
    }
}