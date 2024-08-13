using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LinkedList
{
    internal class CircularLinkList
    {
        class Node
        {
            public int data;
            public Node next;
            public Node(int data)
            {
                this.data = data;
                this.next = null;
            }
        }
        static void Main(string[] args)
        {
            bool flag = true;

            CircularLinkListImpl cll = new CircularLinkListImpl();

            while (flag)
            {
                Console.WriteLine("");
                Console.WriteLine("SELECT AN OPTION");
                Console.WriteLine("");
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Insert at First");
                Console.WriteLine("2. Insert at Last");
                Console.WriteLine("3. Insert at Position");
                Console.WriteLine("4. Delete First");
                Console.WriteLine("5. Delete Last");
                Console.WriteLine("6. Delete At Position");
                Console.WriteLine("7. Display Circular Link list");
                Console.WriteLine("");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 0:
                        Console.WriteLine("Shutting down program");
                        flag = false;
                        break;
                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine("ENTER A VALUE");
                        int data = int.Parse(Console.ReadLine());
                        cll.insertFirst(data);
                        Console.WriteLine("");
                        break;
                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine("ENTER A VALUE");
                        data = int.Parse(Console.ReadLine());
                        cll.insertLast(data);
                        Console.WriteLine("");
                        break;
                    case 3:
                        Console.WriteLine("");
                        Console.WriteLine("ENTER A VALUE");
                        data = int.Parse(Console.ReadLine());
                        Console.WriteLine("ENTER POSITION");
                        int pose = int.Parse(Console.ReadLine());
                        cll.insertAtPosition(data, pose);
                        Console.WriteLine("");
                        break;
                    case 4:
                        Console.WriteLine("");
                        cll.deleteFirst();
                        Console.WriteLine("Delete successful");
                        Console.WriteLine("");
                        break;
                    case 5:
                        Console.WriteLine("");
                        cll.deleteLast();
                        Console.WriteLine("Delete successful");
                        Console.WriteLine("");
                        break;
                    case 6:
                        Console.WriteLine("");
                        Console.WriteLine("ENTER POSITION");
                        pose = int.Parse(Console.ReadLine());
                        cll.deletePosition(pose);
                        Console.WriteLine("Delete successful");
                        Console.WriteLine("");
                        break;
                    case 7:
                        Console.WriteLine("");
                        cll.display();
                        Console.WriteLine("");
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
    }

    

    class CircularLinkListImpl
    {
        private Node head = null;
        private Node tail = null;
        int length = 0;

        public void insertFirst(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                tail = head;
                tail.next = head; // Point tail to head to make it circular
            }
            else
            {
                newNode.next = head;
                head = newNode;
                tail.next = head; // Update the tail to point to the new head
            }
            length++;
        }

        public void insertLast(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                insertFirst(data);
            }
            else
            {
                tail.next = newNode;
                tail = newNode;
                tail.next = head; // Point the new tail to head to maintain the circularity
            }
            length++;
        }

        public void insertAtPosition(int data, int pos)
        {
            if (pos < 1 || pos > length + 1)
            {
                Console.WriteLine("Invalid position");
                return;
            }

            if (pos == 1)
            {
                insertFirst(data);
            }
            else if (pos == length + 1)
            {
                insertLast(data);
            }
            else
            {
                Node newNode = new Node(data);
                Node temp = head;

                for (int i = 1; i < pos - 1; i++)
                {
                    temp = temp.next;
                }

                newNode.next = temp.next;
                temp.next = newNode;
                length++;
            }
        }

        public void deleteFirst()
        {
            if (head == null)
            {
                Console.WriteLine("Circular Linked List is EMPTY");
            }
            else
            {
                if (length == 1)
                {
                    head = null;
                    tail = null;
                }
                else
                {
                    head = head.next;
                    tail.next = head; // Update tail to point to the new head
                }
                length--;
            }
        }

        public void deleteLast()
        {
            if (head == null)
            {
                Console.WriteLine("Circular Linked List is EMPTY");
            }
            else
            {
                if (length == 1)
                {
                    deleteFirst();
                }
                else
                {
                    Node temp = head;
                    while (temp.next != tail)
                    {
                        temp = temp.next;
                    }

                    temp.next = head;
                    tail = temp; // Update tail to the previous node
                    length--;
                }
            }
        }

        public void deletePosition(int pos)
        {
            if (head == null || pos < 1 || pos > length)
            {
                Console.WriteLine("Invalid operation");
            }
            else
            {
                if (pos == 1)
                {
                    deleteFirst();
                }
                else if (pos == length)
                {
                    deleteLast();
                }
                else
                {
                    Node temp = head;
                    for (int i = 1; i < pos - 1; i++)
                    {
                        temp = temp.next;
                    }

                    temp.next = temp.next.next;
                    length--;
                }
            }
        }

        public void display()
        {
            if (head == null)
            {
                Console.WriteLine("Circular Linked List is EMPTY");
                return;
            }

            Node temp = head;
            do
            {
                Console.Write(temp.data + " -> ");
                temp = temp.next;
            } while (temp != head);

            Console.WriteLine("HEAD");
        }
    }
}

