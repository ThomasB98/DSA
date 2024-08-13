using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Find the minimum and maximum sum of N-1 elements of the array
namespace Arrays
{
    internal class FindMinMaxSumN_1Elements
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            arr = [9,8,6,3,2,5,7,4,1,10];

            int MinSum=0;
            int MaxSum=0;

            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    MinSum=MinSum+arr[i];               
                }
                if(i== arr.Length - 1)
                {
                    MaxSum=MaxSum+arr[i];
                }
                else
                {
                    MinSum = MinSum + arr[i];
                    MaxSum = MaxSum + arr[i];
                }

            }

            Console.WriteLine($"Sum of n-1 Min elements is {MinSum}");
            Console.WriteLine($"Sum of n-1 Max elements is {MaxSum}");
        }
    }
}
