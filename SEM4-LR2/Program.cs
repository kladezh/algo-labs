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
            ConsolePrintArray(array);

            Console.WriteLine("\nВыберите вариант сортировки:");
            ConsoleWriteSort();

            Console.Write("\nВвод: ");
            int choice = int.Parse(Console.ReadLine());

            ArraySorter sorter = new ArraySorter();

            sorter.Strategy = ConsoleGetSortStrategy(choice);

            sorter.Sort(ref array);

            Console.WriteLine("\nШаги сортировки:");
            foreach (var index in sorter.LastIndexing)
                ConsolePrintArray(index);

            Console.WriteLine("\nОстортированный массив:");
            ConsolePrintArray(array);

            // Задание: посчитать разность элементов на второй и предпоследней итерации в Пирамидальной сортировке
            // > >
            if (sorter.Strategy is HeapSortStrategy)
            {
                List<int[]> taskList = new List<int[]>();
                taskList.Add((int[])sorter.LastIndexing[1].Clone());
                taskList.Add((int[])sorter.LastIndexing[sorter.LastIndexing.Count - 2].Clone());

                int[] taskOutput = new int[array.Length];
                for (int i = 0; i < taskOutput.Length; i++)
                {
                    taskOutput[i] = taskList[0][i] - taskList[1][i];
                }

                Console.WriteLine("\nРазность элементов второй и предпоследней итерации:");
                ConsolePrintArray(taskOutput);
            }
            // < < 

            Console.ReadKey();
        }

        static void ConsoleInitRandomArray(out int[] array)
        {
            int length = int.Parse(Console.ReadLine());

            array = new int[length];

            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 20);
            }
        }

        static void ConsoleInitArray(out int[] array)
        {
            int length = int.Parse(Console.ReadLine());

            array = new int[length];

            Console.WriteLine("\nВведите элементы массива:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        static void ConsolePrintArray(int[] array)
        {
            foreach(int i in array) 
                Console.Write($"{i} ");
            Console.WriteLine();
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
