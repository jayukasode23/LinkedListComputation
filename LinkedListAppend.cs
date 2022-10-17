using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProgram
{
    public class LinkedListAppend
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
        //Append The new Node at the end. 
        public void Append(int newdata)
        {
            //Allocate the Node and put in the data.
            Node newnode = new Node(newdata);
            //If The linkedlist is empty,then make the new node as head
            if (head == null)
            {
                head = new Node(newdata);
                return;
            }
            //This new Node is going to be the last node, So make next of it as null.
            newnode.next = null;
            //Else Transverse till the last node.
            Node last = head;

            while (last.next != null)
                last = last.next;
            last.next = newnode;
            return;

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
    