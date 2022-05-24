using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ArraySearch;

namespace SEM4_LR3
{
    using SearchStrategyMap = Dictionary<int, SearchStrategy>;

    internal class Program
    {
        private static SearchStrategyMap SearchMap = new SearchStrategyMap()
        {
            { 1, new LinearSearchStrategy()},
            { 2, new BinarySearchStrategy()},
            { 3, new FibonacciSearchStrategy()},
            { 4, new InterpolationSortStrategy()},
        };

        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            ConsoleInitArray(out int[] array);

            Console.WriteLine("\nСгенерированный массив:");
            ConsoleWriteArray(array);

            Console.WriteLine("Выберите вариант поиска:");
            ConsoleWriteSearch();

            Console.Write("\nВвод: ");
            int selectedSearch = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите элемент:");
            int searchedElem = int.Parse(Console.ReadLine());

            ArraySearcher searcher = new ArraySearcher();
            searcher.Strategy = ConsoleGetSearchStrategy(selectedSearch);

            int? index = searcher.Search(array, searchedElem);

            Console.WriteLine(index is null ? "Элемент не найден..." : $"Элемент найден на позиции [{index}]");

            Console.ReadKey();
        }

        static void ConsoleInitArray(out int[] array)
        {
            int length = int.Parse(Console.ReadLine());

            array = new int[length];

            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(0, 20);
            }
        }

        static void ConsoleWriteArray(int[] array)
        {
            Console.WriteLine("{");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"[{i}] => {array[i]}");
            }
            Console.WriteLine("}\n");
        }
        static void ConsoleWriteSearch()
        {
            foreach (var sort in SearchMap)
                Console.WriteLine($"{sort.Key} - {sort.Value.ToString()}");
        }

        static SearchStrategy ConsoleGetSearchStrategy(int number)
        {
            SearchMap.TryGetValue(number, out SearchStrategy search);
            return search;
        }
    }
}
