using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice.Trees;

namespace Practice.Trees
{
    // Find max and min integers in array without using max or min built-in function
    class BST_DFSTraversalClass
    {
        static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree();
            Node root = bst.Insert(null, 6);
            root = bst.Insert(root, 2);
            root = bst.Insert(root, 9);
            root = bst.Insert(root, 5);
            root = bst.Insert(root, 7);
        }

        public static int function()
        {
            return 1;
        }
    }
}
