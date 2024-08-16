using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    internal class QuickSort
    {
        private int[] num;

        public QuickSort(int[] num)
        {
            this.num = num;
        }

        public void QuickSortImpl(int[] array, int low, int high)
        {
            if (low < high)
            {
                // Partition the array
                int pivotIndex = Partition(array, low, high);

                // Recursively sort elements before partition and after partition
                QuickSortImpl(array, low, pivotIndex - 1);
                QuickSortImpl(array, pivotIndex + 1, high);
            }
        }

        private int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    Swap(ref array[i], ref array[j]);
                }
            }

            Swap(ref array[i + 1], ref array[high]);
            return i + 1;
        }

        private void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public void Sort()
        {
            Console.WriteLine("");
            Console.WriteLine(String.Join(",",num));
            QuickSortImpl(num, 0, num.Length - 1);
            Console.WriteLine("");
            Console.WriteLine(String.Join(",", num));
        }
    }
}
