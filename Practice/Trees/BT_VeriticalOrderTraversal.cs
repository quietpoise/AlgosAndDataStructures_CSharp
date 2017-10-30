using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice.Trees

namespace Practice.Trees
{
    // Find max and min integers in array without using max or min built-in function
    public class VerticalOrderTraversalClass
    {
        static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree();
            Dictionary<int, List<Node>> hashTable = new Dictionary<int, List<Node>>();
            bst.PreOrderTraversalForVerticalOrder(bst.root, 0, ref hashTable);

            foreach(KeyValuePair<int, List<Node>> entry in hashTable)
            {
                foreach(Node node in entry.Value)
                {
                    Console.WriteLine(node.val);
                }
            }
        }
    }

    public partial class BinarySearchTree
    {
        public void PreOrderTraversalForVerticalOrder(Node rootNode, int hd, ref Dictionary<int, List<Node>> hashTable)
        {
            if (rootNode == null)
            {
                return;
            }

            if (hashTable[hd] == null)
            {
                List<Node> nodeList = new List<Node>();
                nodeList.Add(rootNode);
                hashTable.Add(hd, nodeList);
            }
            else
            {
                hashTable[hd].Add(rootNode);
            }

            this.PreOrderTraversalForVerticalOrder(rootNode.left, hd - 1, ref hashTable);
            this.PreOrderTraversalForVerticalOrder(rootNode.right, hd + 1, ref hashTable);
        }
    }
}
