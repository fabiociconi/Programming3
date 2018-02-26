/**************************************************************************
 * Class : ListTest                                                       *
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
using LinkedListClassLibrary;

// class to test List class functionality
class ListTest
{
    static void Main()
    {
        var list = new List(); // create List container

        double aDouble_1 = 34.5;
        double aDouble_2 = 20.4;
        double aDouble_3 = 0.4;
        double aDouble_4 = 32.23;

        // use List insert methods       
        list.InsertAtFront(aDouble_1);
        list.Display();
        list.InsertAtFront(aDouble_2);
        list.Display();
        list.InsertAtBack(aDouble_3);
        list.Display();
        list.InsertAtBack(aDouble_4);
        list.Display();

        while (true)
        {
            Console.WriteLine("\nList - Test");
            Console.WriteLine("1. Search");
            Console.WriteLine("2. RemoveFromFront");
            Console.WriteLine("3. RemoveFromBack");
            Console.WriteLine("4. InsertAtFront");
            Console.WriteLine("5. InsertAtBack");
            //Test LinkedListClassLibrary//
            //Console.Write("\nType a number to search in the list: ");
            //string numberTyped = Console.ReadLine();
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    try
                    {
                        Console.Write("\nType a number to search in the list: ");
                        string numberTyped = Console.ReadLine();
                        double number = double.Parse(numberTyped);
                        list.Search(number);

                        list.Display();

                        int elements = list.Count();
                        Console.Write("\nTotal Elements in the list: " + elements + "\n\n");
                    }
                    catch (EmptyListException emptyListException)
                    {
                        Console.Error.WriteLine($"\n{emptyListException}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("{0} Exception caught.", ex);
                    }
                    break;
                case 2:
                    try
                    {
                        //string numberTyped = Console.ReadLine();
                        //double number = double.Parse(numberTyped);
                        list.RemoveFromFront();

                        list.Display();

                        int elements = list.Count();
                        Console.Write("\nTotal Elements in the list: " + elements + "\n\n");
                    }
                    catch (EmptyListException emptyListException)
                    {
                        Console.Error.WriteLine($"\n{emptyListException}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("{0} Exception caught.", ex);
                    }
                    break;
                case 3:
                    try
                    {
                        list.RemoveFromBack();

                        list.Display();

                        int elements = list.Count();
                        Console.Write("\nTotal Elements in the list: " + elements + "\n\n");

                    }
                    catch (EmptyListException emptyListException)
                    {
                        Console.Error.WriteLine($"\n{emptyListException}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("{0} Exception caught.", ex);
                    }
                    break;
                case 4:
                    try
                    {
                        Console.Write("\nType a number to insert: ");
                        string numberTyped = Console.ReadLine();
                        double number = double.Parse(numberTyped);
                        list.InsertAtFront(number);

                        list.Display();

                        int elements = list.Count();
                        Console.Write("\nTotal Elements in the list: " + elements + "\n\n");
                    }
                    catch (EmptyListException emptyListException)
                    {
                        Console.Error.WriteLine($"\n{emptyListException}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("{0} Exception caught.", ex);
                    }
                    break;
                case 5:
                    try
                    {
                        Console.Write("\nType a number to insert: ");
                        string numberTyped = Console.ReadLine();
                        double number = double.Parse(numberTyped);
                        list.InsertAtBack(number);

                        list.Display();

                        int elements = list.Count();
                        Console.Write("\nTotal Elements in the list: " + elements + "\n\n");
                    }
                    catch (EmptyListException emptyListException)
                    {
                        Console.Error.WriteLine($"\n{emptyListException}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("{0} Exception caught.", ex);
                    }
                    break;
            }
        }

    }
}