namespace ArraySort
{
    public class HeapSortStrategy : SortStrategy
    {
        public void Sort(ref int[] array)
        {
            for (int i = array.Length / 2; i >= 1; i--)
                FixHeap(ref array, i, array[i], array.Length);

            int max;
            for (int i = array.Length; i>=2; i--)
            {
                max = array[1];
                FixHeap(ref array, 1, array[i], i - 1);
                array[i] = max;
            }
        }

        private void FixHeap(ref int[] array, int root, int key, int bound)
        {
            int vacant = root;
            while(2 * vacant <= bound)
            {
                int largerChild = 2 * vacant;

                if (largerChild < bound && array[largerChild + 1] > array[largerChild])
                    largerChild++;

                if (key > array[largerChild])
                    break;
                else
                {
                    array[vacant] = array[largerChild];
                    vacant = largerChild;
                }
            }

            array[vacant] = key;
        }

        public override string ToString() => "Пирамидальная Сортировка";
    }
}
