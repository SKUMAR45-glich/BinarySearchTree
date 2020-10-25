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
            bst.AddData(22);
            bst.AddData(40);
            bst.AddData(11);
            bst.AddData(3);
            bst.AddData(67);
            bst.AddData(63);

            bst.Display(bst.rootNode);
            int h = bst.DepthofTree(bst.rootNode);
            Console.WriteLine("Height is:" + h);
            bst.SearchValue(63);
        }
    }
}
