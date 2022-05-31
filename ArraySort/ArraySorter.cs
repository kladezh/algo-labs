using System.Collections.Generic;

namespace ArraySort
{
    public class ArraySorter
    {
        private SortStrategy _strategy;
        private List<int[]> _indexing;

        public ArraySorter()
        {
            _indexing = new List<int[]>();
        }
        public ArraySorter(SortStrategy strategy) : this()
        {
            Strategy = strategy;
        }

        public SortStrategy Strategy
        {
            get => _strategy;
            set => _strategy = value;
        }

        public List<int[]> LastIndexing
        {
            get => _indexing;
        }

        public void Sort(ref int[] array)
        {
            _indexing.Clear();
            _indexing = Strategy.Sort(ref array);
        }
    }
}
