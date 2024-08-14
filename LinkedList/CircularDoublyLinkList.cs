using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LinkedList
{
    internal class CircularDoublyLinkList
    {
        class Node
        {
            public int data;
            public Node next;
            public Node prev;
            public Node(int data)
            {
                this.data = data;
                this.next = null;
                this.prev = null;
            }
        }
        static void Main(string[] args)
        {
            bool flag = true;

            CircularDoublyLinkListImpl cdll = new CircularDoublyLinkListImpl();

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
                Console.WriteLine("7. Display Circular Doubly Linked List");
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
                        cdll.insertFirst(data);
                        Console.WriteLine("");
                        break;
                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine("ENTER A VALUE");
                        data = int.Parse(Console.ReadLine());
                        cdll.insertLast(data);
                        Console.WriteLine("");
                        break;
                    case 3:
                        Console.WriteLine("");
                        Console.WriteLine("ENTER A VALUE");
                        data = int.Parse(Console.ReadLine());
                        Console.WriteLine("ENTER POSITION");
                        int pos = int.Parse(Console.ReadLine());
                        cdll.insertAtPosition(data, pos);
                        Console.WriteLine("");
                        break;
                    case 4:
                        Console.WriteLine("");
                        cdll.deleteFirst();
                        Console.WriteLine("Delete successful");
                        Console.WriteLine("");
                        break;
                    case 5:
                        Console.WriteLine("");
                        cdll.deleteLast();
                        Console.WriteLine("Delete successful");
                        Console.WriteLine("");
                        break;
                    case 6:
                        Console.WriteLine("");
                        Console.WriteLine("ENTER POSITION");
                        pos = int.Parse(Console.ReadLine());
                        cdll.deletePosition(pos);
                        Console.WriteLine("Delete successful");
                        Console.WriteLine("");
                        break;
                    case 7:
                        Console.WriteLine("");
                        cdll.display();
                        Console.WriteLine("");
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
    }

    

    class CircularDoublyLinkListImpl
    {
        private Node head = null;
        private Node tail = null;
        private int length = 0;

        public void insertFirst(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
                head.next = head;
                head.prev = head;
            }
            else
            {
                newNode.next = head;
                newNode.prev = tail;
                head.prev = newNode;
                tail.next = newNode;
                head = newNode;
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
                newNode.prev = tail;
                newNode.next = head;
                tail.next = newNode;
                head.prev = newNode;
                tail = newNode;
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
                newNode.prev = temp;
                temp.next.prev = newNode;
                temp.next = newNode;
                length++;
            }
        }

        public void deleteFirst()
        {
            if (head == null)
            {
                Console.WriteLine("Circular Doubly Linked List is EMPTY");
                return;
            }

            if (length == 1)
            {
                head = null;
                tail = null;
            }
            else
            {
                head = head.next;
                head.prev = tail;
                tail.next = head;
            }
            length--;
        }

        public void deleteLast()
        {
            if (head == null)
            {
                Console.WriteLine("Circular Doubly Linked List is EMPTY");
                return;
            }

            if (length == 1)
            {
                deleteFirst();
            }
            else
            {
                tail = tail.prev;
                tail.next = head;
                head.prev = tail;
                length--;
            }
        }

        public void deletePosition(int pos)
        {
            if (pos < 1 || pos > length)
            {
                Console.WriteLine("Invalid position");
                return;
            }

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
                temp.next.prev = temp;
                length--;
            }
        }

        public void display()
        {
            if (head == null)
            {
                Console.WriteLine("Circular Doubly Linked List is EMPTY");
                return;
            }

            Node temp = head;
            do
            {
                Console.Write(temp.data + " -> ");
                temp = temp.next;
            } while (temp != head);
            Console.WriteLine("(back to head)");
        }
    }
}
