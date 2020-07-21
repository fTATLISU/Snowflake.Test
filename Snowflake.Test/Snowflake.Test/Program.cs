using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Snowflake.Test.Tasks;

namespace Snowflake.Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SnowflakeTasks.CreateSnowflakeTasks();
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    SnowflakeSetting snowflakeSetting = new SnowflakeSetting(
                        minimumUserCount: 10,
                        maximumUserCount: 100,
                        delayAfterBulkOperation: 1000);

                    services.AddSnowflake(snowflakeSetting);
                });
    }
}