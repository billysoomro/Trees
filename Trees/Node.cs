using System;

namespace Trees
{
    public class Node
    {
        public int Data { get; set; }

        public Node LeftNode { get; set; }

        public Node RightNode { get; set; }

        public Node(int data)
        {
            Data = data;
        }

        public Node()
        {
        }

        public void Insert(int value)
        {
            if (value > Data)
            {
                if (RightNode == null)
                {
                    RightNode = new Node(value);
                }

                else
                {
                    RightNode.Insert(value);
                }
            }

            else
            {
                if (LeftNode == null)
                {
                    LeftNode = new Node(value);
                }

                else
                {
                    LeftNode.Insert(value);
                }
            }
        }

        public int GetTreesum(Node tree)
        {
            if (tree == null) return 0;

            return tree.Data + GetTreesum(tree.LeftNode) + GetTreesum(tree.RightNode);
        }

        public void PrintInOrderTraversal(Node tree)
        {
            if (tree.LeftNode != null)
            {
                PrintInOrderTraversal(tree.LeftNode);
            }

            Console.WriteLine(tree.Data);

            if (tree.RightNode != null)
            {
                PrintInOrderTraversal(tree.RightNode);
            }
        }

        public void PrintPreOrderTraversal(Node tree)
        {
            Console.WriteLine(tree.Data);

            if (tree.LeftNode != null)
            {
                PrintInOrderTraversal(tree.LeftNode);
            }

            if (tree.RightNode != null)
            {
                PrintInOrderTraversal(tree.RightNode);
            }
        }

        public void PrintPostOrderTraversal(Node tree)
        {
            if (tree.LeftNode != null)
            {
                PrintInOrderTraversal(tree.LeftNode);
            }

            if (tree.RightNode != null)
            {
                PrintInOrderTraversal(tree.RightNode);
            }

            Console.WriteLine(tree.Data);
        }
    }
}
