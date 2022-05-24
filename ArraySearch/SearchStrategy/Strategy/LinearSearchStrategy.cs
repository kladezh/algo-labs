namespace ArraySearch
{
    public class LinearSearchStrategy : SearchStrategy
    {
        public int? Search(int[] array, int elem)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == elem)
                    return i;
            }

            return null;
        }

        public override string ToString() => "Линейный Поиск";
    }
}
