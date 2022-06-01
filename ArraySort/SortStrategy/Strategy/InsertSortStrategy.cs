using System.Collections.Generic;

namespace ArraySort
{
    public class InsertSortStrategy : SortStrategy
    {
        override protected void DoSort(ref int[] array)
        {
            for (int i = 0; i < array.Length; i ++)
            {
                int newElement = array[i];
                int location = i - 1;

                while (location >= 0 && array[location] > newElement)
                {
                    array[location + 1] = array[location];
                    location --;
                }

                array[location + 1] = newElement;
            }
        }

        public override string ToString() => "Сортировка Вставками";
    }
}
