using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    class MyDoublyLinkedList
    {
        private string name;
        public MyDoublyLinkedList next;
        public MyDoublyLinkedList prev;
        public MyDoublyLinkedList head; // Head and tail added
        public MyDoublyLinkedList tail;

        //Default Constructor
        public MyDoublyLinkedList()
        {
            name = "";
            next = null;
            prev = null;
            head = null; // I added to construct head & tail
            tail = null;
        }
        //Constructor with parameter
        public MyDoublyLinkedList(string value)
        {
            name = value;
            next = null;
            prev = null;
            head = null; // I added to add head
        }

        //Assign head pointer to the first node
        public void AssignHead()
        {
            head = this;
        }

        //Insert a new node with a value AFTER the current node
        public void InsertNextNode(MyDoublyLinkedList current, string value)
        {
            MyDoublyLinkedList node = new MyDoublyLinkedList(value);
            if (current.next == null) 
            {
                //Insert at the end and easy to handle

                //Add your code here

                //next = new MyDoublyLinkedList(value);
                //prev = current;
                current.next = node; // next  = the new node
                node.prev = current; // the previous 
            }            
            else
            {
                //Insert in the middle               
                //Look lecture slides for the pseudocode for adding node in the middle

                //Add your code here
               
                MyDoublyLinkedList temp = current.next; // Stores currents next node as temp

                // Current next is now a new node with the required value.
                current.next = new MyDoublyLinkedList(value); 
                // Node after new node inserted is now connected to node orginaly after current.
                current.next.next = temp;
                return;
            }
        }

        //Insert a new node with a value BEFORE the current node
        public void InsertPrevtNode(MyDoublyLinkedList current, string value)
        {
            MyDoublyLinkedList node = new MyDoublyLinkedList(value);
            if (current.prev == null)
            {
                //Insert in the begining 
                head = node;//Head is updated after inserting in the beginning

                //Add the rest of your code here....
                //Look lecture slides for the pseudocode for adding node in the begining

            }
            else
            {
                //Insert in the middle               
                //Look lecture slides for the pseudocode for adding node in the middle

                //Add your code here
            }
        }
        public void DeleteNode(MyDoublyLinkedList current)
        {
            //Check for ERROR if you are deleting a node which is referred by many pointers.
            //Update all these pointers before deleting (releasing) memory!

            if (next == null)//last node
            {
                //Delete the last node
                //Look lecture slides for the pseudocode for deleting last node 
            }
            else if(prev == null)
            {
                //Delete head node
                //Look lecture slides for the pseudocode for deleting head node 
            }
            else
            {
                //Update the next node pointer and reset the deleted node to null
                //Look lecture slides for the pseudocode for deleting a node in the middle

                //Add your code here

                // Console.WriteLine(current.name); // Used to check the correct node was passed.
                // Node before Peter now attaches to node after Peter, severing connection 1 and relinking.
                current.prev = current.next.next; 

                // Connects node after to node before, severeding the final connection and relinking.
                current.next = current.prev;
                return; // Returns to main
            }
        }

        //Traverse forward
        public void TraverseForward(MyDoublyLinkedList node)
        {
			//Print the values stored in each node from current to tail
            Console.WriteLine("Traversing in forward direction...");
            while(node != null)//Traverse from the current node
            {
                //Add your code here
                // MY CODE!!
                try // Try catch used to help identify issues.
                {
                    if (node.next == null) // To not add -> at the end of the list
                        Console.WriteLine(node.name); // Does not print arrow to indicate next
                    else
                        Console.Write(node.name + " -> "); // Prints node name plus "->" for spacing
                    // As it loops, current node is assigned to next so loops over for the next node
                    node = node.next;
                }
                catch (Exception explained)
                {
                    Console.Write(explained.Message);
                    Console.Write("Problem traversing list");
                }
                // MY CODE ENDS HERE!!
            }
        }

        //Traverse Backward
        public void TraverseBackward(MyDoublyLinkedList node)
        {
            //Print the values stored in each node from current to head
            Console.WriteLine("Traversing in backward direction...");

            // Console.WriteLine(node.name); // Used to check tail was correct
         
            try
            {
                while (node != null)//Traverse from the current node
                {
                    //Add your code here
                    
                    try // Try catch used to help identify issues.
                    {
                        if (node.prev == null) // To not add -> at the end of the list
                            Console.WriteLine(node.name); // Does not print arrow to indicate next
                        else
                            Console.Write(node.name + " -> "); // Prints node name plus "->" for spacing.
                        // As it loops, current node is assigned to prev so loops over prev for next.
                        node = node.prev;
                    }
                    catch (Exception explained)
                    {
                        Console.Write(explained.Message);
                        Console.Write("Problem traversing list");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Create the first node
            MyDoublyLinkedList node = new MyDoublyLinkedList("Ardhendu"); 
           
            //Assign head
            node.AssignHead();
            //Add 9 more consecutive nodes (Tom, Jones, David, Andrew, Peter, Mark, Collette, Dave, Dan)

            // MY CODE!!
            MyDoublyLinkedList temp = node;
            MyDoublyLinkedList tail = node;

            string [] names = new string[]
            { "Tom", "Jones", "David", "Andrew", "Peter", "Mark", "Collette", "Dave", "Dan" };

            
            for(int i=0; i <= 8; i++) // Deleted = and replaced with < so goes up to 9
            {
                //Add your code here
                try
                {   
                    temp.InsertNextNode(temp, names[i]);
                    temp = temp.next;
                    tail = temp;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e + "Issue with loop");
                }

            }

            //Traverse the linked list from head to tail

            //Add your code here

            node.TraverseForward(node); // First node to call method in class, second is a parameter

            //Delete Peter node and then traverse forward

            //Add your code here

            node.DeleteNode(node.next.next.next.next); // Passes Andrew as the parameter

            node.TraverseForward(node); // First node to call method in class, second is a parameter

            //Insert Peter after Mark and then traverse backward

            //Add your code here

            // Calls insert node method and passes two parameters
            node.InsertNextNode(node.next.next.next.next.next, "Peter"); // Node which Peter needs to be

            node.TraverseForward(node);

            node.TraverseBackward(tail); // Calls traverse back method
        }
    }
}