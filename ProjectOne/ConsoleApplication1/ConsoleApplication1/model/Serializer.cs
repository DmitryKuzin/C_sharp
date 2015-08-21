using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using ConsoleApplication1.core;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using ConsoleApplication1.model;

namespace ConsoleApplication1
{
    class Serializer
    {
        private static String fileName =@Configer.ReadConfigToString("fileName");
        private static String filePath =@Configer.ReadConfigToString("filePath") + fileName;
        public static void writing(List<Worker> workers)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            List<Worker> list = new List<Worker>();
            FileInfo data = new FileInfo(filePath);
            if (!data.Exists)
            {
                using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
                {
                    list = (List<Worker>)formatter.Deserialize(fs);

                    if (list == null)
                    {
                        list = new List<Worker>();
                    }
                }
            }
            foreach (Worker w in workers)
            {
                list.Add(w);
            }
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, list);
            }
        }

        public static List<Worker> reading()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileInfo data = new FileInfo(filePath);
            List<Worker> list = new List<Worker>();
            if (data.Exists)
            {
                using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
                {
                    list = (List<Worker>)formatter.Deserialize(fs);
                    if (list == null)
                    {
                        
                        list = new List<Worker>();
                    }
                }
            }
            return list;
        }

    }
}