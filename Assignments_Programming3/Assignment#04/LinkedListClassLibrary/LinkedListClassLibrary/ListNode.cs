/**************************************************************************
 * Class : ListNode                                                       *
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


namespace LinkedListClassLibrary
{
    public class ListNode
    {
        // automatic read-only property Data
        
        public object Data { get; private set; }
        
        public ListNode Next { get; set; }

        // constructor to create ListNode that refers to dataValue
        // and is last node in list
         public ListNode(object dataValue) : this(dataValue, null) { }
        //public ListNode(double dataValue) : this(dataValue, null) { }
        //public ListNode(string dataValue) : this(dataValue, null) { }


        // constructor to create ListNode that refers to dataValue
        // and refers to next ListNode in List
        public ListNode(object dataValue, ListNode nextNode)
        {
            Data = dataValue;
            Next = nextNode;
        }

        //public ListNode(double dataValue, ListNode nextNode)
        //{
        //    Data = dataValue;
        //    Next = nextNode;
        //}
        //public ListNode(string dataValue, ListNode nextNode)
        //{
        //    Data = dataValue;
        //    Next = nextNode;
        //}
    }
}
