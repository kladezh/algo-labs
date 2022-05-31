using System.Collections.Generic;

namespace ArraySort
{
    public class InsertSortStrategy : SortStrategy
    {
        override protected void DoSort(ref int[] array)
        {
            GeneralInsertSort.Process(ref array, 0, 1);
        }

        public override string ToString() => "Сортировка Вставками";
    }
}
