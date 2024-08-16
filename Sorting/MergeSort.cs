using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sorting
{
    internal class MergeSort
    {
        int[] array;
        public MergeSort(int[] num)
        {
            this.array = num;
        }
        public void Sort()
        {
            Console.WriteLine("");
            Console.WriteLine("Before sorting");
            Console.WriteLine(String.Join(",", array));
            MergeSortImpl(array, 0, array.Length - 1);
            Console.WriteLine("After sorting");
            Console.WriteLine(String.Join(",", array));
            Console.WriteLine("");
        }
        public void MergeSortImpl(int[] num,int left,int right)
        {
           

            if (left < right)
            {
                int middle = (left + right) / 2;

                // Sort the left half
                MergeSortImpl(array, left, middle);

                // Sort the right half
                MergeSortImpl(array, middle + 1, right);

                // Merge the sorted halves
                Merge(array, left, middle, right);
            }
            
        }

        private void Merge(int[] array, int left, int middle, int right)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            Array.Copy(array, left, leftArray, 0, n1);
            Array.Copy(array, middle + 1, rightArray, 0, n2);

            int i = 0, j = 0, k = left;

            while (i < n1 && j < n2)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    array[k] = leftArray[i];
                    i++;
                }
                else
                {
                    array[k] = rightArray[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                array[k] = leftArray[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                array[k] = rightArray[j];
                j++;
                k++;
            }
        }

 
    
    }
}
