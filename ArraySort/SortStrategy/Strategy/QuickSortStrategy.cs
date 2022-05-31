using System.Collections.Generic;

namespace ArraySort
{
    public class QuickSortStrategy : SortStrategy
    {
        public override List<int[]> Sort(ref int[] array)
        {
            DoSort(ref array, 0, array.Length - 1);

            return _indexing;
        }

        private void DoSort(ref int[] array, int first, int last)
        {
            ArrayPrinter.Print(array);

            if(first >= last)
                return;

            int pivot = ResolvePivot(ref array, first, last);

            DoSort(ref array, first, pivot - 1);
            DoSort(ref array, pivot + 1, last);
        }

        private int ResolvePivot(ref int[] array, int min, int max)
        {
            int pivot = min - 1;

            for (int i = min; i <= max; i++)
            {
                if(array[i] < array[max])
                {
                    pivot++;

                    Swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;

            Swap(ref array[pivot], ref array[max]);

            return pivot;
        }

        public override string ToString() => "Быстрая Сортировка";
    }
}