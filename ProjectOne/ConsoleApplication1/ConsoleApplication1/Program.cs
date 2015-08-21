using ConsoleApplication1.core;
using ConsoleApplication1.model;
using ConsoleApplication1.model.exceptions;
using ConsoleApplication1.view.console;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{//моя группа алина лев азат
    class Program
    {
       static void Main(string[] args)//можно добавить два id одинаковых
        {
            List<Worker> list = new List<Worker>();
            ConsoleView cv = new ConsoleView();
            ConsoleDialogHandler dh = new ConsoleDialogHandler(list);
            FileLogger fl = new FileLogger("log.txt");
            ConsoleLoggerWithTime clt = new ConsoleLoggerWithTime();
            cv.printNameOfProgram();
            cv.GetHelp();
            while (!dh.isExit)
            {
                try {
                    cv.PrintTable(dh.Handle(cv.Hear()));
                }catch(Exception e)
                {
                    fl.LogMessage(e.Message);
                    clt.LogMessage(e.Message);
                }
            }
            cv.Stop();
        }
    }
}
