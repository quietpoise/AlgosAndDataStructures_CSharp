using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    // Find the minimum difference between the elements in an array
    class TFindMinDifferenceInArrayClass
    {
        static void Main(string[] args)
        {
            int[] numberList = new int[] { 13,6,3,1,7 };
            Console.WriteLine(FindMinDifference(numberList));
            Console.ReadLine();
        }

        public static int FindMinDifference(int[] inputList)
        {
            Array.Sort(inputList);
            int minDifference = int.MaxValue;

            for (int i = 0; i<inputList.Length-1; i++)
            {
                if (inputList[i+1] - inputList[i] < minDifference)
                {
                    minDifference = inputList[i + 1] - inputList[i];
                }
            }

            return minDifference;

        }
    }
}
