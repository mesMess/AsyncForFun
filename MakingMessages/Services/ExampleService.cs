﻿using MakingMessages.Interfaces;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace MakingMessages.Services
{
    public class ExampleService
    {
        public ExampleService(
            IMessageWriter messageWriter,
            IEnumerable<IMessageWriter> messageWriters)
        {
            Trace.Assert(messageWriter is LoggingMessageWriter);

            var dependencyArray = messageWriters.ToArray();
            Trace.Assert(dependencyArray[0] is ConsoleMessageWriter);
            Trace.Assert(dependencyArray[1] is LoggingMessageWriter);
        }
    }
}
