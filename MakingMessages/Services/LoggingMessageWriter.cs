using MakingMessages.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingMessages.Services
{
    public class LoggingMessageWriter : IMessageWriter
    {
        private readonly ILogger<LoggingMessageWriter> _logger;

        public LoggingMessageWriter(ILogger<LoggingMessageWriter> logger) =>
            _logger = logger;

        public void Write(string message) =>
            _logger.LogInformation(message);
    }
}
