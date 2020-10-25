using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class BinaryNode<T> where T : IComparable
    {
        public T data;
        public BinaryNode<T> lChild;
        public BinaryNode<T> rChild;

        public BinaryNode(T data)
        {
            this.data = data;
            lChild = null;
            rChild = null;
        }
    }
}
