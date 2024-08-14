using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace searching
{
    internal class LinearSearch
    {
        int[] num;
        public LinearSearch(int[] num)
        {
            this.num = num;
        }

        public void LinearSearchIMPL()
        {
            Console.WriteLine(String.Join(",",num));
            Console.WriteLine("ENTER ELEMENT TO SEARCH");
            int target=int.Parse(Console.ReadLine());


            for(int i = 0; i < num.Length; i++)
            {
                if(num[i] == target)
                {
                    Console.WriteLine("element found at position "+(i+1));
                    return;
                }
               
            }
            Console.WriteLine("Element not found");

        }
    }
}
