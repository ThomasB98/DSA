using System;
using System.Collections.Generic;
using System.Linq;

namespace Arrays_Basic
{
    internal class LongestConsecutiveSequence
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 20, 4, 10, 3, 4, 5 };
            HashSet<int> set = nums.ToHashSet();
            int MaxLength = 0;

            Console.WriteLine(string.Join(", ", set));

            foreach (int num in nums)
            {
       
                if (!set.Contains(num - 1))
                {
                    int currentNum = num;
                    int currentLength = 1;

                    while (set.Contains(currentNum + 1))
                    {
                        currentNum += 1;
                        currentLength += 1;
                    }


                    MaxLength = Math.Max(currentLength, MaxLength);
                }
            }

            Console.WriteLine("The length of the longest consecutive sequence is: " + MaxLength);
        }
    }
}
