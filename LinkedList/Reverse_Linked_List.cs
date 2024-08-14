using System;

namespace LinkedList
{
    internal class Reverse_Linked_List
    {
        class Node
        {
            public int Data;
            public Node next;

            public Node(int data)
            {
                this.Data = data;
                next = null;
            }
        }

        class SinglyLinkedList
        {
            Node head = null;

            public void insertNodeAtFirst(int data)
            {
                Node newNode = new Node(data);
                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    newNode.next = head;
                    head = newNode;
                }
            }

            public void insertNodeAtLast(int data)
            {
                Node newNode = new Node(data);
                if (head == null)
                {
                    head = newNode; 
                }
                else
                {
                    Node temp = head;
                    while (temp.next != null) 
                    {
                        temp = temp.next;
                    }
                    temp.next = newNode; 
                }
            }

            public void reverseLinkList()
            {
                Node prev = null;
                Node current = head;
                Node next = null;

                while (current != null)
                {
                    next = current.next; 
                    current.next = prev; 
                    prev = current; 
                    current = next; 
                }

                head = prev; 
            }

            public void display()
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.Write(temp.Data + " -> ");
                    temp = temp.next;
                }
                Console.WriteLine("null");
            }
        }

        static void Main(string[] args)
        {
            SinglyLinkedList sll = new SinglyLinkedList();
            sll.insertNodeAtFirst(1);

            sll.insertNodeAtLast(2);
            sll.insertNodeAtLast(3);
            sll.insertNodeAtLast(4);
            sll.insertNodeAtLast(5);
            sll.insertNodeAtLast(6);

            Console.WriteLine("Original LinkedList:");
            sll.display();

            Console.WriteLine("Reversing LinkedList...");
            sll.reverseLinkList();
            sll.display();
        }
    }
}
