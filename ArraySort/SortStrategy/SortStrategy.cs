using System.Collections.Generic;

namespace ArraySort
{
    public abstract class SortStrategy
    {
        protected List<int[]> _indexing;

        public SortStrategy()
        {
            _indexing = new List<int[]>();
        }

        abstract public List<int[]> Sort(ref int[] array);
    }
}
