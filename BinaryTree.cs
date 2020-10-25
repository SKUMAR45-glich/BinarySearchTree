using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class BinaryTree<T> where T : IComparable
    {
        public BinaryNode<T> rootNode;
        public BinaryNode<T> parentNode;

        public BinaryTree()
        {
            rootNode = null;
            parentNode = null;
        }

        public void AddData(T data)
        {
            if (rootNode == null)
            {
                rootNode = new BinaryNode<T>(data);
            }
            else
            {
                var node = new BinaryNode<T>(data);
                var temp = parentNode;
                if (data.CompareTo(rootNode.data) < 0)
                {
                    if (temp.lChild == null)
                        temp.lChild = node;
                    else
                    {
                        parentNode = temp.lChild;
                        AddData(data);
                    }
                }
                else
                {
                    if (temp.rChild == null)
                        temp.rChild = node;
                    else
                    {
                        parentNode = temp.rChild;
                        AddData(data);
                    }
                }
            }
            parentNode = rootNode;
        }

        public void Display(BinaryNode<T> parent)
        {
            Console.WriteLine($"Parent : {parent.data}");

            if (parent.lChild != null)
                Console.WriteLine($"Left : {parent.lChild.data}");

            if (parent.rChild != null)
                Console.WriteLine($"Right : {parent.rChild.data}");

            if (parent.lChild != null)
                Display(parent.lChild);

            if (parent.rChild != null)
                Display(parent.rChild);

        }
    }
}
