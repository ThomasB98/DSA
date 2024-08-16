using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    internal class BubbleSort
    {
        int[] num;
        public BubbleSort(int [] num)
        {
            this.num = num;
            
        }

        public void BubbleSortImpl()
        {
            Console.WriteLine(String.Join(",", num));
            Console.WriteLine("");
            for (int i = 0; i < num.Length-1; i++)
            {
                for (int j = 0; j < num.Length-i-1; j++)
                {
                    if (num[j] > num[j + 1])
                    {
                        int temp = num[j];
                        num[j]= num[j + 1];
                        num[j+1]= temp;
                    }
                }
            }

            Console.WriteLine(String.Join(",", num));
            Console.WriteLine("");

        }
    }
}
