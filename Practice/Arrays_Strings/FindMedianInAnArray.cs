using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    // Find max and min integers in array without using max or min built-in function
    class FindMedianClass
    {
        static void Main(string[] args)
        {
            int[] numberList = new int[] { 13, 6, 3, 1, 7, 14};
            Console.WriteLine(FindMedian(numberList).ToString());
            Console.ReadLine();
        }

        public static double FindMedian(int[] inputList)
        {
            Array.Sort(inputList);
            return ((inputList.Length) % 2 == 1) ? inputList[((inputList.Length - 1) / 2)] : (inputList[((inputList.Length)/2) - 1] + inputList[((inputList.Length)/2)])/2 ;
        }
    }
}
