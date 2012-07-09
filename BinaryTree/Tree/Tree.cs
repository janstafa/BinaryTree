using System;
using System.Collections.Generic;

namespace BinaryTree.Tree
{
    internal class Tree : ITree
    {
        public Node Root { get; set; }
        public bool IsEmpty { get { return Root == null; } }


        public Tree()
        {
            Root = null;
        }

        public void InsertRoot(Node node)
        {
            #region Defensive area

            if (node == null)
            {
                throw new ArgumentNullException("node", "Inserted node can't be null.");
            }

            #endregion

            Root = node;
        }


        public void InsertLeftLeave(Node parent, Node node)
        {
            #region Defensive area

            if (parent == null)
            {
                throw new ArgumentNullException("parent", "Parent node can't be null.");
            }

            if (node == null)
            {
                throw new ArgumentNullException("node", "Inserted node can't be null.");
            }

            #endregion

            parent.Left = node;
        }

        public void InsertRightLeave(Node parent, Node node)
        {
            #region Defensive area

            if (parent == null)
            {
                throw new ArgumentNullException("parent", "Parent node can't be null.");
            }

            if (node == null)
            {
                throw new ArgumentNullException("node", "Inserted node can't be null.");
            }

            #endregion

            parent.Right = node;
        }

        public int GetCardinallity()
        {
            return NodeCount(Root);
        }

        public bool IsLeaf(Node node)
        {
            return node.Left == null & node.Right == null;
        }

        public Node RemoveLeftLeaf(Node node)
        {
            if (!IsLeaf(node.Left))
            {
                throw new InvalidOperationException("Removed node is not leaf and can't be removed.");
            }

            node.Left = null;
            return node;
        }

        public Node RemoveRightLeaf(Node node)
        {
            if (!IsLeaf(node.Right))
            {
                throw new InvalidOperationException("Removed node is not leaf and can't be removed.");
            }

            node.Right = null;
            return node;
        }

        public Node GetLeftChild(Node node)
        {
            return node.Left;
        }

        public Node GetRightChild(Node node)
        {
            return node.Right;
        }

        public Node GetParent(Node node)
        {
            return node.Parent;
        }

        public Node GetBrother(Node node)
        {
            if (node.Parent.Left == node)
            {
                return node.Parent.Right;
            }

            return node.Parent.Left;
        }

        public void PreOrder(INode node)
        {
            if (node == null)
            {
                return;
            }

            Console.Write(node.Value + " ");
            InOrder(node.Left);
            InOrder(node.Right);
        }

        public void InOrder(INode node)
        {
            if (node == null)
            {
                return;
            }

            InOrder(node.Left);
            Console.Write(node.Value + " ");
            InOrder(node.Right);
        }

        public void PostOrder(INode node)
        {
            if (node == null)
            {
                return;
            }

            InOrder(node.Left);
            InOrder(node.Right);
            Console.Write(node.Value + " ");
        }

        private int NodeCount(Node node)
        {
            if (node == null)
            {
                return 0;
            }

            if (node.Left == null && node.Right == null)
            {
                return 1;
            }

            return (1 + (NodeCount(node.Left) + NodeCount(node.Right)));
        }
    }
}