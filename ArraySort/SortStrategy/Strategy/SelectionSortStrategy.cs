using System.Collections.Generic;

namespace ArraySort
{
    public class SelectionSortStrategy : SortStrategy
    {
        override protected void DoSort(ref int[] array)
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

                Index(array);
            }
        }

        public override string ToString() => "Сортировка Выбором";
    }
}
