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
            int i = first, j = last, x = array[(first + last) / 2];

            do
            {
                while (array[i] < x) i++;
                while (array[j] > x) j++;

                if(i <= j)
                {
                    if (i < j)
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }

                    i++;
                    j--;
                }
            } while (i <= j);

            if( i < last)
            {
                DoSort(ref array, i, last);
            }
            if(first > j)
            {
                DoSort(ref array, first, j);
            }
        }
    }
}
