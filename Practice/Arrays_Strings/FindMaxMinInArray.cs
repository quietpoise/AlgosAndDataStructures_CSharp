using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    // Find max and min integers in array without using max or min built-in function
    class FindMaxAndMinInArrayClass
    {
        static void Main(string[] args)
        {
            int[] numberList = new int[5] {1,2,3,4,5};
            int? min = FindMaxAndMinInArray("min", numberList);
            int? max = FindMaxAndMinInArray("max", numberList);
            Console.WriteLine("min:" + min.ToString());
            Console.WriteLine("max:" + max.ToString());
            Console.ReadLine();
        }

        public static int? FindMaxAndMinInArray(string type, int[] inputList)
        {
            int? temp = null;

            if (type == "min")
            {
                foreach(int i in inputList)
                {
                    if(temp is null)
                    {
                        temp = i;
                    }

                    if (i < temp)
                    {
                        temp = i;
                    }

                }
            }

            if (type == "max")
            {
                foreach (int i in inputList)
                {
                    if (temp is null)
                    {
                        temp = i;
                    }

                    if (i > temp)
                    {
                        temp = i;
                    }

                }
            }
            return temp;
        }
    }
}
