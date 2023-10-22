using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PopkovSV.Sprint3.Task3.V15.Lib
{
    public class DataService : ISprint3Task3V15
    {
        public int GetMinCharCount(string value, char item)
        {
            List<int> list = new List<int>();
            char prev = value[0];
            int count = 1;
            foreach (char chr in value)
            {
                if (chr == item && prev == item)
                {
                    count++;
                }
                if (chr != item && prev == item)
                {
                    list.Add(count);
                    count = 1;
                }
                prev = chr;
            }
            return list.Where(i => i >= 2).Min();
        }
    }
}