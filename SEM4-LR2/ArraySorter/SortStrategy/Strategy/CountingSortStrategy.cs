namespace ArraySort
{
    internal class CountingSortStrategy : SortStrategy
    {
        public void Sort(ref int[] array)
        {
            int range = CountRange(array);

            DoSort(ref array, range);
        }

        private int CountRange(int[] array)
        {
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] > max)
                    max = array[i];
            }

            return max;
        }

        private void DoSort(ref int[] array, int range)
        {
            int[] source = new int[array.Length];
            int[] counter = new int[range + 1];

            for (int i = 0; i < array.Length; i++)
                source[i] = array[i];

            for (int i = 0; i < counter.Length; i++)
                counter[i] = 0;

            for (int i = 0; i < array.Length; i++)
                counter[array[i]]++;

            int sumNum = 0;
            for (int i = 0; i < counter.Length; i++)
            {
                int temp = counter[i];
                counter[i] = sumNum;
                sumNum += temp;
            }

            for (int i = 0; i < array.Length; i++)
            {
                int temp = source[i];
                array[counter[i]] = temp;
                counter[i]++;
            }
        }
    }
}
