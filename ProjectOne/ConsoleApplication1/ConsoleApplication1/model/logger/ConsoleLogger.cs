using System;
using System.IO;
using System.Text;

namespace ConsoleApplication1
{
    class ConsoleLogger : Logger
    {
        public override void LogMessage(string Message)
        {
            Console.WriteLine(Message);
        }
    }
}
