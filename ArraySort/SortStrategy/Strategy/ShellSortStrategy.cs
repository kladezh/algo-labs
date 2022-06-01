using System.Collections.Generic;

namespace ArraySort
{
    public class ShellSortStrategy : SortStrategy
    {
        override protected void DoSort(ref int[] array)
        {
            int i = 1;
            for (; 2 * i < array.Length; i *= 2) ;
            
            while(i >= 1)
            {
                for(int start = 1; start <= i; start++)
                {
                    for (int k = start; k < array.Length; k += i)
                    {
                        int newElement = array[k];
                        int location = k - i;

                        while (location >= 0 && array[location] > newElement)
                        {
                            array[location + i] = array[location];
                            location -= i;
                        }

                        array[location + i] = newElement;
                        Index(array);
                    }
                }

                i /= 2;
            }
        }

        public override string ToString() => "Сортировка Шелла";
    }
}
