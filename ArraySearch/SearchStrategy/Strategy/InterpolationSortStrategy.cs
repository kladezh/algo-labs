namespace ArraySearch
{
    public class InterpolationSortStrategy : SearchStrategy
    {
        public int? Search(int[] array, int elem)
        {
            int low = 0;
            int high = array.Length - 1;
            int middle;

            while(array[low] < elem && array[high] >= elem)
            {
                middle = low + ((elem - array[low]) * (high - low)) / (array[high] - array[low]);

                if(array[middle] < elem)
                    low = middle + 1;
                else if (array[middle] > elem)
                    high = middle - 1;
                else
                    return middle;
            }

            if (array[low] == elem)
                return low;
            else
                return null;
        }

        public override string ToString() => "Интерполяционный Поиск";
    }
}
