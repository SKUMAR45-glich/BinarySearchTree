using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class BinaryTree<T> where T : IComparable
    {
        public BinaryNode<T> rootNode;
        public BinaryNode<T> parentNode;
        public int NumberOfElements { get; private set; } = 0;
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
        public int CheckDeepth()
        {
            BinaryNode<T> temp = rootNode;
            int maxSize = 0;
            Stack<BinaryNode<T>> stack = new Stack<BinaryNode<T>>();

            while (temp != null || stack.Count != 0)
            {
                int size = 0;
                while (temp != null)
                {
                    stack.Push(temp);
                    temp = temp.lChild;
                    size++;
                }
                temp = stack.Pop();

                temp = temp.rChild;
                maxSize = maxSize < size ? size : maxSize;
            }
            return maxSize - 1;
        }
        public bool CheckPresence(T data)
        {
            if (parentNode == null)
                return false;

            if (parentNode.data.CompareTo(data) == 0)
                return true;

            else if (parentNode.data.CompareTo(data) > 0)
            {
                parentNode = parentNode.lChild;
                return CheckPresence(data);
            }
            else
            {
                parentNode = parentNode.rChild;
                return CheckPresence(data);
            }
        }

        public void SearchValue(T data)
        {
            if (CheckPresence(data))
                Console.WriteLine($"{data} Found...");
            else
                Console.WriteLine($"{data} Absent");
        }
    }
}
