using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEM4_LR3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            ConsoleInitArray(out int[] array);

            Console.WriteLine("\nСгенерированный массив:");
            ConsoleWriteArray(array);
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
    }
}
