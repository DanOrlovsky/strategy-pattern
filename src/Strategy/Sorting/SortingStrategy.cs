using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Sorting
{
    /// <summary>
    /// The base Strategy class.  Strategy implementations must inherit.
    /// </summary>
    public abstract class SortingStrategy
    {
        public abstract void Sort(List<string> list);
    }
}
