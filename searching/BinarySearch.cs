using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace searching
{
    internal class BinarySearch
    {
        int[] num;
        public BinarySearch(int[] num)
        {
            this.num = num;
        }   
        public void BinarySearchImpl()
        {
            Console.WriteLine("ENTER TARGET ELEMENT");
            int target=int.Parse(Console.ReadLine());
            Array.Sort(num);
            int start = 0;
            int end = num.Length;
            while (start < end)
            {
                int mid=(start+end)/2;
                if (target == num[mid])
                {
                    Console.WriteLine("Element found");
                    return;
                }
                else
                {
                    if(target< num[mid])
                    {
                        end = mid-1;
                        mid= (start + end) / 2;
                    }
                    else
                    {
                        start = mid + 1;
                        mid = (start + end) / 2;
                    }
                }               
            }
            Console.WriteLine("Element not found");
        }
    }
}
