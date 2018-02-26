/**************************************************************************
 * Class : List                                                           *
 *                                                                        *
 * Lab Assignment #4 – Using data structures- Ch19                        *
 *                                                                        *
 * Create LinkedListLibrary ( .dll ) by following the naming guidelines   *
 * mentioned in the assignment and do the following                       *
 * enhancement/modifications:                                             *
 *   a)	You need to create a separate .cs file for each class.            *
 *   b)	Type of the data in the node should be double.( ListNode class)   *
 *   c)	Add following methods apart from the existing methods:            *
 *       1)	Search( ) method which searches a given element in the liked  *
 *       list. Use appropriate argument(s) for the method.                *
 *       2)	Count( ) method which count the number of elements in the     * 
 *       linked list                                                      *
 *       3)	Test it by creating and calling all the methods to            *
 *       demonstrate their working.                                       *
 *----------------------------------------------------------------------- *
 * Fabio Alexandre Ciconi - 300390989                                     *
 *                                                                        *
 *  Jun/2017                                                              *
 *************************************************************************/

using System;

namespace LinkedListClassLibrary
{
    public class List
    {
        private ListNode firstNode;
        private ListNode lastNode;
        private string name; // string like "list" to display

        // construct empty List with specified name
        public List(string listName)
        {
            name = listName;
            firstNode = lastNode = null;
        }

        // construct empty List with "list" as its name 
        public List() : this("list") { }

        // Insert object at front of List. If List is empty, 
        // firstNode and lastNode will refer to same object.
        // Otherwise, firstNode refers to new node.
        public void InsertAtFront(object insertItem)
        {
            if (IsEmpty())
            {
                firstNode = lastNode = new ListNode(insertItem);
            }
            else
            {
                firstNode = new ListNode(insertItem, firstNode);
            }
        }
        // Insert object at end of List. If List is empty, 
        // firstNode and lastNode will refer to same object.
        // Otherwise, lastNode's Next property refers to new node.
        public void InsertAtBack(object insertItem)
        {
            if (IsEmpty())
            {
                firstNode = lastNode = new ListNode(insertItem);
            }
            else
            {
                lastNode = lastNode.Next = new ListNode(insertItem);
            }
        }
        // remove first node from List
        public object RemoveFromFront()
        {
            if (IsEmpty())
            {
                throw new EmptyListException(name);
            }

            object removeItem = firstNode.Data; // retrieve data

            // reset firstNode and lastNode references
            if (firstNode == lastNode)
            {
                firstNode = lastNode = null;
            }
            else
            {
                firstNode = firstNode.Next;
            }

            return removeItem; // return removed data
        }
        // remove last node from List
        public object RemoveFromBack()
        {
            if (IsEmpty())
            {
                throw new EmptyListException(name);
            }

            object removeItem = lastNode.Data; // retrieve data

            // reset firstNode and lastNode references
            if (firstNode == lastNode)
            {
                firstNode = lastNode = null;
            }
            else
            {
                ListNode current = firstNode;

                // loop while current.Next is not lastNode
                while (current.Next != lastNode)
                {
                    current = current.Next; // move to next node
                }

                // current is new lastNode
                lastNode = current;
                current.Next = null;
            }

            return removeItem; // return removed data
        }
        // return true if List is empty
        public bool IsEmpty()
        {
            return firstNode == null;
        }
        // output List contents
        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine($"Empty {name}");
            }
            else
            {
                Console.Write($"The {name} is: ");

                ListNode current = firstNode;

                // output current node data while not at end of list
                while (current != null)
                {
                    Console.Write($"{current.Data} ");
                    current = current.Next;
                }

                Console.WriteLine("\n");
            }
        }
        /// <summary>
        /// Count numer of elements of the list
        /// </summary>
        /// <returns>Quantity of elements</returns>
        public int Count()
        {
            int numElmentsInTheList = 0;

            for (ListNode current = firstNode; current != null; current = current.Next)
            {
                numElmentsInTheList++;
            }

            return numElmentsInTheList;
        }
        /// <summary>
        /// Search an element inside of the list
        /// </summary>
        /// <param name="element"></param>
        public void Search(double element)
        {
            if (IsEmpty())
            {
                throw new EmptyListException(name);
            }
            else
            {
                bool find = false;
                //ListNode current = firstNode;
                for (ListNode current = firstNode; current != null; current = current.Next)
                {
                    
                    if ((double)current.Data == element)
                    {
                        //Console.WriteLine("Current: " + current.Data.ToString() + "\tx\t " + "Element: " + element);

                        Console.WriteLine("*********************************************");
                        Console.WriteLine(" The element is in the list: " + element);
                        Console.WriteLine("*********************************************");
                        find = true;
                        break;
                    }
                  
                }
                if (find == false)
                {
                    Console.WriteLine("*********************************************");
                    Console.WriteLine("  The element is NOT in the list : " + element);
                    Console.WriteLine("*********************************************");
                }
                Console.WriteLine("\n");
            }
        }
        /// <summary>
        /// Verify if the element typed is the top of Satck and show the top element of
        /// the stack
        /// </summary>
        /// <param name="element"></param>
        public void TopElementOfSatck()
        {
            if (IsEmpty())
            {
                throw new EmptyListException(name);

            }

            double topElement = (double)firstNode.Data;

            //if (topElement == element)
            //{
            Console.WriteLine("\nThe number " + topElement + " " +
                "is the top element of the list");
            //}
            //else
            //{
            //    Console.WriteLine("\nThe number "+ element+ " is NOT the top element of the list");
            //    Console.WriteLine("\nThe Top element is: " + topElement);
            //}
        }
    }
}
