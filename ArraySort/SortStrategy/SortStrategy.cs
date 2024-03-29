﻿using System.Collections.Generic;
using System.Linq;

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

        protected void Index(int[] array)
        {
            if(_indexing.FindIndex(item => item.SequenceEqual(array)) == -1)
                _indexing.Add((int[])array.Clone());  
        }

        public List<int[]> Sort(ref int[] array)
        {
            _indexing.Clear();

            DoSort(ref array);

            return _indexing;
        }

        abstract protected void DoSort(ref int[] array);
    }
}
