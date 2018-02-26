using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExercises
{
    class Program
    {
        private static int[] intElements = { 1, 2, 53, 6, 99,777,300 ,233 };
        static void Main()
        {
         

        Console.WriteLine($"MaximumArray of , 2, 53, 6, 99, 777, 300, 233 is {MaximumArray(intElements)}");
           // Console.WriteLine($"Minimum of 3, 4 and 5 is {Minimum(3, 4, 5)}");
           // Console.WriteLine($"Minimum of 6.6, 8.8 and 7.7 is {Minimum(6.6, 8.8, 7.7)}");
            //Console.WriteLine("Minimum of pear, apple and orange is " +
            //   $"{Minimum("pear", "apple", "orange")}");



        }

        private static T MaximumArray<T>(T[] inputArray) where T : IComparable<T>
        {
            
            var max = inputArray.Max();
            //return max;
            var test = inputArray[0];
            //----or--//
            for (int i = 0; i < inputArray.Length; i++)
            {
               
                if(inputArray[i].CompareTo(test)>0)
                {
                    test = inputArray[i];
                   // Console.WriteLine("test"+test);
                }
                
            }
            Console.WriteLine("test : " + test);
            return test;

        }
        private static T Minimum<T>(T x, T y, T z) where T : IComparable<T>
        {
            var min = x; // assume x is initially the largest

            // compare y with max
            if (y.CompareTo(min) < 0)
            {
                min = y; // y is the largest so far
            }

            // compare z with max
            if (z.CompareTo(min) < 0)
            {
                min = z; // z is the largest
            }

            return min; // return largest object
        }
    }
}
