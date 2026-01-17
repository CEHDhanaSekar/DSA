namespace DSA.Queue;

public sealed class QueueList<T>
{
    private int MAX_SIZE = 30;
    private T[] arr;
    private int Count;
    private int front;
    private int rear;

    public QueueList() 
    {
        arr = new T[MAX_SIZE];
        Count = 0;
        front = 0;
        rear = -1;
    }

    public QueueList(int maxSize)
    {
        MAX_SIZE = maxSize;
        arr = new T[MAX_SIZE];
        Count = 0;
        front = 0;
        rear = -1;
    }

    public void EnQueue(T value)
    {
        if (rear == MAX_SIZE - 1)
            throw new IndexOutOfRangeException("Queue Full");

        Count++;
        arr[++rear] = value;
    }

    public T DeQueue()
    {
        if (rear < 0 || front > rear)
            throw new IndexOutOfRangeException("Queue Is Empty");

        Count--;
        return arr[front++];
    }

    public T GetFront()
    {
        if (rear < 0 || front > rear)
            throw new IndexOutOfRangeException("Queue Is Empty");

        return arr[front];
    }

    public int GetCount()
    {
        return Count;
    }
}

/*
 * Pros & Cons This method of QUEUE implementation
 * Pros - DeQueue process takes only O(1) time complexity
 * Cons - It take unwanted space in array
 */
