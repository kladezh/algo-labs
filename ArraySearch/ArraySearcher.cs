namespace ArraySearch
{
    public class ArraySearcher
    {
        private SearchStrategy _strategy;

        public ArraySearcher()
        {
        }
        public ArraySearcher(SearchStrategy strategy)
        {
            Strategy = strategy;
        }

        public SearchStrategy Strategy
        {
            get => _strategy;
            set => _strategy = value;
        }

        public int? Search(int[] array, int elem) => Strategy.Search(array, elem);
    }
}
