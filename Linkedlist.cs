using System;
using System.Collections.Generic;
using System.Text;

namespace BRP_Program
{
    class Linkedlist
    {
        public void insert(int new_data)
        {
            Node new_node = new Node(new_data);
            if (head == null)
            {
                new_node.next = head;
                head = new_node;
            }
            else
            {
                Console.WriteLine("First Node Already Created!!"); 
            }
            public void print()
            {
                Node head_node = head;
                if (head == null)
                {
                    Console.WriteLine("LinkedList is Empty");
                }
                else
                {

                    Console.WriteLine("FirstNode is:" + head_node.data);
                    head_node = head_node.next;
                }
            }
           
}
