using System;
using System.Collections.Generic;

using ArraySort;

namespace SEM4_LR2
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
            Console.Write("Введите размер массива: ");
            ConsoleInitArray(out int[] array);

            Console.WriteLine("\nСгенерированный массив:");
            ArrayPrinter.Print(array);

            Console.WriteLine("\nВыберите вариант сортировки:");
            ConsoleWriteSort();

            Console.Write("\nВвод: ");
            int choice = int.Parse(Console.ReadLine());

            ArraySorter sorter = new ArraySorter();

            sorter.Strategy = ConsoleGetSortStrategy(choice);
            sorter.Sort(ref array);

            Console.WriteLine("\nОстортированный массив:");
            ArrayPrinter.Print(array);

            Console.ReadKey();
        }

        static void ConsoleInitArray(out int[] array)
        {
            int length = int.Parse(Console.ReadLine());

            array = new int[length];

            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 20);
            }
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
