namespace DSA.Queue;

public sealed class QueueLinkedList<T>
{
    private Node? front, rear;
    private int Count;
    private class Node
    {
        public T value;
        public Node? next;

        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }
    }

    public QueueLinkedList()
    {
        front = null;
        rear = null;
        Count = 0;
    }

    public void EnQueue(T val)
    {
        Node newNode = new Node(val);

        if(front == null)
            front = newNode;
        else
            rear!.next = newNode;

        Count++;
        rear = newNode;
    }

    public T DeQueue()
    {
        if (front == null || rear == null)
            throw new IndexOutOfRangeException("Queue Is Empty");

        T res = front.value;
        front = front.next;

        if (front == null)
            rear = null;

        Count--;
        return res;
    }

    public T GetFront()
    {
        if (front == null)
            throw new IndexOutOfRangeException("Queue Is Empty");

        return front.value;
    }

    public bool IsEmpty()
    {
        return front == null;
    }

    public int GetCount()
    {
        return Count;
    }
}
