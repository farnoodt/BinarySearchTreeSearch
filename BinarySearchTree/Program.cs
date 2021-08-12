using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node tree = new Node(30);
            tree.left = new Node(23);
            tree.right = new Node(35);

            Search S = new Search();
            Console.WriteLine( S.BinarySearchTreeSearch(tree, 25));
            Console.WriteLine("Hello World!");
        }
    }
}
