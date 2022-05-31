using System.Collections.Generic;

namespace ArraySort
{
    public class InsertSortStrategy : SortStrategy
    {
        public override List<int[]> Sort(ref int[] array)
        {
            GeneralInsertSort.Process(ref array, 0, 1);

            return _indexing;
        }

        public override string ToString() => "Сортировка Вставками";
    }
}
