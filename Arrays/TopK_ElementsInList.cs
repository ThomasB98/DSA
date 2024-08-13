using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Given an integer array nums and an integer k, return the k most frequent elements within the array.
The test cases are generated such that the answer is always unique.
You may return the output in any order.*/

namespace Arrays_Basic
{
    internal class TopK_ElementsInList
    {
        static void Main(string[] args)
        {
            int[] nums = [1, 2, 2, 3, 3, 3]; 
            int k = 3;

            Array.Sort(nums);

            int start = nums.Length - k;

            for (int i = start; i < nums.Length; i++)
            {
                Console.Write(nums[i]+" ");
            }
        }
    }
}
