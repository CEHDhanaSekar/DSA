namespace DSA.Stack;

public sealed class StackLinkedList<T>
{
    private int Count;
    private Node? peak;

    private class Node
    {
        public T value;
        public Node? prev;

        public Node(T value)
        {
            this.value = value;
            this.prev = null;
        }
    }

    public StackLinkedList()
    {
        peak = null;
        Count = 0;
    }

    public void Push(T val)
    {
        Node? newNode = new Node(val);

        newNode.prev = peak;
        peak = newNode;
        Count++;
    }

    public T Pop()
    {
        if (peak == null)
            throw new NullReferenceException("Stack Is Empty");

        T res = peak.value;
        peak = peak.prev;
        Count--;

        return res;
    }

    public T GetPeak()
    {
        if (peak == null)
            throw new NullReferenceException("Stack Is Empty");

        return peak.value;
    }

    public bool IsEmpty()
    {
        return peak == null;
    }

    public int GetCount()
    {
        return Count;
    }
}
