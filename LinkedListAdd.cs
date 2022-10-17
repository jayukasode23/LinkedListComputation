using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProgram
{
    internal class LinkedListAdd
    {
        public Node head;

        //Insert The a new Node at front of the list.
        public void Add(int newdata)
        {
            //Allocate the Node and put in the data.
            Node newnode = new Node(newdata);
            //Make next of the new Node as head.
            newnode.next = head;
            //Move the head to point to new Node.
            head = newnode;
        }
        //This function display content of linked list starting from the given Node.
        public void Display()
        {
            Node tnode = head;
            while (tnode != null)
            {
                Console.Write("{0}->", tnode.data);
                tnode = tnode.next;
            }
        }
    }
}
