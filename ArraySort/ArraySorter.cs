namespace ArraySort
{
    public class ArraySorter
    {
        private SortStrategy _strategy;

        public ArraySorter()
        {
        }
        public ArraySorter(SortStrategy strategy)
        {
            Strategy = strategy;
        }

        public SortStrategy Strategy
        {
            get => _strategy;
            set => _strategy = value;
        }

        public void Sort(ref int[] array) => Strategy.Sort(ref array);
    }
}
