namespace ArraySort
{
    internal class BubbleSortStrategy : SortStrategy
    {
        public void Sort(ref int[] array)
        {
            int length = array.Length;
            bool doAction = true;

            while (doAction)
            {
                doAction = false;

                for (int i = 0; i < length - 1; i++)
                {
                    if(array[i] < array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;

                        doAction = true;
                    }
                }

                length--;
            }
        }

        public override string ToString() => "Сортировка Пузырьком";
    }
}
