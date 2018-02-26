/**************************************************************************
 * Class : StackInheritanceTest                                           *
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
using StackInheritanceLibrary;
using System;

// demonstrate functionality of class StackInheritance
class StackInheritanceTest
{
    static void Main()
    {
        StackInheritance stack = new StackInheritance();

        double aDouble_1 = .4;
        double aDouble_2 = 0.3;
        double aDouble_3 = 03.4;
        double aDouble_4 = 20.4;

        stack.Push(aDouble_1);
        stack.Push(aDouble_2);
        stack.Display();
        stack.Push(aDouble_3);
        stack.Display();
        stack.Push(aDouble_4);
        stack.Display();

        while (true)
        {


            Console.WriteLine("\nStack - Test");
            Console.WriteLine("--------------");
            Console.WriteLine("1. Push");
            Console.WriteLine("2. Peek");
            Console.WriteLine("3. Pop");
            Console.WriteLine("4. EXIT");

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Write("Enter an Element : ");
                    try
                    {
                        string numberToPush = Console.ReadLine();
                        double number_1 = double.Parse(numberToPush);
                        stack.Push(number_1);

                    }
                    catch (EmptyListException emptyListException)
                    {

                        Console.Error.WriteLine(emptyListException.StackTrace);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("{0} Exception caught.", ex);
                    }
                    stack.Display();
                    break;

                case 2:
                    Console.WriteLine("Enter an Element to Peek : ");
                    try
                    {
                        //string numberToPeek = Console.ReadLine();
                        //double number_2 = double.Parse(numberToPeek);
                        stack.Peek();

                    }
                    catch (EmptyListException emptyListException)
                    {

                        Console.Error.WriteLine(emptyListException.StackTrace);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("{0} Exception caught.", ex);
                    }
                    stack.Display();
                    break;

                case 3:
                    Console.WriteLine("Test Pop : ");
                    try
                    {
                        object element = stack.Pop();
                        Console.WriteLine($"{element} popped");
                    }
                    catch (EmptyListException emptyListException)
                    {

                        Console.Error.WriteLine(emptyListException.StackTrace);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("{0} Exception caught.", ex);
                    }
                    stack.Display();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    throw new ArgumentException("Value not supported :" + option);
            }
        }
    }
}
