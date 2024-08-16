using System;

namespace Sorting
{
    internal class SelectionSort
    {
        private int[] num;

        public SelectionSort(int[] num)
        {
            this.num = num;
        }

        public void SelectionSortImpl()
        {
            Console.WriteLine("");
            Console.WriteLine(String.Join(",",num));
            for (int i = 0; i < num.Length; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < num.Length; j++)
                {
                    if (num[j] < num[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = num[minIndex];
                num[minIndex] = num[i];
                num[i] = temp;
            }

            Console.WriteLine("After Sorting");
            Console.WriteLine(String.Join(",", num));
        }

        
    }
}
