namespace ArraySort
{
    internal class ShellSortStrategy : SortStrategy
    {
        public void Sort(ref int[] array)
        {
            int i = 1;
            for (; 2 * i < array.Length; i *= 2) ;
            
            while(i >= 1)
            {
                for(int start = 1; start <= i; start++)
                {
                    GeneralInsertSort.Process(ref array, start, i);
                }

                i /= 2;
            }
        }
    }
}
