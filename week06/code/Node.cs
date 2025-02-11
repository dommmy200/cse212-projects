public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1
        // var trueFalse = Contains(value);
        // if (trueFalse) return;
        // If the value passed in is equal to the current node's data, return true
        if (Data == value)
            return;

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        // If the value passed in is equal to the current node's data, return true
        if (Data == value) return true;
        if (value < Data)
        {
            // Search to the left
            if (Left is not null) return Left.Contains(value);
        }
        else
        {
            // Search to the right
            if (Right is not null) return Right.Contains(value);
        }
        return false;
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        if (Left is null && Right is null)
            return 0;
        int leftHeight = (Left != null) ? Left.GetHeight() : 0;
        int rightHeight = (Right != null) ? Right.GetHeight() : 0;

        if (leftHeight <= rightHeight)
            return rightHeight + 1;
        else
            return leftHeight + 1;
    }
}