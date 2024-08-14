using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class DoublyLinkList
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
            bool flag=true;

            DoublyLinkListImpl dll=new DoublyLinkListImpl();

            while (flag)
            {
                Console.WriteLine("");
                Console.WriteLine("SELECT AN OPTION");
                Console.WriteLine("");
                Console.WriteLine("0.exit");
                Console.WriteLine("1.Insert at First");
                Console.WriteLine("2.Insert at Last");
                Console.WriteLine("3.Insert at Position");
                Console.WriteLine("4.Delete First");
                Console.WriteLine("5.Delete Last");
                Console.WriteLine("6.Delete At Position");
                Console.WriteLine("7.Display Doubly Link list");
                Console.WriteLine("");
                int option =int.Parse(Console.ReadLine());

                switch(option)
                {
                    case 0:
                        Console.WriteLine("shuting down program");
                        flag = false;
                        break;
                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine("ENTER A VALUE");
                        int data= int.Parse(Console.ReadLine());
                        dll.insertFirst(data);
                        Console.WriteLine("");
                        break;
                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine("ENTER A VALUE");
                        data = int.Parse(Console.ReadLine());
                        dll.insertLast(data);
                        Console.WriteLine("");
                        break;
                    case 3:
                        Console.WriteLine("");
                        Console.WriteLine("ENTER A VALUE");
                        data = int.Parse(Console.ReadLine());
                        Console.WriteLine("ENTER POSITION");
                        int pose= int.Parse(Console.ReadLine());
                        dll.insertAtPosition(data, pose);
                        Console.WriteLine("");
                        break;
                    case 4:
                        Console.WriteLine("");
                        dll.deleteFirst();
                        Console.WriteLine("Delete succesfull");
                        Console.WriteLine("");
                        break;
                    case 5:
                        Console.WriteLine("");
                        dll.deleteLast();
                        Console.WriteLine("Delete succesfull");
                        Console.WriteLine("");
                        break;
                    case 6:
                        Console.WriteLine("");
                        Console.WriteLine("ENTER POSITION");
                        pose = int.Parse(Console.ReadLine());
                        dll.deletePosition(pose);
                        Console.WriteLine("Delete succesfull");
                        Console.WriteLine("");
                        break;
                    case 7:
                        Console.WriteLine("");
                        dll.display();
                        Console.WriteLine("");
                        break;
                    default:
                        Console.WriteLine("invalid option");
                        break;

                }
            }
        }
    }

    

    class DoublyLinkListImpl
    {
        private Node head = null;
        private Node temp;
        private Node tail;
        int length = 0;

        public void insertFirst(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                tail = head;
            }
            else
            {
                head.prev = newNode;
                newNode.next = head;
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
                tail.next = newNode;
                newNode.prev = tail;
                tail = newNode;
            }
            length++;
        }

        public void insertAtPosition(int data,int posi)
        {
            Node newNode = new Node(data);
            temp = head;
            if ((posi < 1 || posi > length + 1))
            {
                insertFirst(data);
            }
            else if (posi == length+1)
            {
                insertLast(data);
            }
            else
            {
                temp = head;
                for (int i = 1; i < posi - 1; i++)
                {
                    temp = temp.next;
                }
                newNode.next = temp.next;
                newNode.prev = temp;
                if (temp.next != null)
                {
                    temp.next.prev = newNode;
                }
                temp.next = newNode;
                length++;
            }
        }

        public void deleteFirst()
        {
            if(head== null)
            {
                Console.WriteLine("Doubly Link list is EMPTY");
            }
            else
            {
                if (length == 1)
                {
                    head = null; 
                }
                else
                {
                    head=head.next;
                    head.prev = null;
                }
                length--;
            }
        }

        public void deleteLast()
        {
            if (head == null)
            {
                Console.WriteLine("Invalid");
            }
            else
            {
                if(length == 1)
                {
                    deleteFirst();
                }
                else
                {
                    tail = tail.prev;
                    tail.next = null;
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
                else if(pos == length)
                {
                    deleteLast();
                }
                else
                {
                    temp = head;
                    for(int i = 1; i < pos - 1; i++)
                    {
                        temp=temp.next;
                    }
                    temp.next = temp.next.next;
                    temp.next.prev = temp;
                    length--;
                }
            }
        }
        public void display()
        {
            temp = head;
            while (temp != null)
            {
                Console.Write(temp.data+" ->");
                temp = temp.next;
            }
            Console.WriteLine(" null");
        }
    }
}
