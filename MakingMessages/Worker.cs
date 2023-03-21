using MakingMessages.Interfaces;
using MakingMessages.Services;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MakingMessages
{
    public class Worker : BackgroundService
    {
        //private readonly MessageWriter _messageWriter = new MessageWriter();
        private readonly IMessageWriter messageWriter;
        private readonly ILogger<Worker> logger;

        public Worker(IMessageWriter messageWriter, ILogger<Worker> logger)
        {
            this.messageWriter = messageWriter;
            this.logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                this.messageWriter.Write($"Working running at: {DateTimeOffset.Now}");
                logger.LogInformation($"Working running at: {DateTimeOffset.Now}");
                await Task.Delay(2000, stoppingToken);
            }
        }
    }
}
