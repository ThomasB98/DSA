using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class MergeTwoSortedLists
    {
        class Node
        {
            public int Data;
            public Node Next;

            public Node(int data)
            {
                this.Data = data;
                this.Next = null;
            }
        }

        class LinkedList
        {
            public Node Head;

            public void AddLast(int data)
            {
                Node newNode = new Node(data);
                if (Head == null)
                {
                    Head = newNode;
                }
                else
                {
                    Node temp = Head;
                    while (temp.Next != null)
                    {
                        temp = temp.Next;
                    }
                    temp.Next = newNode;
                }
            }

            public void Display()
            {
                Node temp = Head;
                while (temp != null)
                {
                    Console.Write(temp.Data + " -> ");
                    temp = temp.Next;
                }
                Console.WriteLine("null");
            }
        }

        static void Main(string[] args)
        {
            // Create two sorted linked lists
            LinkedList list1 = new LinkedList();
            list1.AddLast(1);
            list1.AddLast(3);
            list1.AddLast(5);

            LinkedList list2 = new LinkedList();
            list2.AddLast(2);
            list2.AddLast(4);
            list2.AddLast(6);

            // Display the original lists
            Console.WriteLine("List 1:");
            list1.Display();

            Console.WriteLine("List 2:");
            list2.Display();

            // Merge the two sorted lists
            Node mergedHead = MergeTwoSorted(list1.Head, list2.Head);

            // Display the merged list
            Console.WriteLine("Merged List:");
            LinkedList mergedList = new LinkedList { Head = mergedHead };
            mergedList.Display();
        }


        static Node MergeTwoSorted(Node list1, Node list2)
        {
            // If either list is empty, return the other list
            if (list1 == null) return list2;
            if (list2 == null) return list1;

            // Initialize a dummy node to help build the merged list
            Node dummy = new Node(0);
            Node current = dummy;

            // Traverse both lists
            while (list1 != null && list2 != null)
            {
                if (list1.Data <= list2.Data)
                {
                    current.Next = list1;
                    list1 = list1.Next;
                }
                else
                {
                    current.Next = list2;
                    list2 = list2.Next;
                }
                current = current.Next;
            }

            // Attach the remaining elements, if any
            if (list1 != null)
            {
                current.Next = list1;
            }
            else
            {
                current.Next = list2;
            }

            // Return the head of the merged list (skip the dummy node)
            return dummy.Next;
        }

    }
}
