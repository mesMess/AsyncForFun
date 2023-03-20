using MakingMessages.Interfaces;
using MakingMessages.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;

namespace MakingMessages
{
    class Program
    {
        // Function immediately below is equivalent
        //static Task Main2(string[] args)
        //{
        //    return CreateHostBuilder(args).Build().RunAsync();
        //}

        static Task Main(string[] args) =>
            CreateHostBuilder(args).Build().RunAsync();

        static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                            .ConfigureServices((_, services) =>
                            services.AddHostedService<Worker>()
                            .AddSingleton<IMessageWriter, ConsoleMessageWriter>()
                            .AddSingleton<IMessageWriter, LoggingMessageWriter>()
                            .AddSingleton<ExampleService>());
    }
}
