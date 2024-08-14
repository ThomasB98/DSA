using System;

namespace LinkedList
{
    internal class ReorderList1
    {

        static void Main(string[] args)
        {
            SingleyLinkListImpl singleyLinkList = new SingleyLinkListImpl();

            singleyLinkList.insertNodeAtFirst(1);
            singleyLinkList.insertNodeAtLast(2);
            singleyLinkList.insertNodeAtLast(3);
            singleyLinkList.insertNodeAtLast(4);
            singleyLinkList.insertNodeAtLast(5);
            singleyLinkList.insertNodeAtLast(6);
            singleyLinkList.insertNodeAtLast(7);

            Console.WriteLine("Original List:");
            singleyLinkList.display();

            singleyLinkList.reorderLinkList();

            Console.WriteLine("Reordered List:");
            singleyLinkList.display();
        }
    }

    

    class SingleyLinkListImpl
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
        private Node head = null;

        public void display()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " -> ");
                temp = temp.next;
            }
            Console.WriteLine("null");
        }

        public void insertNodeAtFirst(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
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

        public void reorderLinkList()
        {
            if (head == null || head.next == null) return;

            // Step 1: Find the middle of the list
            Node slow = head, fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            // Step 2: Split the list into two halves
            Node head2 = slow.next;
            slow.next = null;

            // Step 3: Reverse the second half
            head2 = reverseLinkList(head2);

            // Step 4: Merge the two halves
            mergeLinkLists(head, head2);
        }

        private Node reverseLinkList(Node head)
        {
            Node prev = null, current = head, next = null;

            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }

            return prev;
        }

        private void mergeLinkLists(Node l1, Node l2)
        {
            while (l1 != null && l2 != null)
            {
                Node l1Next = l1.next;
                Node l2Next = l2.next;

                l1.next = l2;

                if (l1Next == null) break;

                l2.next = l1Next;

                l1 = l1Next;
                l2 = l2Next;
            }
        }
    }
}
