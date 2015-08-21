using System;
using System.Collections.Generic;
using ConsoleApplication1.core;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.model;
using System.Collections;
using ConsoleApplication1.model.exceptions;

namespace ConsoleApplication1.view.console
{
    class ConsoleDialogHandler:ConsoleView
    {
        
        public bool isExit = false;
        public List<Worker> list = null;
        private List<Worker> buf = new List<Worker>();
        ArrayList IdList = new ArrayList();
        public ConsoleDialogHandler(List<Worker> workers)
        {
            list = workers;
        }
        public List<Worker> Handle(string inquiry)
        {
            if (inquiry.Equals("-getTable"))
            {
                return list;
            }
            else if (inquiry.Equals("-help"))
            {
                GetHelp();
                return list;
            }
            else if (inquiry.Equals("-in"))
            {
                Print("What type of worker?(Temporary/Permament)");
                String type = Hear();
                Print("Name:");
                string name = Hear();
                Print("Last Name:");
                string lastName = Hear();
                Print("id:");
                int id = Int32.Parse(Hear());
                if (!IdList.Contains(id))
                {
                    IdList.Add(id);
                }
                else
                {
                    throw new IDException();
                }
                double sal = 0;
                if (type.ToLower().Substring(0, 1).Equals("t"))
                {
                    Print("Per hour rate:");
                    sal = Double.Parse(Hear());
                }
                else
                {
                    Print("Salary:");
                    sal = Double.Parse(Hear());
                }

                if (type.ToLower().Substring(0, 1).Equals("t"))
                {
                    list.Add(new TemporaryWorker(name, lastName, id, sal));
                }
                else
                {
                    list.Add(new PermamentWorker(name, lastName, id, sal));
                }
                return list;
            }
            else if (inquiry.Equals("-collapse"))
            {
                Print("Do you want to save table to file?(Y/N)");
                string b = Hear().ToLower();
                if (b.Substring(0, 1).Equals("y"))
                {
                    Print("Can i use a default path?");
                    string c = Hear();
                    if (c.ToLower().Substring(0, 1).Equals("n"))
                    {
                        Print("Enter path:");
                        string path = Hear();
                        Configer.WriteToConfig("filePath", path);
                    }
                    Serializer.writing(list);
                }
                list = new List<Worker>();
                return list;

            }
            else if (inquiry.Equals("-save"))
            {
                Print("Can i use a default path?(Y/N)");
                string c = Hear();
                if (c.ToLower().Substring(0, 1).Equals("n"))
                {
                    Print("Enter path:");
                    string path = Hear();
                    Configer.WriteToConfig("filePath", path);
                }
                Serializer.writing(list);
                return list;
            }
            else if (inquiry.Equals("-read"))
            {
                Print("Can i use default path?");
                string d = Hear().ToLower();
                if (d.Substring(0, 1).Equals("n"))
                {
                    Print("Enter path:");
                    string path = Hear();
                    Configer.WriteToConfig("filePath", path);
                }
                list = Serializer.reading();
                return list;
            }
            else if (inquiry.Equals("-getTop"))
            {
                Print("Worst or best?(W/B)");
                string n = Hear().ToLower();
                if (n.Substring(0, 1).Equals("w"))
                {
                    buf=list;
                    buf= Sort.theWorst(list);

                }
                else
                {
                    buf = list;
                    buf = Sort.theBest(list);
                }
                return buf;
            }
            else if (inquiry.Equals("-changeProperties"))
            {
                Print("App.config");
                Print("hours:");
                Print(Configer.ReadConfigToString("hours"));
                Print("index:");
                Print(Configer.ReadConfigToString("index"));
                Print("filPath:");
                Print(Configer.ReadConfigToString("filePath"));
                Print("fileName:");
                Print(Configer.ReadConfigToString("fileName"));
                Print("What do you want to change?");
                string b = Hear();
                if ((b.Equals("hours") || (b.Equals("index")) || (b.Equals("fileName")) || (b.Equals("filePath"))))
                {
                    Print("Write value for this key:");
                    Configer.WriteToConfig(b, Hear());
                }
                return list;
            }else if (inquiry.Equals("-exit"))
            {
                isExit = true;
                return list;
            }else if (inquiry.Equals("-sort"))
            {
                list = Sort.sort(list);
                return list;
            }
            else return list;


        }
        
    }
}
