namespace ArraySearch
{
    public class BinarySearchStrategy : SearchStrategy
    {
        public int? Search(int[] array, int elem)
        {
            int middle, low = 0, high = array.Length;

            while(low <= high)
            {
                middle = (low + high) / 2;
                if (elem == array[middle])
                    return middle;
                else if (elem < array[middle])
                    high = middle - 1;
                else 
                    low = middle + 1;
            }

            return null;
        }
        public override string ToString() => "Бинарный Поиск";
    }
}
