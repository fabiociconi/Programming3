/**************************************************************************
 * Class : EmptyListException                                             *
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
    public class EmptyListException: Exception
    {
        public EmptyListException() : base("The list is empty") { }

        // one-parameter constructor
        public EmptyListException(string name): base($"The {name} is empty"){ }

        // two-parameter constructor
        public EmptyListException(string exception, Exception inner): base(exception, inner) { }
    }
}
