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
            int[] array = ConsoleInitArray();

            Console.WriteLine("\nСгенерированный массив:");
            ConsoleWriteArray(array);
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
    }
}
