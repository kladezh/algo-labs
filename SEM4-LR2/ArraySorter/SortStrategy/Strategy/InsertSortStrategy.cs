namespace ArraySort
{
    internal class InsertSortStrategy : SortStrategy
    {
        public void Sort(ref int[] array)
        {
            GeneralInsertSort.Process(ref array, 0, 1);
        }
    }
}
