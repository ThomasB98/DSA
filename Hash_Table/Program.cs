using System.Collections;

namespace Hash_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Hashtable ht = new Hashtable();

            //Add Key-Value Pairs:
            ht.Add("id", 101);
            ht.Add("name", "John Doe");
            ht.Add("age", 30);

            //Access Values by Key:
            int id = (int)ht["id"];
            string name = (string)ht["name"];
            int age = (int)ht["age"];

            Console.WriteLine($"ID: {id}, Name: {name}, Age: {age}");

            //Check if a Key Exists:
            if (ht.ContainsKey("name"))
            {
                Console.WriteLine("Name exists in the hashtable.");
            }

            //Remove a Key - Value Pair:
            ht.Remove("age");

            //Iterate Through the Hashtable:
            foreach (DictionaryEntry entry in ht)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }

            //Clear the Hashtable:
            ht.Clear();

        }
    }
}
