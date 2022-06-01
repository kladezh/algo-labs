using System.Collections.Generic;

namespace ArraySort
{
    public class QuickSortStrategy : SortStrategy
    {
        override protected void DoSort(ref int[] array)
        {
            CallSort(ref array, 0, array.Length - 1);
        }

        private void CallSort(ref int[] array, int first, int last)
        {
            Index(array);

            if (first >= last)
                return;

            int pivot = ResolvePivot(ref array, first, last);

            CallSort(ref array, first, pivot - 1);
            CallSort(ref array, pivot + 1, last);
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