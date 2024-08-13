using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Given an array of integers nums and an integer target, return the 
indices i and j such that nums[i] + nums[j] == target and i != j.
You may assume that every input has exactly one pair of indices i and j that satisfy the condition.
Return the answer with the smaller index first.Given an array of integers 
nums and an integer target, return the indices i and j such that nums[i] + nums[j] == target and i != j.
You may assume that every input has exactly one pair of indices i and j that satisfy the condition.
Return the answer with the smaller index first.*/


namespace Arrays_Basic
{
    internal class TwoIntegerSum
    {
        static void Main(string[] args)
        {
            int[] nums = [3, 4, 5, 6];
            int target = 7;

            int i = 0;
            int j = 0;

            while (i < nums.Length)
            {
                for (j = i + 1; j < nums.Length; j++)
                {
                    if(nums[j]+ nums[i] == target)
                    {
                        Console.WriteLine($"{nums[j]} {nums[i]}");
                        return;
                    }
                }
                i++;
            }


        }
    }
}
