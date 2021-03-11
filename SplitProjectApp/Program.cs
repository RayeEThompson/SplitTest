using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Splitio.Services.Client.Interfaces;
using Splitio.Services.Client.Classes;
using Newtonsoft.Json;

namespace SplitProjectApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();

            var config = new ConfigurationOptions();

            var factory = new SplitFactory("4u0ej9v4crbmbqsofb475rcl63jkmlki8hsh", config);
            var splitClient = factory.Client();
            try
            {
                splitClient.BlockUntilReady(10000);
            }
            catch (Exception ex)
            {
                // log & handle
                Console.WriteLine(ex);
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
