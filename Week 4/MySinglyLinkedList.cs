/*
 * Week 4 - Problem 1
 * By Christopher Diaz Montoya
 * ID - 24707686
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    class MySinglyLinkedList
    {
        public int val; 
        public MySinglyLinkedList next;
        public MySinglyLinkedList head;

        // Default Constructor
        public MySinglyLinkedList()
        {
            val = 0;
            next = null;
        }
        // Constructor with parameter
        public MySinglyLinkedList(int value)
        {
            val = value;
            next = null;
        }

        // Assign head pointer to the first node
        public void AssignHead()
        {
            head = this;
        }

        // Insert a new node with a value after the current node
        public void InsertNode(MySinglyLinkedList current, int value)
        {
            MySinglyLinkedList node = new MySinglyLinkedList (value);
            if (current.next == null)
            {
                // Insert at the end and easy to handle

                // MY CODE!!

                next = new MySinglyLinkedList(value); // If node has no next
                                                      // Then next = new node, in a while loop in main so goes up to amount
                                                      // of nodes I want.
            }
            else if (value == 7)
            {
                MySinglyLinkedList temp = current.next; // Stores currents next node aka temp
                current.next = new MySinglyLinkedList(100); // Current next has new node, 100 stored
            // Node pushed after new node is current.next.next, this was the original current.next stored as temp
                current.next.next = temp; 

                return;
            }
            // MY CODE ENDS HERE!!
        }
        public void DeleteNextNode(MySinglyLinkedList current)
        {
            if (current.next == null) // There is no next node, nothing to do.
                return;
            else
            {
                // Update the next node pointer and reset the deleted node to null
                // Look lecture slides for the pseudocode for deleting a node in the middle
                try
                {
                    current.next = current.next.next;
                    return;
                }
                catch(Exception explained)
                {
                    Console.WriteLine(explained);
                    Console.WriteLine("Issue deleting node");
                }
                
                /*
                while (current != null && current.val != 3)
                {
                    if (current.val == 3)
                    {
                        MySinglyLinkedList temp = current.next;
                        current.next = current.next.next;
                        temp = null;
                    }
                    // prev = current.next;
                }
                */
                //Add your code here
            }
        }
        public void TraverseList(MySinglyLinkedList node)
        {
            //Print the values stored at the each node in the list from head to tail
            Console.WriteLine("Traversing in forward direction...");
            while (node != null)//Traverse from the current node
            {
                //Add your code here

                // MY CODE!!
                try
                {
                    if (node.next == null) // This is to not add -> at the end of the printed list
                        Console.WriteLine(node.val); // Does not print arrow to indicate next
                    else
                        Console.Write(node.val + "->");
                    node = node.next;
                }
                catch(Exception explained)
                {
                    Console.Write(explained.Message);
                    Console.Write("Problem traversing list");
                }
                // MY CODE ENDS HERE!!
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            //Create the first node as head
            MySinglyLinkedList head = new MySinglyLinkedList(1);

            //Temporary node to build the list
            MySinglyLinkedList temp = head;

            //Add 9 more consecutive nodes 2-9
            for (int i = 2; i < 10; i++) // Deleted = and replaced with < so goes up to 9
            {
                //Add your code here - I did not need to update anything here
                temp.InsertNode(temp, i); 
                temp = temp.next;
            }
            //Traverse the linked list from head to tail
            head.TraverseList(head);

            /*Add your code here - I did not need to add code to traverse the list as I added it all to the method.
              This is because the method given restuns void so nothing, so I made the method print each nodes data out
              on a new line*/

            //Delete 3rd node and then traverse

            //Add your code here

            head.DeleteNextNode(head.next);

            head.TraverseList(head);

            //Insert 100 after the node value 7 and then traverse

            //Add your code here


            head.InsertNode(head.next.next.next.next.next, 7);

            head.TraverseList(head);

        }
    }
}
