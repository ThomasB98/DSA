using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Arrays_Basic
{
    internal class AnagramGroups
    {
        static void Main(string[] args)
        {
            string[] strs = { "act", "pots", "tops", "cat", "stop", "hat" };

            Hashtable ht = new Hashtable();

            foreach (string str in strs)
            {
                int[] arr = new int[26];  // Initialize a new array for each word

                foreach (char c in str)
                {
                    int position = c - 'a';
                    arr[position]++;
                }

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < arr.Length; i++)
                {
                    sb.Append(arr[i]);
                }

                string key = sb.ToString();
                if (ht.ContainsKey(key))
                {
                    List<string> stringList = (List<string>)ht[key];
                    stringList.Add(str);
                }
                else
                {
                    ht.Add(key, new List<string> { str });
                }
            }

            // Print the Hashtable
            foreach (DictionaryEntry entry in ht)
            {
                string key = (string)entry.Key;
                List<string> values = (List<string>)entry.Value;

                Console.WriteLine($"{key}: {string.Join(", ", values)}");
            }
        }
    }
}
