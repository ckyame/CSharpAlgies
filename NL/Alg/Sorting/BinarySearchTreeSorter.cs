using System;
using System.Collections.Generic;

using NL.Alg.Compare;

namespace NL.Alg.Sorting
{
    public static class BinarySearchTreeSorter
    {
        /// <summary>
        /// Unbalanced Binary Search 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        public static void UnbalancedBSTSort<T>(this List<T> source) where T : IComparable<T>
        {
            if (source.Count == 0)
                return;
            Node<T> root = new Node<T>() { Value = source[0] };          
            for (int i = 1; i < source.Count; ++i)   
            {
                var current = root;
                var newNode = new Node<T>() { Value = source[i] };
                while (true)
                {                   
                    if (newNode.Value.ValueLessThan<T>(current.Value)) // left
                    {
                        if (current.Left == null)
                        {
                            newNode.Parent = current;
                            current.Left = newNode;
                            break;
                        }
                        current = current.Left;
                    }
                    else                                                // right
                    {
                        if (current.Right == null)
                        {
                            newNode.Parent = current;
                            current.Right = newNode;
                            break;
                        }
                        current = current.Right;
                    }
                }
            }
            source.Clear();
            var rootref = root;
            _inOrderTravelAndAdd(rootref, ref source);
            rootref = root = null;
        }
        /// <summary>
        /// In Order Traversal
        /// </summary>
        /// <typeparam name="T">Type of tree elements.</typeparam>
        /// <param name="currentNode">Node to start from.</param>
        /// <param name="collection">Collection to add elements to.</param>
        private static void _inOrderTravelAndAdd<T>(Node<T> currentNode, ref List<T> list) where T : IComparable<T>
        {
            if (currentNode == null)
                return;
            _inOrderTravelAndAdd<T>(currentNode.Left, ref list);
            list.Add(currentNode.Value);
            _inOrderTravelAndAdd<T>(currentNode.Right, ref list);
        }
        /// <summary>
        /// Tree Node 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        private class Node<T> : IComparable<Node<T>> where T : IComparable<T>
        {
            public T Value { get; set; }
            public Node<T> Parent { get; set; }
            public Node<T> Left { get; set; }
            public Node<T> Right { get; set; }
            public Node()
            {
                Value = default(T);
                Parent = null;
                Left = null;
                Right = null;
            }
            public int CompareTo(Node<T> other)
            {
                if (other == null) return -1;
                return this.Value.CompareTo(other.Value);
            }
        }
    }
}
