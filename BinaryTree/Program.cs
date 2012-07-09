using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BinaryTree.Tree;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {

            var tree = new Tree.Tree();

            tree.InsertRoot(new Node { Value = 1 });
            tree.InsertRightLeave(tree.Root, new Node { Value = 2 });
            tree.InsertLeftLeave(tree.Root, new Node { Value = 3 });
            tree.InsertLeftLeave(tree.Root.Left, new Node { Value = 4 });
            tree.InsertRightLeave(tree.Root.Left, new Node { Value = 5 });
            tree.InsertRightLeave(tree.Root.Right, new Node { Value = 5 });

            int cardinallity = tree.GetCardinallity();

            tree.InOrder(tree.Root);
        }

    }
}
