using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class GroupAnagramsProgram
    {
        static void Main(string[] args)
        {
            string[] strList = new string[] {"eat", "tea", "tan", "ate", "nat", "bat"};
            Dictionary<string, List<string>> Results = GroupAnagrams(strList);
            Console.Write(Results);
        }

        public static Dictionary<string, List<string>> GroupAnagrams(string[] inputList)
        {
            Dictionary<string, List<string>> ht = new Dictionary<string, List<string>>();

            foreach (string str in inputList)
            {
                Char[] ca = str.ToCharArray(0, str.Length);

                Array.Sort(ca);
                string sortedString = new string(ca);

                if (!ht.ContainsKey(sortedString))
                {
                    ht.Add(sortedString, new List<string>());
                }

                ht[sortedString].Add(str);
            }

            return ht;
        }
    }
}
