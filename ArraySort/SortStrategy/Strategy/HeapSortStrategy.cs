namespace ArraySort
{
    public class HeapSortStrategy : SortStrategy
    {
        public void Sort(ref int[] array)
        {
            DoSort(ref array, array.Length);
        }

        private void DoSort(ref int[] array, int n)
        {
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(ref array, n, i);
            }

            for (int i = n - 1; i >= 0; i--)
            {
                int temp = array[i];
                array[i] = array[0];
                array[0] = temp;

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
                int temp = array[i];
                array[i] = array[largest];
                array[largest] = temp;

                Heapify(ref array, n, largest);
            }
        }

        public override string ToString() => "Пирамидальная Сортировка";
    }
}