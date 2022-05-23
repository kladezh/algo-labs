using System;

namespace ArraySort
{
    internal class Program
    {
        static void ConsoleWriteSort()
        {
            Console.WriteLine("Выберите вариант сортировки:");
            Console.WriteLine("1 - сортировка выбором");
            Console.WriteLine("2 - сортировка пузырьком");
            Console.WriteLine("3 - сортировка вставкой");
            Console.WriteLine("4 - сортировка Шелла");
            Console.WriteLine("5 - пирамидальная сортировка");
            Console.WriteLine("6 - сортировка слиянием");
            Console.WriteLine("7 - быстрая сортировка"); // ?
            Console.WriteLine("8 - сортировка подсчётом"); // ?
            Console.WriteLine("9 - поразрядная сортировка"); // ?
        }

        static int[] ArrayInit()
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
            Console.WriteLine("}");
        }

        static void Main(string[] args)
        {
            ArraySorter sorter = new ArraySorter();

            int[] array = ArrayInit();

            Console.WriteLine("Сгенерированный массив:");
            ConsoleWriteArray(array);

            ConsoleWriteSort();

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    sorter.Strategy = new SelectionSortStrategy();
                    break;

                case 2:
                    sorter.Strategy = new BubbleSortStrategy();
                    break;

                case 3:
                    sorter.Strategy = new InsertSortStrategy();
                    break;

                case 4:
                    sorter.Strategy = new ShellSortStrategy();
                    break;

                case 5:
                    sorter.Strategy = new HeapSortStrategy();
                    break;

                case 6:
                    sorter.Strategy = new MergeSortStrategy();
                    break;

                case 7:
                    sorter.Strategy = new QuickSortStrategy();
                    break;

                case 8:
                    sorter.Strategy = new CountingSortStrategy();
                    break;

                case 9:
                    sorter.Strategy = new RadixSortStrategy();
                    break;

                default:
                    break;
            }

            sorter.Sort(ref array);

            Console.WriteLine("Остортированный массив:");
            ConsoleWriteArray(array);

            Console.ReadKey();
        }
    }
}
