using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Given two strings s and t, return true if the
//two strings are anagrams of each other, otherwise return false.

//An anagram is a string that contains the exact same
//characters as another string, but the order of the characters can be different
namespace Arrays
{
    internal class IsAnagram
    {
        static void Main(string[] args)
        {
            String s = "racecar", t = "carrace";

            char[] char1 = s.ToCharArray();
            char[] char2 = t.ToCharArray();
            Array.Sort(char1);
            Array.Sort(char2);
            if (char1.Length != char2.Length) {
                Console.WriteLine("false");
                return;
            }
            for (int i = 0; i < char1.Length; i++)
            {
                if (char1[i] != char2[i])
                {
                    Console.WriteLine("false");
                    return;
                }
            }

            Console.WriteLine("true");
        }
    }
}
