﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class BinaryTree<T> where T : IComparable
    {
        public BinaryNode<T> rootNode;
        public BinaryNode<T> leaveNode;
        public int NumberOfElements { get; private set; } = 0;
        public BinaryTree()
        {
            rootNode = null;
            leaveNode = null;
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
                var temp = leaveNode;
                if (data.CompareTo(rootNode.data) < 0)
                {
                    if (temp.lChild == null)
                        temp.lChild = node;
                    else
                    {
                        leaveNode = temp.lChild;
                        AddData(data);
                    }
                }
                else
                {
                    if (temp.rChild == null)
                        temp.rChild = node;
                    else
                    {
                        leaveNode = temp.rChild;
                        AddData(data);
                    }
                }
            }
            leaveNode = rootNode;
        }

        public void Display(BinaryNode<T> root)
        {
            Console.WriteLine($"Parent : {root.data}");
            

            if (root.lChild != null)
                Console.WriteLine($"Left : {root.lChild.data}");

            if (root.rChild != null)
                Console.WriteLine($"Right : {root.rChild.data}");

            if (root.lChild != null)
                Display(root.lChild);

            if (root.rChild != null)
                Display(root.rChild);

        }
        public int DepthofTree(BinaryNode<T> bnode)
        {
            if (bnode == null)
                return 0;
            else
            {
                /* compute the depth of each subtree */
                int lDepth = DepthofTree(bnode.lChild);
                int rDepth = DepthofTree(bnode.rChild);

                /* use the larger one */
                if (lDepth > rDepth)
                    return (lDepth + 1);
                else
                    return (rDepth + 1);
            }
        }
        public bool CheckNode(T data)
        {
            if (leaveNode == null)
                return false;

            if (leaveNode.data.CompareTo(data) == 0)
                return true;

            else if (leaveNode.data.CompareTo(data) > 0)
            {
                leaveNode = leaveNode.lChild;
                return CheckNode(data);
            }
            else
            {
                leaveNode = leaveNode.rChild;
                return CheckNode(data);
            }
        }

        public void SearchValue(T data)
        {
            if (CheckNode(data))
                Console.WriteLine($"{data} Found...");
            else
                Console.WriteLine($"{data} Absent");
        }
    }
}
