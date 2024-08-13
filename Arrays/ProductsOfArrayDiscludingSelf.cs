using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Given an integer array nums, return an array output 
where output[i] is the product of all the elements of nums except nums[i].

Each product is guaranteed to fit in a 32-bit integer.
Given an integer array nums, return an array output 
where output[i] is the product of all the elements of nums except nums[i].

Each product is guaranteed to fit in a 32-bit integer.*/


namespace Arrays_Basic
{
    internal class ProductsOfArrayDiscludingSelf
    {
        static void Main(string[] args)
        {
            int[] nums = [1, 2, 4, 6];

            int[] nums2 = new int[nums.Length];

            int prefix = 1;
            int postfix = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    nums2[i] = 0;
                }
                else
                {
                    prefix = prefix * nums[i - 1];
                    nums2[i] = prefix;
                }
            }

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if(i== nums.Length - 1)
                {
                    continue;
                }
                else
                {
                    if (nums2[i] == 0)
                    {
                        postfix = postfix * nums[i + 1];
                        nums2[i] = postfix;
                    }
                    else
                    {
                        postfix = postfix * nums[i + 1];
                        nums2[i] = nums2[i] * postfix;
                    }
                    

                }
            }

            Console.WriteLine(string.Join(", ", nums2));

        }
    }
}
