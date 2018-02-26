/**************************************************************************
 * Class : StackInheritance                                               *
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

using LinkedListClassLibrary;

namespace StackInheritanceLibrary
{

    // class StackInheritance inherits class List's capabilities
    public class StackInheritance : List
    {
        // pass name "stack" to List constructor
        public StackInheritance() : base("stack") { }

        // place dataValue at top of stack by inserting 
        // dataValue at front of linked list
        public void Push(double dataValue)
        {
            InsertAtFront(dataValue);
        }

        // remove item from top of stack by removing
        // item at front of linked list
        public object Pop()
        {
            return RemoveFromFront();
        }
        public void Peek()
        {

            TopElementOfSatck();

        }


    }
}
