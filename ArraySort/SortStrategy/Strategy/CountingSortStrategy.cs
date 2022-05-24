namespace ArraySort
{
    public class CountingSortStrategy : SortStrategy
    {
        public void Sort(ref int[] array)
        {
            int min = int.MaxValue;
            int max = int.MinValue;

            foreach (int elem in array)
            {
                if (elem < min) min = elem;
                if (elem > max) max = elem;
            }
                
            int[] counters = new int[max - min + 1];

            foreach (int elem in array)
                counters[elem - min]++;

            int index = 0;
            for (int number = 0; number < counters.Length; number++)
            {
                for (int count = 0; count < counters[number]; count++)
                {
                    array[index] = number + min;
                    index++;
                }
            }
        }

        public override string ToString() => "Сортировка Подсчётом";
    }
}