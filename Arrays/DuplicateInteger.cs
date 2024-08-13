using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Given an integer array nums, return true if any value appears more than once in the array, otherwise return false.
namespace Arrays
{
    internal class DuplicateInteger
    {
        static void Main(string[] args)
        {
            int[] nums = [1, 2, 3, 4];
            int count = 0;
            if (nums.Length == 1)
            {
                Console.WriteLine("false");
                return;
            }

            Hashtable hashtable = new Hashtable();  

            for (int i = 0; i < nums.Length; i++)
            {
                if (hashtable.ContainsKey(nums[i]))
                {
                    Console.WriteLine("true");
                    return;
                }
                else
                {
                    hashtable.Add(nums[i],1);
                }
            }

            Console.WriteLine("false");

        }
    }
}
