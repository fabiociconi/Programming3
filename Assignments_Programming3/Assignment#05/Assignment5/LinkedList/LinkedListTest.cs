using System;
using System.Collections.Generic;
using System.Linq;

namespace LinkedListTest
{
    class LinkedListTest
    {
        /// <summary>
        /// linked list
        /// </summary>
        public static LinkedList<Student> lnkStudent = new LinkedList<Student>();

        static void Main(string[] args)
        {
            //test
            Student student = new Student(300930989, "Fabio");
            Console.WriteLine($"Employee : {student}");
            //test

            while (true)
            {
                //main nenu//
                Console.WriteLine("\n");
                Console.WriteLine("          Choose one Option         ");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("(1) - Add a student (AddLast)       ");
                Console.WriteLine("(2) - Remove a student from the list");
                Console.WriteLine("(3) - Print List                    ");
                Console.WriteLine("(4) - Search                        ");
                Console.WriteLine("(5) - Remove All - Clear List       ");
                Console.WriteLine("====================================");

                try
                {
                    int option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            try
                            {
                                Console.Write("\nType an ID: ");
                                string idNumber = Console.ReadLine();
                                int studentID = int.Parse(idNumber);
                                Console.Write("\nType Student Name: ");
                                string studentName = Console.ReadLine();
                                //int number2 = int.Parse(secondNumber);
                                student = new Student(studentID, studentName);
                                AddLinkedListItem(lnkStudent, student);
                                //test
                                Console.WriteLine($"Employee : {student}");
                                //
                                Console.ReadLine();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("{0} Exception caught.", ex);
                            }
                            break;
                        case 2:
                            try
                            {
                                Console.Write("\nType an ID: ");
                                string idNumber = Console.ReadLine();
                                int studentID = int.Parse(idNumber);
                                Console.Write("\nType Student Name: ");
                                string studentName = Console.ReadLine();

                                student = new Student(studentID, studentName);
                                RemoveLinkedListItem(lnkStudent, student);
                                //lnkStudent.AddLast(student);
                                //test
                                Console.WriteLine($"Employee : {student}");
                                //
                                //Console.ReadLine();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("{0} Exception caught.", ex);
                            }
                            break;
                        case 3:
                            try
                            {
                                //Console.WriteLine("------------------------------------");
                                Console.WriteLine("\n---------------List-----------------");
                                PrintLinkedList(lnkStudent);
                                Console.WriteLine("\n------------------------------------");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("{0} Exception caught.", ex);
                            }
                            break;
                        case 4:
                            try
                            {
                                Console.Write("\nType an ID: ");
                                string idNumber = Console.ReadLine();
                                int studentID = int.Parse(idNumber);
                                Console.Write("\nType Student Name: ");
                                string studentName = Console.ReadLine();
                                student = new Student(studentID, studentName);
                                SearchLinkedListItem(lnkStudent, student);
                                //test
                                //Console.WriteLine($"Employee : {student}");
                                //Console.ReadLine();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("{0} Exception caught.", ex);
                            }
                            break;
                        case 5:
                            try
                            {
                                RemoveAllLinkedListItems(lnkStudent);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("{0} Exception caught.", ex);
                            }
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Please selection one option 1 to 5");

                }
            }
        }
        /// <summary>
        /// clear the linked list
        /// </summary>
        /// <param name="lnkStudent"></param>
        private static void RemoveAllLinkedListItems(LinkedList<Student> lnkStudent)
        {
            lnkStudent.Clear();
            Console.WriteLine("\n------------------------------------");
            Console.WriteLine("      The list has been cleared       ");
            Console.WriteLine("\n------------------------------------");
        }
        /// <summary>
        /// search a stundent in the list
        /// </summary>
        /// <param name="lnkStudent"></param>
        /// <param name="student"></param>
        private static void SearchLinkedListItem(LinkedList<Student> lnkStudent, Student student)
        {

            foreach (var item in lnkStudent.Where
                (w => w.Id.Equals(student.Id)).ToArray())
            {
                Console.WriteLine("Found ID: {0} Student: {1}",
                          student.Id, student.Name);
            }

            //bool value = lnkStudent.Equals(student);
            //if (lnkStudent.Contains(student))

            //{
            //    Console.WriteLine("Found {0}  {1}",
            //               student.Id, student.Name);
            //}
            //else
            //{
            //    Console.WriteLine("Item does not in the list");
            //}
        }
        /// <summary>
        /// print all elements from list
        /// </summary>
        /// <param name="lnkStudent"></param>
        private static void PrintLinkedList(LinkedList<Student> lnkStudent)
        {
            foreach (var item in lnkStudent)
            {
                Console.WriteLine(item);
            }

        }
        /// <summary>
        /// remove one student
        /// </summary>
        /// <param name="lnkStudent"></param>
        /// <param name="student"></param>
        private static void RemoveLinkedListItem(LinkedList<Student> lnkStudent, Student student)
        {
            //bool answer = lnkStudent.Remove(student);
            // Console.WriteLine("answer: " + answer);

            foreach (var item in lnkStudent.Where
                (w => w.Id.Equals(student.Id)).ToArray())
                lnkStudent.Remove(item);
            Console.WriteLine("\n--------------------------------------");
            Console.WriteLine("\n    Removed   ");


        }
        /// <summary>
        /// insert a student in the last position of the list
        /// </summary>
        /// <param name="lnkStudent"></param>
        /// <param name="student"></param>
        private static void AddLinkedListItem(LinkedList<Student> lnkStudent, Student student)
        {

            lnkStudent.AddLast(student);
            Console.WriteLine("\n--------------------------------------");
            Console.WriteLine("\n    Added a student in the end        ");

        }
    }
}
