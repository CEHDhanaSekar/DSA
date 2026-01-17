namespace DSA.Queue;

public sealed class QueueList2<T>
{
    private int MAX_SIZE = 30;
    private T[] arr;
    private int rear;

    public QueueList2()
    {
        arr = new T[MAX_SIZE];
        rear = -1;
    }

    public QueueList2(int maxSize)
    {
        MAX_SIZE = maxSize;
        arr = new T[MAX_SIZE];
        rear = -1;
    }

    public void EnQueue(T value)
    {
        if (rear == MAX_SIZE - 1)
            throw new IndexOutOfRangeException("Queue Full");

        arr[++rear] = value;
    }

    public T DeQueue()
    {
        if (rear < 0)
            throw new IndexOutOfRangeException("Queue Is Empty");

        T res = arr[0];

        for(int i = 1; i <= rear; i++)
        {
            arr[i - 1] = arr[i];
        }

        rear--;
        return res;
    }

    public T GetFront()
    {
        if (rear < 0)
            throw new IndexOutOfRangeException("Queue Is Empty");

        return arr[0];
    }

    public int GetCount()
    {
        return rear + 1;
    }
}

/*
 * Pros & Cons This method of QUEUE implementation
 * Pros - DeQueue process takes O(n) time complexity
 * Cons - It Doesn't takes unwanted space in array
 */

