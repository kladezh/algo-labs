namespace ArraySearch
{
    public class FibonacciSearchStrategy : SearchStrategy
    {
        public int? Search(int[] array, int elem)
        {
            int k = 0;

            for (; Fibonacci(k + 1) < array.Length; k++) ;

            for (int index, offset = 0; k > 0; )
            {
                index = offset + Fibonacci(--k);

                if (index >= array.Length || elem < array[index])
                    continue;
                else if (elem > array[index])
                {
                    offset = index;
                    k--;
                }
                else
                    return index;
            }

            return null;
        }

        private int Fibonacci(int n)
        {
            if (n == 0 || n == 1)
                return n;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        public override string ToString() => "Поиск Фибоначчи";
    }
}
