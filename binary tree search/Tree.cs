class Tree
{
    private Node root;

    public void Add(int data)
    {
        root = AddRecursive(root, data);
    }

    private Node AddRecursive(Node current, int data)
    {
        if (current == null)
        {
            return new Node(data);
        }

        if (data < current.Data)
        {
            current.Left = AddRecursive(current.Left, data);
        }
        else if (data > current.Data)
        {
            current.Right = AddRecursive(current.Right, data);
        }

        return current;
    }

    public Node Search(int data)
    {
        return SearchRecursive(root, data);
    }

    private Node SearchRecursive(Node current, int data)
    {
        if (current == null || current.Data == data)
        {
            return current;
        }

        if (data < current.Data)
        {
            return SearchRecursive(current.Left, data);
        }

        return SearchRecursive(current.Right, data);
    }
}