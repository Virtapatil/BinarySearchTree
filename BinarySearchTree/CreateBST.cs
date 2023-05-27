using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public interface INode<T> where T : IComparable<T>
    {
        T Key { get; set; }
        INode<T> Left { get; set; }
        INode<T> Right { get; set; }
    }

    public class MyBinaryNode<T> : INode<T> where T : IComparable<T>
    {
        public T Key { get; set; }
        public INode<T> Left { get; set; }
        public INode<T> Right { get; set; }

        public MyBinaryNode(T key)
        {
            Key = key;
            Left = null;
            Right = null;
        }
    }

    public class BinarySearchTree<T> where T : IComparable<T>
    {
        private INode<T> root;

        public void Insert(T key)
        {
            root = InsertNode(root, key);
        }

        private INode<T> InsertNode(INode<T> node, T key)
        {
            if (node == null)
            {
                return new MyBinaryNode<T>(key);
            }

            if (key.CompareTo(node.Key) < 0)
            {
                node.Left = InsertNode(node.Left, key);
            }
            else if (key.CompareTo(node.Key) > 0)
            {
                node.Right = InsertNode(node.Right, key);
            }

            return node;
        }
    }
}
