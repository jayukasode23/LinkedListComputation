using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProgram
{
    public class SearchLinkedList
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

        //Search method

        public Node Search(int data)
        {

            while (head != null)
            {
                if (head.data == data)
                {
                    Console.WriteLine("Searched element is present in linked list : {0}", data);
                }

                head = head.next;
            }
            return null;
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

