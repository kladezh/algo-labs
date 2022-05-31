namespace ArraySort
{
    internal class GeneralInsertSort
    {
        public static void Process(ref int[] array, int k, int j)
        {
            for (int i = k; i < array.Length; i += j)
            {
                int newElement = array[i];
                int location = i - j;

                while (location >= 0 && array[location] > newElement)
                {
                    array[location + j] = array[location];
                    location -= j;
                }

                array[location + j] = newElement;

                ArrayPrinter.Print(array);
            }
        }
    }
}
