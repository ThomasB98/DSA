using System;
using System.Collections.Generic;

namespace Hash_Table
{
    internal class _Dictionary
    {
        static void Main(string[] args)
        {
            Dictionary<int, String> dic = new Dictionary<int, String>();

            bool flag = true;

            while (flag)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Remove");
                Console.WriteLine("3. Check if Key Exists");
                Console.WriteLine("4. Check if Value Exists");
                Console.WriteLine("5. Clear");
                Console.WriteLine("6. Print All");

                int options = int.Parse(Console.ReadLine());

                switch (options)
                {
                    case 0:
                        Console.WriteLine("\nExiting...");
                        flag = false;
                        break;

                    case 1:
                        Console.WriteLine("\nAdd Key:");
                        int key = int.Parse(Console.ReadLine());
                        Console.WriteLine("Add Value:");
                        string value = Console.ReadLine();

                        if (!dic.ContainsKey(key))
                        {
                            dic.Add(key, value);
                            Console.WriteLine("Entry added successfully.\n");
                        }
                        else
                        {
                            Console.WriteLine("Key already exists. Entry not added.\n");
                        }
                        break;

                    case 2:
                        Console.WriteLine("\nRemove Key:");
                        key = int.Parse(Console.ReadLine());

                        if (dic.Remove(key))
                        {
                            Console.WriteLine("Entry removed successfully.\n");
                        }
                        else
                        {
                            Console.WriteLine("Key not found. Nothing removed.\n");
                        }
                        break;

                    case 3:
                        Console.WriteLine("\nCheck if Key Exists:");
                        key = int.Parse(Console.ReadLine());

                        if (dic.ContainsKey(key))
                        {
                            Console.WriteLine("Key exists.\n");
                        }
                        else
                        {
                            Console.WriteLine("Key does not exist.\n");
                        }
                        break;

                    case 4:
                        Console.WriteLine("\nCheck if Value Exists:");
                        value = Console.ReadLine();

                        if (dic.ContainsValue(value))
                        {
                            Console.WriteLine("Value exists.\n");
                        }
                        else
                        {
                            Console.WriteLine("Value does not exist.\n");
                        }
                        break;

                    case 5:
                        dic.Clear();
                        Console.WriteLine("Dictionary cleared.\n");
                        break;

                    case 6:
                        Console.WriteLine("\nDictionary contents:");
                        foreach (var kvp in dic)
                        {
                            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
                        }
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("\nInvalid option. Please try again.\n");
                        break;
                }
            }
        }
    }
}
