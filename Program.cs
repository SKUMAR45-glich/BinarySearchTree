﻿using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search Tree");

            BinaryTree<int> bst = new BinaryTree<int>();
            bst.AddData(10);
            bst.AddData(12);
            bst.AddData(4);
            bst.AddData(7);
            bst.AddData(22);

            bst.Display(bst.rootNode);
        }
    }
}
