using System;
using System.Collections.Generic;


namespace Overloading_a_Generic_Method
{
    class OverloadedMethods
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };

            Console.WriteLine("\nTest Overload Methods");
            Console.WriteLine("========================");
            Console.Write("Array intArray contains: ");
            DisplayArray(intArray); // pass an int array argument
            Console.Write("Array doubleArray contains: ");
            DisplayArray(doubleArray); // pass a double array argument
            Console.Write("Array charArray contains: ");
            DisplayArray(charArray); // pass a char array argument

            //Menu//
            while (true)
            {
                //main menu//
                Console.WriteLine("\nChoose one array");
                Console.WriteLine("-------------------");
                Console.WriteLine("(1) - IntArray");
                Console.WriteLine("(2) - DoubleArray");
                Console.WriteLine("(3) - CharArray");
                Console.WriteLine("==================");
                //--//
                try
                {
                    int option = int.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            try
                            {
                                Console.Write("\nType Low Index: ");
                                string fisrtNumber = Console.ReadLine();
                                int number1 = int.Parse(fisrtNumber);
                                Console.Write("\nType High Index: ");
                                string secondNumber = Console.ReadLine();
                                int number2 = int.Parse(secondNumber);
                                List<int> listIntegers =
                                 DisplayArray(intArray, number1, number2);
                                Console.Write("Result List : " + (String.Join(" ", listIntegers)));
                                //Console.Write("Result List : " + listIntegers);
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
                                Console.Write("\nType Low Index: ");
                                string fisrtNumber = Console.ReadLine();
                                int number1 = int.Parse(fisrtNumber);
                                Console.Write("\nType High Index: ");
                                string secondNumber = Console.ReadLine();
                                int number2 = int.Parse(secondNumber);
                                List<double> listDoubles =
                                DisplayArray(doubleArray, number1, number2);
                                //Console.Write("Result List : ");
                                //listDoubles.ForEach(i => Console.Write("{0}/", i));
                                Console.Write("Result List : " + (String.Join(" ", listDoubles)));
                                //DisplayArray(doubleArray, number1, number2);
                                Console.ReadLine();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("{0} Exception caught.", ex);
                            }
                            break;
                        case 3:
                            try
                            {
                                Console.Write("\nType Low Index: ");
                                string fisrtNumber = Console.ReadLine();
                                int number1 = int.Parse(fisrtNumber);
                                Console.Write("\nType High Index: ");
                                string secondNumber = Console.ReadLine();
                                int number2 = int.Parse(secondNumber);
                                List<char> listChar =
                                DisplayArray(charArray, number1, number2);
                                //Console.Write("Result List : " + listChar);
                                Console.Write("Result List : " + (String.Join("-", listChar)));
                                //DisplayArray(charArray, number1, number2);
                                Console.ReadLine();
                            }
                            catch (Exception ex)
                            {

                                Console.WriteLine("{0} Exception caught.", ex);
                            }
                            break;
                        default:
                            {
                                Console.WriteLine("Invalid Option");
                            }
                            break;
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Please selection one option 1 to 3");
                    Console.WriteLine("{0} Exception caught.", ex); 
                }
            }
        }
        /// <summary>
        /// show the interval betwewen low and high index
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="inputList"></param>
        /// <param name="lowIndex"></param>
        /// <param name="highIndex"></param>
        /// <returns></returns>
        private static List<T> DisplayArray<T>(T[] inputList, int lowIndex, int highIndex)
        {
            var result = new List<T>();
            int qtd = 0;

            try
            {
                if ((highIndex <= 0)||(lowIndex<=0))
                {
                    throw new ArgumentException("highIndex Cannot be Less Equal 0");
                }
                if (highIndex > inputList.Length)
                {
                    throw new ArgumentException("highIndex bigger than array");
                }
                //int lastIndex = Array.LastIndexOf(inputArray);
                if (highIndex > lowIndex)
                {
                    for (int i = lowIndex; i <= highIndex; i++)
                    {
                        result.Add(inputList[i]);
                        qtd++;

                    }
                }
                else
                {
                    throw new ArgumentException("highIndex less than lowIndex" );
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);

            }
            Console.WriteLine();
            Console.WriteLine("Quatity: " + qtd);
            return result;
        }
        //private static List<char> DisplayArray(char[] charArray, int lowIndex, int highIndex)
        //{
        //    var result = new List<Char>();

        //    try
        //    {
        //        if (highIndex <= 0)
        //        {
        //            throw new ArgumentException("highIndex Cannot be Less Equal 0");
        //        }
        //        if (highIndex > lowIndex)
        //        {
        //            for (int i = lowIndex; i <= highIndex; i++)
        //            {
        //                result.Add(charArray[i]);
        //                //Console.Write($"{text} ");
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Error: " + ex);

        //    }
        //    Console.WriteLine();
        //    return result;
        //}
        //private static List<double> DisplayArray(double[] doubleArray, int lowIndex, int highIndex)
        //{
        //    var result = new List<double>();

        //    try
        //    {
        //        if (highIndex <= 0)
        //        {
        //            throw new ArgumentException("highIndex Cannot be Less Equal 0");
        //        }
        //        if (highIndex > lowIndex)
        //        {
        //            for (int i = lowIndex; i <= highIndex; i++)
        //            {
        //                result.Add(doubleArray[i]);
        //                //Console.Write($"{text} ");
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Error: " + ex);

        //    }
        //    Console.WriteLine();
        //    return result;
        //}
        //// output double array
        //Overloaded Method//
        private static void DisplayArray(double[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine();
        }
        //output int array
        //Overloaded Method//
        private static void DisplayArray(int[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
        }
        // output char array      
        //Overloaded Method//
        private static void DisplayArray(char[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine();
        }

    }
}
