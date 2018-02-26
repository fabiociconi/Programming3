/**************************************************************************
 * Class : QueueTest                                           *
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
using QueueInheritanceLibrary;
using LinkedListClassLibrary;

// demonstrate functionality of class QueueInheritance
public class QueueTest
{
    static void Main()
    {
        QueueInheritance queue = new QueueInheritance();

        // create objects to store in the queue

        string name_1 = "Antonio";
        string name_2 = "Miriam";
        string name_3 = "Alberto";
        string name_4 = "Fabio";
        string name_5 = "Aline";
        string name_6 = "Sasha";
        string name_7 = "Whisky";

        queue.Enqueue(name_1);
        queue.Enqueue(name_2);
        queue.Enqueue(name_3);
        queue.Enqueue(name_4);
        queue.Enqueue(name_5);
        queue.Enqueue(name_6);
        queue.Enqueue(name_7);
        queue.Display();

        while (true)
        {
            Console.WriteLine("\nQueue - Test");
            Console.WriteLine("1. Enqueue");
            Console.WriteLine("2. Dequeue");
            Console.WriteLine("3. Exit");

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:

                    Console.Write("\nEnter new element : ");
                    try
                    {
                        string elementEnqueue = Console.ReadLine();
                        queue.Enqueue(elementEnqueue);
                        queue.Display();
                    }
                    catch (EmptyListException emptyListException)
                    {

                        Console.Error.WriteLine(emptyListException.StackTrace);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("{0} Exception caught.", ex);
                    }
                    break;

                case 2:
                    Console.Write("\nDequeue : ");
                    try
                    {
                        //remove one item from queue
                        object removedObject = null;
                        removedObject = queue.Dequeue();
                        Console.WriteLine($"{removedObject} dequeued\n");
                        queue.Display();

                    }
                    catch (EmptyListException emptyListException)
                    {
                        // if exception occurs, write stack trace
                        Console.Error.WriteLine(emptyListException.StackTrace);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("{0} Exception caught.", ex);
                    }
                    break;
                case 3:

                    Environment.Exit(0);
                    break;

                default:
                    throw new ArgumentException("Value not supported :" + option);
            }
        }
    }
}


