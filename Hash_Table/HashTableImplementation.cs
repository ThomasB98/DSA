using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table
{
    internal class HashTableImplementation
    {
        private readonly int _size;
        private readonly HashNode[] _table;

        public HashTableImplementation(int size)
        {
            _size = size;
            _table = new HashNode[_size];
        }

        private int GetIndex(int key)
        {
            return key % _size;
        }

        public void Add(int key, string value)
        {
            int index = GetIndex(key);
            HashNode newNode = new HashNode(key, value);
            if (_table[index] == null)
            {
                _table[index] = newNode;
            }
            else
            {
                HashNode current = _table[index];
                while (current.Next != null)
                {
                    if (current.Key == key)
                    {
                        throw new ArgumentException("Key already exists.");
                    }
                    current = current.Next;
                }

                if (current.Key == key)
                {
                    throw new ArgumentException("Key already exists.");
                }

                current.Next = newNode;
            }
        }

        public bool Remove(int key)
        {
            int index = GetIndex(key);

            HashNode current = _table[index];
            HashNode previous = null;

            while (current != null)
            {
                if (current.Key == key)
                {
                    if (previous == null) // Node to be removed is the first node
                    {
                        _table[index] = current.Next;
                    }
                    else
                    {
                        previous.Next = current.Next;
                    }
                    return true;
                }

                previous = current;
                current = current.Next;
            }

            return false; 
        }

        public string Get(int key)
        {
            int index = GetIndex(key);

            HashNode current = _table[index];
            while (current != null)
            {
                if (current.Key == key)
                {
                    return current.Value;
                }
                current = current.Next;
            }

            return null; 
        }

        
        public bool ContainsKey(int key)
        {
            return Get(key) != null;
        }

        public void Print()
        {
            for (int i = 0; i < _size; i++)
            {
                Console.Write($"Bucket {i}: ");
                HashNode current = _table[i];
                while (current != null)
                {
                    Console.Write($"[{current.Key}, {current.Value}] -> ");
                    current = current.Next;
                }
                Console.WriteLine("null");
            }
        }

        static void Main(string[] args)
        {
            HashTableImplementation hashTable = new HashTableImplementation(10);

            hashTable.Add(1, "One");
            hashTable.Add(2, "Two");
            hashTable.Add(3, "Three");
            hashTable.Add(11, "Eleven"); // This will collide with key 1

            hashTable.Print();

            Console.WriteLine($"\nValue for key 2: {hashTable.Get(2)}");

            Console.WriteLine("\nRemoving key 3...");
            hashTable.Remove(3);
            hashTable.Print();

            Console.WriteLine($"\nContains key 3: {hashTable.ContainsKey(3)}");
            Console.WriteLine($"Contains key 11: {hashTable.ContainsKey(11)}");
        }
    }
    public class HashNode
    {
        public int Key { get; set; }
        public string Value { get; set; }
        public HashNode Next { get; set; }

        public HashNode(int key, string value)
        {
            Key = key;
            Value = value;
            Next = null;
        }
    }
}
