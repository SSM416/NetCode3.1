using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace gp_admin_Code
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseServiceProviderFactory(new AutofacServiceProviderFactory())
                .ConfigureLogging(p =>
                {
                    var path = System.IO.Directory.GetCurrentDirectory();
                    p.AddFilter("System", LogLevel.Warning);
                    p.AddFilter("Microsoft", LogLevel.Warning);
                    p.AddFilter("System", LogLevel.Information);
                    p.AddFilter("Microsoft", LogLevel.Information);
                    p.AddLog4Net($"{path}/log4net.config");//ÅäÖÃÎÄ¼þ
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
