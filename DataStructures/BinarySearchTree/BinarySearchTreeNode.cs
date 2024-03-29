﻿namespace DataStructures.BinarySearchTree
{
    internal sealed class BinarySearchTreeNode
    {
        internal int _data;
        internal BinarySearchTreeNode _left;
        internal BinarySearchTreeNode _right;

        public BinarySearchTreeNode(int data)
        {
            _data = data;
            _left = null;
            _right = null;
        }
    }
}
