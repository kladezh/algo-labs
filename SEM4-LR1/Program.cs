using System;

namespace SEM4_LR1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the numbers radix:");
            int radix = int.Parse(Console.ReadLine());

            Console.Write("Input the numbers range:");
            int range = int.Parse(Console.ReadLine());

            Console.Write("Input the step:");
            int step = int.Parse(Console.ReadLine());
            double averageSum = 0;

            int[] array = new int[radix];
            for (int i = 0; i < array.Length; i++)
                array[i] = 0;

            Console.WriteLine("\nNumbers:");

            int counter = 1;
            while (true)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i]);
                }


                if (counter == 5)
                    Console.Write(" <<<<<< 5 ШАГ");

                if (counter == step)
                {
                    int sum = 0;
                    for (int i = 0; i < array.Length; i++)
                    {
                        sum += array[i];
                    }

                    averageSum = sum / (double)array.Length;

                    Console.Write($" <<<<<< {step} ШАГ СУММЫ");
                }

                Console.WriteLine();

                int k;
                for (k = radix - 1; k >= 0 && array[k] == range; k--)
                {
                    array[k] = 0;
                }

                if (k == -1) break;
                else array[k]++;

                counter++;
            }

            Console.WriteLine($"\nSUM = {averageSum}");

            Console.ReadKey();
        }
    }
}
