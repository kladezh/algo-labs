namespace ArraySort
{
    internal class QuickSortStrategy : SortStrategy
    {
        public void Sort(ref int[] array)
        {
            DoSort(ref array, 0, array.Length - 1);
        }

        private void DoSort(ref int[] array, int first, int last)
        {
            if(first >= last)
                return;

            int pivot = ResolvePivot(ref array, first, last);

            DoSort(ref array, first, pivot - 1);
            DoSort(ref array, pivot + 1, last);
        }

        private int ResolvePivot(ref int[] array, int min, int max)
        {
            int temp;

            int pivot = min - 1;

            for (int i = min; i <= max; i++)
            {
                if(array[i] < array[max])
                {
                    pivot++;
                    
                    temp = array[pivot];
                    array[pivot] = array[i];
                    array[i] = temp;
                }
            }

            pivot++;

            temp = array[pivot];
            array[pivot] = array[max];
            array[max] = temp;

            return pivot;
        }

        public override string ToString() => "Быстрая Сортировка";
    }
}