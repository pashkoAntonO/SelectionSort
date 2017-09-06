using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {

        public static void SelectionSort(ref int [] array)
        {
            int min, swap;

            for (int i = 0; i < array.Length; i++)
            {
                min = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[min] > array[j])
                    {
                        swap = array[min];
                        array[min] = array[j];
                        array[j] = swap;
                    }
                }
            }
        }
        static void Main(string[] args)
        {

            int[] array = new int[] { 5,15,15,24,11,55,4,1,74,157,23 };

            SelectionSort(ref array);

            foreach (int elem in array)
            {
                Console.WriteLine(elem);
            }

            Console.ReadKey();
        }
    }
}
