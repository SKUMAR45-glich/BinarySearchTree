using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search Tree");

            BinaryTree<int> bst = new BinaryTree<int>();
            bst.AddData(56);
            bst.AddData(30);
            bst.AddData(70);

            bst.Display(bst.rootNode);
            
        }
    }
}
