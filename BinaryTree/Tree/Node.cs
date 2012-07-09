namespace BinaryTree.Tree
{
    class Node : INode
    {
        public Node Left { get; set; }
        public Node Right { get; set; }
        public int Value { get; set; }
        public Node Parent { get; set; }
    }
}