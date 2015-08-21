using ConsoleApplication1.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.model.Sorter
{
    class NameComparer : IComparer<Worker>
    {
        public int Compare(Worker x, Worker y)
        {
            int a = 0;
            for (int i = 0; i < (x.LastName.Length > y.LastName.Length ? y.LastName.Length : x.LastName.Length); i++) //t ? x : y — если тест t имеет значение true, 
            //вычисляет и возвращает x, в противном случае вычисляет и возвращает y.
            {
                if (x.LastName.ToCharArray()[i] < y.LastName.ToCharArray()[i]) a=1;
                if (x.LastName.ToCharArray()[i] > y.LastName.ToCharArray()[i]) a= -1;
            }
            return a;
        
        }
    }
}
