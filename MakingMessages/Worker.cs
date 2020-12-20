using MakingMessages.Interfaces;
using MakingMessages.Services;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MakingMessages
{
    public class Worker : BackgroundService
    {
        //private readonly MessageWriter _messageWriter = new MessageWriter();
        private readonly IMessageWriter _messageWriter;
        private readonly ILogger<Worker> _logger;

        public Worker(IMessageWriter messageWriter, ILogger<Worker> logger)
        {
            _messageWriter = messageWriter;
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _messageWriter.Write($"Working running at: {DateTimeOffset.Now}");
                _logger.LogInformation($"Working running at: {DateTimeOffset.Now}");
                await Task.Delay(2000, stoppingToken);
            }
        }
    }
}
