using System;

namespace ArraySort
{
    internal class RadixSortStrategy : SortStrategy
    {
        private const int RadixCount = 10;

        public void Sort(ref int[] array)
        {
            DoSort(ref array, RadixCount, ResolveMaxRadix(array));
        }

        private void DoSort(ref int[] array, int count, int maxRadix)
        {
            int[] source = new int[array.Length];

            for (int step = 0, radPow = 1; step < maxRadix; step++, radPow *= count)
            {
                int[] support = new int[count];
      
                for (int i = 0; i < array.Length; i++)
                {
                    source[i] = array[i];

                    int d = (source[i] / radPow) % count;
                    support[d]++;
                }

                int sumNum = 0;
                for (int i = 0; i < count; i++)
                {
                    int temp = support[i];
                    support[i] = sumNum;
                    sumNum += temp;
                }

                for (int i = 0; i < array.Length; i++)
                {
                    int d = (source[i] / radPow) % count;
                    array[support[d]] = source[i];
                    support[d]++;
                }
            }
        }

        private int ResolveMaxRadix(int[] array)
        {
            int max = 0;

            foreach (int elem in array)
            {
                int radix = (int)(Math.Log10(elem) + 1);
                if (radix > max)
                {
                    max = radix;
                }
            }

            return max;
        }
    }
}