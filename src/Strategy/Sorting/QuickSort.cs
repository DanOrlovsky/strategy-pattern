using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy.Sorting
{
    /// <summary>
    /// A quick sort implementation
    /// </summary>
    public class QuickSort : SortingStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort();
        }
    }
}
