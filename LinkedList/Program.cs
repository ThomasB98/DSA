namespace LinkedList
{
    internal class Program
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

        class SignlyLinkedList
        {
            Node head = null;
            Node temp = null;

            public void insertNodeAtFirst(int data)
            {
                Node newNode =new Node(data);
                if(head == null)
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
                    head = newNode; // If the list is empty, the new node becomes the head
                }
                else
                {
                    temp = head;
                    while (temp.next != null) // Traverse to the last node
                    {
                        temp = temp.next;
                    }
                    temp.next = newNode; // Set the next of the last node to the new node
                }
            }

            public void removeNodeAtFirst()
            {
                head = head.next;
            }

            public void removeNodeAtLast()
            {
                if (head == null)
                {
                    Console.WriteLine("Linked list is empty can not remove");

                }
                else
                {
                    Node prev = head;
                    temp = head.next;

                    while (temp != null)
                    {
                        prev = prev.next;
                        temp = temp.next;
                    }

                    prev.next = null;
                }
               
            }

            public void insertAtPosition(int data,int position)
            {
                if (head == null)
                {
                    Console.WriteLine("Not Possible");
                    return;
                }
                else
                {
                    int length = LinkListLength();
                    if (position > length + 2)
                    {
                        Console.WriteLine("not possible");
                        return;
                    }
                    else
                    {
                        if (position == length + 1)
                        {
                            temp = head.next;

                            while (temp.next != null)
                            {
                                temp = temp.next;
                            }

                            Node newNode = new Node(data);
                            temp.next = newNode;
                        }
                        else
                        {
                            Node prev = head;
                            temp = head.next;

                            while (temp.next != null)
                            {
                                prev = prev.next;
                                temp = temp.next;
                            }

                            Node newNode = new Node(data);
                            prev.next = newNode;
                            newNode.next = temp;
                        }
                    }
                }
            }


            public void deleteAtPosition(int position)
            {
                if (head == null)
                {
                    Console.WriteLine("Not possible");                 
                }
                else
                {
                    int length=LinkListLength();
                    if (position > length)
                    {
                        Console.WriteLine("Not possible");

                    }
                    else if (length == position)
                    {
                        removeNodeAtLast();
                    }
                    else
                    {
                        Node prev = head;
                        temp = head.next;

                        while (temp != null)
                        {
                            prev = prev.next;
                            temp = temp.next;
                        }

                        prev.next = temp.next;
                    }
                }
            }

            public int LinkListLength()
            {
                int length = 0;
                temp = head;
                while (temp != null)
                {
                    length++;
                    temp = temp.next;
                }
                return length;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
           SignlyLinkedList sll=new SignlyLinkedList();

            sll.insertNodeAtFirst(1);
            sll.insertNodeAtLast(2);


        }
    }
}
