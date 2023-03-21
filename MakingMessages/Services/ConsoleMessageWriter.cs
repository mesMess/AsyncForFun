using MakingMessages.Interfaces;
using System;

namespace MakingMessages.Services
{
    public class ConsoleMessageWriter : IMessageWriter
    {
        public void Write(string message) =>
            Console.WriteLine("I'm the console message service...");
    }
}
