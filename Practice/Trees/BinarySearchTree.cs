using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Trees
{
    // Implements a generic binary search tree
    public class BinarySearchTree
    {
        public Node root;
        public Node current;

        public BinarySearchTree()
        {
            root = null;
            current = null;
        }

        // Using recursion. Each recursive call is a different level in the tree
        public Node Insert(Node root, int nodeValue)
        {
            if (root == null)
            {
                root = new Node(nodeValue);
            }
            else if (nodeValue < root.val)
            {
                root.left = Insert(root.left, nodeValue);
            }
            else
            {
                root.right = Insert(root.right, nodeValue);
            }

            return root;
        }

        public void PreOrderTraversalWithRecursion(Node rootNode)
        {
            if (rootNode.val == null)
            {
                return;
            }

            Console.WriteLine(rootNode.val);
            PreOrderTraversalWithRecursion(rootNode.left);
            PreOrderTraversalWithRecursion(rootNode.right);
        }

        public void InOrderTraversalWithRecursion(Node rootNode)
        {
            if (rootNode.val == null)
            {
                return;
            }

            InOrderTraversalWithRecursion(rootNode.left);
            Console.WriteLine(rootNode.val);
            InOrderTraversalWithRecursion(rootNode.right);
        }

        public void PostOrderTraversalWithRecursion(Node rootNode)
        {
            if (rootNode.val == null)
            {
                return;
            }

            PostOrderTraversalWithRecursion(rootNode.left);
            Console.WriteLine(rootNode.val);
            PostOrderTraversalWithRecursion(rootNode.right);
        }

        public void InOrderTraversalWithoutRecursion(Node rootNode)
        {
            Stack<Node> stack = new Stack<Node>();
            Node current = rootNode;

            // Push all the elements from left subtree to the stack
            while (current != null)
            {
                stack.Push(current);
                current = current.left;
            }

            // While popping elements, make sure you add the right child of the current to the stack for traversing next
            // Remember this is in-order traversal
            while(stack.Count != 0)
            {
                Node poppedNode = stack.Pop();
                Console.WriteLine(poppedNode.val);
                if(poppedNode.right != null)
                {
                    stack.Push(poppedNode.right);
                }
            }
        }

        public void PreOrderTraversalWithoutRecursion(Node rootNode)
        {
            Stack<Node> stack = new Stack<Node>();
            Node current = rootNode;

            // Push the root element first
            stack.Push(current);

            while(stack.Count != 0)
            {
                Node poppedNode = stack.Pop();
                Console.WriteLine(poppedNode.val);
                if (poppedNode.right != null)
                {
                    stack.Push(poppedNode.right);
                }

                if (poppedNode.left != null)
                {
                    stack.Push(poppedNode.left);
                }
            }
        }

        public void PostOrderTraversalWithoutRecursion(Node rootNode)
        {
            Stack<Node> stack1 = new Stack<Node>();
            Stack<Node> stack2 = new Stack<Node>();

            stack1.Push(rootNode);

            // Push the elements in order in stack2 for post-order traversal
            while(stack1.Count != 0)
            {
                Node poppedNode = stack1.Pop();
                stack2.Push(poppedNode);

                if (poppedNode.left != null)
                {
                    stack1.Push(poppedNode.left);
                }

                if (poppedNode.right != null)
                {
                    stack1.Push(poppedNode.right);
                }
            }

            // Print the elements in stack2
            while(stack2.Count != 0)
            {
                Node poppedNode = stack2.Pop();
                Console.WriteLine(poppedNode.val);
            }
        }

        public void LevelOrderTraversal(Node rootNode)
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(rootNode);

            while (queue.Count != 0)
            {
                Node dequeuedNode = queue.Dequeue();
                Console.WriteLine(dequeuedNode.val);

                if (dequeuedNode.left != null)
                {
                    queue.Enqueue(dequeuedNode.left);
                }

                if (dequeuedNode.right != null)
                {
                    queue.Enqueue(dequeuedNode.right);
                }
            }
        }
    }

    public class Node
    {
        public int? val;
        public Node left;
        public Node right;

        public Node(int x)
        {
            val = x;
        }
    }
}
