namespace BinaryTree.Tree
{
    internal interface INode
    {
        Node Left { get; set; }
        Node Right { get; set; }
        int Value { get; set; }
    }
}