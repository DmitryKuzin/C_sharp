using System;
using System.IO;
using System.Text;

namespace ConsoleApplication1
{
    abstract class Logger
    {
        public Logger()
        {
            Log.OnLogHandler += new Log.LogEventHandler(LogMessage);
        }
        public abstract void LogMessage(string Message);
    }
}
