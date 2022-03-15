using System;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            var treeOne = new Node(25)
            {
                LeftNode = new Node(10)
                {
                    LeftNode = new Node(15),
                    RightNode = new Node(10)
                },
                RightNode = new Node(15)
                {
                    LeftNode = new Node(15),
                    RightNode = new Node(10)
                }
            };

            Console.WriteLine($"Tree sum from treeOne: {treeOne.GetTreesum(treeOne)}");

            var treeTwo = new Node(5)
            {
                LeftNode = new Node(8),
                RightNode = new Node(10)
                {
                    RightNode = new Node(12)
                }
            };

            Console.WriteLine($"Tree sum from treeTwo before insert: {treeTwo.GetTreesum(treeTwo)}");
            
            treeTwo.Insert(9);
            
            Console.WriteLine($"Tree sum from treeTwo after insert: {treeTwo.GetTreesum(treeTwo)}");

            Console.WriteLine("Inorder tree traversal of treeTwo");
            treeTwo.PrintInOrderTraversal(treeTwo);
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Preorder tree traversal of treeTwo");
            treeTwo.PrintPreOrderTraversal(treeTwo);
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Postorder tree traversal of treeTwo");
            treeTwo.PrintPostOrderTraversal(treeTwo);

            Console.ReadLine();
        }
    }
}
