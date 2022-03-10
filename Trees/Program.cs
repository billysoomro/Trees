using System;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            var rootNode = new Node
            {
                Data = 25,
                LeftNode = new Node
                {
                    Data = 10,
                    LeftNode = new Node
                    {
                        Data = 15,
                    },
                    RightNode = new Node
                    {
                        Data = 10
                    }
                },
                RightNode = new Node
                {
                    Data = 15,
                    LeftNode = new Node
                    {
                        Data = 15,
                    },
                    RightNode = new Node
                    {
                        Data = 10
                    }
                }
            };
            
            Console.WriteLine($"Tree sum: {GetTreeSum(rootNode)}");
            Console.ReadLine();
        }

        private static int GetTreeSum(Node rootNode)
        {
            if (rootNode == null) return 0;

            return rootNode.Data + GetTreeSum(rootNode.LeftNode) + GetTreeSum(rootNode.RightNode);
        }
    }
}
