using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    internal class InsertionSort
    {
        int[] num;
        public InsertionSort(int[] num)
        {
            this.num = num;
        }   

        public void InsertionSortImpl()
        {
            Console.WriteLine(String.Join(",", num));
            Console.WriteLine("");
            for (int i = 1; i < num.Length; i++)
            {
                int key = num[i];
                int j=i-1;

                while(j >=0 && num[j]>key)
                {
                    num[j + 1] = num[j];
                    j = j - 1;
                }
                num[j+1] = key; 
            }

            Console.WriteLine(String.Join(",", num));
            Console.WriteLine("");
        }
    }
}
