using System.Collections.Generic;

namespace ArraySort
{
    public class BubbleSortStrategy : SortStrategy
    {
        public override List<int[]> Sort(ref int[] array)
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
                    }
                }

                length--;
            }

            return _indexing;
        }

        public override string ToString() => "Сортировка Пузырьком";
    }
}
