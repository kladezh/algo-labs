using System.Collections.Generic;

namespace ArraySort
{
    public class SelectionSortStrategy : SortStrategy
    {
        public override List<int[]> Sort(ref int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }

                Swap(ref array[i], ref array[min]);

                ArrayPrinter.Print(array);
            }

            return _indexing;
        }

        public override string ToString() => "Сортировка Выбором";
    }
}
