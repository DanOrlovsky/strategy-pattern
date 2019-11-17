using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Sorting
{
    public class SortableList
    {
        private List<string> _list = new List<string>();
        private SortingStrategy _sortingStrategy;

        public List<string> List { get { return _list; } }

        public SortableList()
        { }

        public SortableList(List<string> list,
            SortingStrategy sortingStrategy)
        {
            _list = list;
            _sortingStrategy = sortingStrategy;
        }

        public void SetSortingStrategy(SortingStrategy strategy)
        {
            _sortingStrategy = strategy;
        }

        public void Add(string item)
        {
            _list.Add(item);
        }

        public void Sort()
        {
            _sortingStrategy.Sort(_list);
        }
    }
}
