namespace ArraySearch
{
    public class FibonacciSearchStrategy : SearchStrategy
    {
        public int? Search(int[] array, int elem)
        {
            int k = 0, minIndex = Fibonacci(1);

            for(int fib = Fibonacci(k + 1); fib < array.Length; k++)
            {
                if(fib < minIndex)
                    minIndex = fib;
            }

            int index, offset = 0;

            for (; k > 0; )
            {
                index = offset + Fibonacci((--k) + 1);

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
