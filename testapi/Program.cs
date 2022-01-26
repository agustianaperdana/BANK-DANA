
using MassTransit;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testapi.helper;

namespace testapi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "Notification";
            var bus = Bus.Factory.CreateUsingRabbitMq(cfg =>
            {
                cfg.Host(new Uri(RabbitMqConsts.RabbitMqRootUri), h =>
                {
                    h.Username(RabbitMqConsts.UserName);
                    h.Password(RabbitMqConsts.Password);
                });
                cfg.ReceiveEndpoint("todoQueue", ep =>
                {
                    ep.PrefetchCount = 16;
                //    ep.UseMessageRetry(r => r.Interval(2, 100));
                   // ep.Consumer<TestConsumerNotification>();
                });

            });

            bus.StartAsync();
            Console.WriteLine("Listening for Todo registered events.. Press enter to exit");
            Console.ReadLine();
            bus.StopAsync();

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

