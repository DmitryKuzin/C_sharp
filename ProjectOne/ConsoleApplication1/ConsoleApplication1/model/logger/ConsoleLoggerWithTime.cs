using System;
using System.IO;
using System.Text;

namespace ConsoleApplication1
{
    class ConsoleLoggerWithTime : Logger
    {
        public override void LogMessage(string Message)
        {
            Console.WriteLine(DateTime.Now + ": " + Message);
        }
    }
}
