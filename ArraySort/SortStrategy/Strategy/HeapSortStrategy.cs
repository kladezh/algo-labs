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
                Heapify(ref array, i, n);
            }
            while (n > 1)
            {
                n--;

                int temp = array[0];
                array[0] = array[n];
                array[n] = temp;

                Heapify(ref array, 0, n);
            }
        }

        private void Heapify(ref int[] array, int index, int n)
        {
            int curr = array[index];
            int i = index;

            for(; ; )
            {
                int left = i + i + 1;
                int right = left  + 1;

                if(left < n && array[left] > curr)
                    i = left;
                if(right < n && array[right] > array[i])
                    i = right;
                if (i == index) break;

                array[index] = array[i];
                array[i] = curr;
                index = i;
            }
        }

        public override string ToString() => "Пирамидальная Сортировка";
    }
}