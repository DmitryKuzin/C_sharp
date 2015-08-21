using System;
using System.IO;
using System.Text;

namespace ConsoleApplication1
{
    class FileLogger : Logger
    {
        StreamWriter sw = null;
        public FileLogger(string fileName)
            : base()
        {
            sw = new StreamWriter(File.Create(fileName), Encoding.GetEncoding("Windows-1251"));
        }

        public override void LogMessage(string Message)
        {
            sw.WriteLine(DateTime.Now + ": " + Message);
            sw.Flush();
        }
    }
}