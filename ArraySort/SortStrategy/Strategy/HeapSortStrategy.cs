using System.Collections.Generic;

namespace ArraySort
{
    public class HeapSortStrategy : SortStrategy
    {
        override protected void DoSort(ref int[] array)
        {
            for (int i = array.Length / 2 - 1; i >= 0; i--)
            {
                Heapify(ref array, array.Length, i);
            }

            for (int i = array.Length - 1; i >= 0; i--)
            {
                Swap(ref array[i], ref array[0]);
                Index(array);

                Heapify(ref array, i, 0);
            }
        }

        private void Heapify(ref int[] array, int n, int i)
        {
            int largest = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;

            if (l < n && array[l] > array[largest])
                largest = l;

            if (r < n && array[r] > array[largest])
                largest = r;

            if (largest != i)
            {
                Swap(ref array[i], ref array[largest]);
                Index(array);

                Heapify(ref array, n, largest);
            }
        }

        public override string ToString() => "Пирамидальная Сортировка";
    }
}