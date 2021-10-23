using System;
using System.Collections.Generic;
using System.Text;

namespace BRP_Program
{
    public class linkedlist
    
{ 
        public void linklist()
        {



            // Create a list of strings  
            var names = new LinkedList<string>();
            names.AddLast("Sonoo");
            names.AddLast("Ankit");
            names.AddLast("Peter");
            names.AddLast("Irfan");

            //insert new element before "Peter"  
            LinkedListNode<String> node = names.Find("Peter");
            names.AddBefore(node, "John");
            names.AddAfter(node, "Lucy");

            // Iterate list element using foreach loop  
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}