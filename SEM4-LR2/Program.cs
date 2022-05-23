using System;
using System.Collections.Generic;

namespace ArraySort
{
    using SortStrategyMap = Dictionary<int, SortStrategy>;

    internal class Program
    {
        private static SortStrategyMap SortMap = new SortStrategyMap()
        {
            { 1, new SelectionSortStrategy()},
            { 2, new BubbleSortStrategy()},
            { 3, new InsertSortStrategy()},
            { 4, new ShellSortStrategy()},
            { 5, new HeapSortStrategy()},
            { 6, new MergeSortStrategy()},
            { 7, new QuickSortStrategy()},
            { 8, new CountingSortStrategy()},
            { 9, new RadixSortStrategy()},
        };

        static void Main(string[] args)
        {
            int[] array = ConsoleInitArray();

            Console.WriteLine("\nСгенерированный массив:");
            ConsoleWriteArray(array);

            Console.WriteLine("Выберите вариант сортировки:");
            ConsoleWriteSort();

            Console.Write("\nВвод: ");
            int choice = int.Parse(Console.ReadLine());

            ArraySorter sorter = new ArraySorter();

            sorter.Strategy = ConsoleGetSortStrategy(choice);
            sorter.Sort(ref array);

            Console.WriteLine("\nОстортированный массив:");
            ConsoleWriteArray(array);

            Console.ReadKey();
        }

        static int[] ConsoleInitArray()
        {
            Console.Write("Введите размер массива: ");
            int arrayLength = int.Parse(Console.ReadLine());

            int[] array = new int[arrayLength];

            Random random = new Random();
            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = random.Next(0, 20);
            }

            return array;
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

        static void ConsoleWriteSort()
        {
            foreach (var sort in SortMap)
                Console.WriteLine($"{sort.Key} - {sort.Value.ToString()}");
        }

        static SortStrategy ConsoleGetSortStrategy(int number)
        {
            SortMap.TryGetValue(number, out SortStrategy sort);
            return sort;
        }
    }
}
