using System;

namespace ArraySort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = ConsoleInitArray();

            Console.WriteLine("\nСгенерированный массив:");
            ConsoleWriteArray(array);

            ConsoleWriteSort();

            Console.Write("\nВвод: ");
            int choice = int.Parse(Console.ReadLine());

            ArraySorter sorter = new ArraySorter();

            sorter.Strategy = GetSortStrategy(choice);
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
            Console.WriteLine("Выберите вариант сортировки:");
            Console.WriteLine("1 - сортировка выбором");
            Console.WriteLine("2 - сортировка пузырьком");
            Console.WriteLine("3 - сортировка вставкой");
            Console.WriteLine("4 - сортировка Шелла");
            Console.WriteLine("5 - пирамидальная сортировка");
            Console.WriteLine("6 - сортировка слиянием");
            Console.WriteLine("7 - быстрая сортировка");
            Console.WriteLine("8 - сортировка подсчётом");
            Console.WriteLine("9 - поразрядная сортировка");
        }

        static SortStrategy GetSortStrategy(int number)
        {
            switch (number)
            {
                case 1:
                    return new SelectionSortStrategy();

                case 2:
                    return new BubbleSortStrategy();

                case 3:
                    return new InsertSortStrategy();

                case 4:
                    return new ShellSortStrategy();

                case 5:
                    return new HeapSortStrategy();

                case 6:
                    return new MergeSortStrategy();

                case 7:
                    return new QuickSortStrategy();

                case 8:
                    return new CountingSortStrategy();

                case 9:
                    return new RadixSortStrategy();

                default:
                    return null;
            }
        }
    }
}
