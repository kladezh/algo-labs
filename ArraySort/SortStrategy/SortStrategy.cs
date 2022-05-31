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

        protected void Swap(ref int a, ref int b)
        {
            (b, a) = (a, b);
        }

        abstract public List<int[]> Sort(ref int[] array);
    }
}
