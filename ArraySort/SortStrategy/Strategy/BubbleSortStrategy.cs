using System.Collections.Generic;

namespace ArraySort
{
    public class BubbleSortStrategy : SortStrategy
    {
        override protected void DoSort(ref int[] array)
        {
            int length = array.Length;
            bool doAction = true;

            while (doAction)
            {
                doAction = false;

                for (int i = 0; i < length - 1; i++)
                {
                    if(array[i] > array[i + 1])
                    {
                        Swap(ref array[i], ref array[i + 1]);

                        doAction = true;

                        Index(array);
                    }
                }

                length--;
            }
        }

        public override string ToString() => "Сортировка Пузырьком";
    }
}
