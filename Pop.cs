using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProgram
{
    public class Pop
    {
        //head is used as node start point
        Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("Element added in linkedlist is : {0} ", +node.data, " ");
        }

        //Delete Last Element from the Linked List using PopLast Method

        public void popLast()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
            }

            Node newnode = head;

            while (newnode.next.next != null)
            {
                newnode = newnode.next;
            }
            Node popLast = newnode.next;
            newnode.next = null;
        }

        //Display Method is Used to Display elements.

        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("Linked List is Empty");
            }
            else
            {
                Console.WriteLine("Output For Linked List :");

                Node temp = head;
                while (temp != null)
                {
                    Console.WriteLine(temp.data + " ");
                    temp = temp.next;

                }
            }
        }
    }
}

