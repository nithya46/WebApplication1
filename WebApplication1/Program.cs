using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            Console.WriteLine("This is C# first trail - second time");
            Console.WriteLine("This is C# first trail - second timeeeeeeweryui");
            Console.WriteLine("This is C# 567890-trail - second timeeeeeeweryui");
            Console.WriteLine("0-trail - second timeeeeeeweryui");
            Console.WriteLine("T67890-trail - second timeeeeeeweryui");

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
