using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Program to find the minimum and maximum element of an array
namespace Arrays
{
    internal class FindMaxMin
    {
        static void Main(string[] args)
        {
            int[] arr=new int[10];
            arr = [98, 56, 78, 22, 49, 63, 75, 22, 66, 96];

            int max=int.MinValue;
            int min=int.MaxValue;


            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min) { 
                    min = arr[i];
                }
            }

            Console.WriteLine($"MAX value in Array is {max}");
            Console.WriteLine($"MIN value in Array is {min}");
        }
    }
}
