using MakingMessages.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingMessages.Services
{
    public class ConsoleMessageWriter : IMessageWriter
    {
        public void Write(string message) =>
            Console.WriteLine("I'm the console message service...");
    }
}
