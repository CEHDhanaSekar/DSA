namespace DSA.Stack;

public sealed class StackList<T>
{
    private int MAX_SIZE = 30;
    private T[] arr;
    private int peak;

    public StackList()
    {
        arr = new T[MAX_SIZE];
        peak = -1;
    }

    public StackList(int maxSize)
    {
        MAX_SIZE = maxSize;
        arr = new T[MAX_SIZE];
        peak = -1;
    }

    public void Push(T val)
    {
        if (peak == MAX_SIZE - 1)
            throw new IndexOutOfRangeException("Stack Is Full");

        arr[++peak] = val;
    }

    public T Pop()
    {
        if (peak < 0)
            throw new IndexOutOfRangeException("Stack Is Empty");

        return arr[peak--];
    }

    public T GetPeak()
    {
        if (peak < 0)
            throw new IndexOutOfRangeException("Stack Is Empty");

        return arr[peak];
    }

    public bool IsEmpty()
    {
        return peak < 0;
    }

    public int GetCount()
    {
        return peak + 1;
    }
}
