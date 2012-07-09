namespace BinaryTree.Tree
{
    internal interface ITree
    {
        Node Root { get; set; }
        bool IsEmpty { get; }
        void InsertRoot(Node node);
        void InsertLeftLeave(Node parent, Node node);
        void InsertRightLeave(Node parent, Node node);
        int GetCardinallity();
        bool IsLeaf(Node node);
        Node RemoveLeftLeaf(Node node);
        Node RemoveRightLeaf(Node node);
        Node GetLeftChild(Node node);
        Node GetRightChild(Node node);
        Node GetParent(Node node);
        Node GetBrother(Node node);
        void PreOrder(INode node);
        void InOrder(INode node);
        void PostOrder(INode node);
    }
}