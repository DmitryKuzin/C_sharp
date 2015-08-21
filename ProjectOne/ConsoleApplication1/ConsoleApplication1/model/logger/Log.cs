using System;
using System.IO;
using System.Text;

namespace ConsoleApplication1
{
    class Log
    {
        public delegate void LogEventHandler(string Message);
        static public event LogEventHandler OnLogHandler;

        static public void WriteLine(string Message)
        {
            if (OnLogHandler != null)
            {
                OnLogHandler(Message);
            }
        }
    }
}
