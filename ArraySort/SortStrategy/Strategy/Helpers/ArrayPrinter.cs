using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySort
{
    public static class ArrayPrinter
    {
        public static void Print(int[] array)
        {
            foreach(int elem in array)
                Console.Write(elem + " ");

            Console.WriteLine();
        }
    }
}
