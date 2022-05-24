namespace ArraySort
{
    public class InsertSortStrategy : SortStrategy
    {
        public void Sort(ref int[] array)
        {
            GeneralInsertSort.Process(ref array, 0, 1);
        }

        public override string ToString() => "Сортировка Вставками";
    }
}
