using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy.Sorting
{
    /// <summary>
    /// A shell sort implementation
    /// </summary>
    public class ShellSort : SortingStrategy
    {
        public override void Sort(List<string> list)
        {
            int inc = 3;
            while (inc > 0)
            {
                for (var i = 0; i < list.Count(); i++)
                {
                    var idx = i;
                    var temp = list[i];
                    while((idx >= inc) && list[idx - inc].CompareTo(temp) != -1)
                    {
                        list[idx] = list[idx - inc];
                        idx -= inc;
                    }
                    list[idx] = temp;
                }
                if (inc / 2 != 0)
                    inc /= 2;
                else if (inc == 1)
                    inc = 0;
                else
                    inc = 1;
            }
        }
    }
}
