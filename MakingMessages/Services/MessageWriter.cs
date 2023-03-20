using MakingMessages.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingMessages.Services
{
    public class MessageWriter : IMessageWriter
    {
        public void Write(string message)
        {
            Console.WriteLine($"MessageWriter.Write(message: \"{message}\")");
        }
    }
}
