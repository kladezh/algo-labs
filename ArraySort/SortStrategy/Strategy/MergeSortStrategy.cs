using System.Collections.Generic;

namespace ArraySort
{
    public class MergeSortStrategy : SortStrategy
    {
        public override List<int[]> Sort(ref int[] array)
        {
            Merge(ref array, 0, array.Length - 1);

            return _indexing;
        }

        private void Merge(ref int[] array, int first, int last)
        {
            if(first < last)
            {
                int split = (first + last) / 2;
                Merge(ref array, first, split);
                Merge(ref array, split + 1, last);

                DoMerge(ref array, first, split, last);
            }
        }

        private void DoMerge(ref int[] array, int first, int split, int last)
        {
            int pos1 = first;
            int pos2 = split + 1;
            int pos3 = 0;

            int[] temp = new int[last - first + 1];

            while(pos1 <= split && pos2 <= last)
            {
                temp[pos3++] = (array[pos1] < array[pos2]) ? array[pos1++] : array[pos2++];
            }

            while(pos2 <= last)
            {
                temp[pos3++] = array[pos2++];
            }
            while(pos1 <= split)
            {
                temp[pos3++] = array[pos1++];
            }

            for(pos3 = 0; pos3 < last - first + 1; pos3++)
            {
                array[first + pos3] = temp[pos3];
            }
        }

        public override string ToString() => "Сортировка Слиянием";
    }
}
