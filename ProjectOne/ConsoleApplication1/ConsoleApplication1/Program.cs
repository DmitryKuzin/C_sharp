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
       static void Main(string[] args)
        {
            List<Worker> list = new List<Worker>();
            ConsoleView cv = new ConsoleView();
            ConsoleDialogHandler dh = new ConsoleDialogHandler(list);
            FileLogger fl = new FileLogger("log.txt");
            cv.printNameOfProgram();
            cv.GetHelp();
            while (!dh.isExit)
            {
                try {
                    cv.PrintTable(dh.Handle(cv.Hear()));
                }catch(Exception e)
                {
                    fl.LogMessage(e.Message);
                }
            }
            cv.Stop();
        }
    }
}
