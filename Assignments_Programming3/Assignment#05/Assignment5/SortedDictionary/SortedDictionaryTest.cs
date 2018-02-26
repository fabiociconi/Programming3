using System;
using System.Collections.Generic;
using System.Linq;

namespace SortedDictionary
{

    class SortedDictionaryTest
    {

        public static SortedDictionary<int, Employee> dictionary;

        static void Main(string[] args)
        {
            string name;
            double salary;
            dictionary = new SortedDictionary<int, Employee>();
            Employee employee = new Employee("Sujeet", 1200);
            Console.WriteLine($"\n Employee: {employee}");
            Console.WriteLine("\nEnter Name and Salary:");

            //Insert five employees//
            for (int i = 0; i < 4; ++i)
            {
                name = Console.ReadLine();
                salary = double.Parse(Console.ReadLine());
                employee = new Employee(name, salary);
                dictionary.Add(i, employee);
            }

            while (true)
            {
                //Main Menu//
                Console.WriteLine("\n");
                Console.WriteLine("          Choose one Option         ");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("(1) - Add Item                      ");
                Console.WriteLine("(2) - Print                         ");
                Console.WriteLine("(3) - Remove                        ");
                Console.WriteLine("(4) - Search                        ");
                Console.WriteLine("(5) - Highest  Salary               ");
                Console.WriteLine("====================================");

                try
                {
                    int option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        //add
                        case 1:
                            try
                            {
                                Console.Write("\nType Employee Name: ");
                                string employeeName = Console.ReadLine();

                                Console.Write("\nType a Salary: ");
                                string sal = Console.ReadLine();
                                double salaryEmployee = double.Parse(sal);

                                employee = new Employee(employeeName, salaryEmployee);

                                AddDictionaryItem(dictionary, employee);

                                //test
                                //DisplayDictionary(dictionary);
                                Console.WriteLine($"Employee : {employee}");
                                //
                                //Console.ReadLine();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("{0} Exception caught.", ex);
                            }
                            break;
                        //print
                        case 2:
                            try
                            {
                                DisplayDictionary(dictionary);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("{0} Exception caught.", ex);
                            }
                            break;
                        //remove
                        case 3:
                            try
                            {
                                Console.Write("\nType a Key: ");
                                string chave = Console.ReadLine();
                                int dicChave = int.Parse(chave);

                                RemoveDictionaryItem(dictionary, dicChave);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("{0} Exception caught.", ex);
                            }
                            break;
                        //Search 
                        case 4:
                            try
                            {
                                Console.Write("\nType a Key: ");
                                string chave = Console.ReadLine();
                                int dicChave = int.Parse(chave);

                                SearchDictionaryItem(dictionary, dicChave);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("{0} Exception caught.", ex);
                            }
                            break;
                        //salary
                        case 5:
                            try
                            {
                                MaxDictionaryItem(dictionary);
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
        /// Search in the list for a employee
        /// </summary>
        /// <param name="dictionary"></param>
        /// <param name="chave"></param>
        private static void SearchDictionaryItem(SortedDictionary<int, Employee> dictionary, int chave)
        {
            if (dictionary.ContainsKey(chave))
                Console.WriteLine("Value : {0}", dictionary[chave]);
        }
        /// <summary>
        /// remove an employee from dictionary
        /// </summary>
        /// <param name="dictionary"></param>
        /// <param name="chave"></param>
        private static void RemoveDictionaryItem(SortedDictionary<int, Employee> dictionary, int chave)
        {
            dictionary.Remove(chave);
        }
        /// <summary>
        /// Add new employee
        /// </summary>
        /// <param name="dictionary"></param>
        /// <param name="emp"></param>
        private static void AddDictionaryItem(SortedDictionary<int, Employee> dictionary, Employee emp)
        {
            try
            {

                dictionary.Add(dictionary.Keys.Max() + 1, emp);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("An element with Key already exists.");
            }

        }
        /// <summary>
        /// print all elements from Dictionary
        /// </summary>
        /// <param name="dictionary"></param>
        private static void DisplayDictionary(SortedDictionary<int, Employee> dictionary)
        {
            Console.WriteLine($"\nSorted dictionary contains:\n{"Key",-12}{"Value",-18}");

            foreach (var key in dictionary.Keys)
            {
                Console.WriteLine($"{key,-4}{dictionary[key],-18}");
            }

            Console.WriteLine($"\nsize: {dictionary.Count}");
        }
        /// <summary>
        /// Search the highest salary recorded in the dictionary
        /// </summary>
        /// <param name="dictionary"></param>
        private static void MaxDictionaryItem(SortedDictionary<int, Employee> dictionary)
        {
            double max = 0;
            string name= null;

            foreach (var item in dictionary)
            {
                
                if (item.Value.Salary > max)
                {
                    max = item.Value.Salary;
                    name = item.Value.Name;
                }
               
            }


            Console.WriteLine("The 'maximum' Salary is {0} from {1}.", max, name);

        }
    }
}
