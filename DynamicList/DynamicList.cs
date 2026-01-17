using System.Collections;

namespace DSA.DynamicList;

public class DynamicList<T> : IEnumerable<T>
{
    private readonly int initialCapacity = 8;
    private T[] arr;
    private int size;
    private int capacity;

    public DynamicList()
    {
        this.size = 0;
        this.capacity = this.initialCapacity;
        this.arr = new T[this.capacity];
    }

    private void IncreaseCapacity()
    {
        if (this.size == capacity)
        {
            this.capacity *= 2;
            T[] newArr = new T[this.capacity];
            Array.Copy(this.arr, newArr, this.size);
            arr = newArr;
        }
    }

    private void DecreaseCapacity()
    {
        if (this.size <= this.capacity / 4 && this.capacity > this.initialCapacity)
        {
            this.capacity /= 2;
            T[] newArr = new T[this.capacity];
            Array.Copy(this.arr, newArr, this.size);
            arr = newArr;
        }
    }

    public int GetSize()
    {
        return this.size;
    }

    public void PrintList()
    {
        for (int i = 0; i < this.size; i++)
        {
            Console.Write(this.arr[i] + " ");
        }
    }

    public void Clear()
    {
        this.size = 0;
        this.capacity = this.initialCapacity;
        this.arr = new T[this.capacity];
    }

    public T GetAt(int index)
    {
        if (index < 0 || index >= this.size)
        {
            throw new IndexOutOfRangeException("Index out of range");
        }
        return this.arr[index];
    }

    public void Add(T value)
    {
        if (this.size == capacity)
        {
            IncreaseCapacity();
        }
        this.arr[this.size++] = value;
    }

    public void InsertAt(int index, T value)
    {
        if(index < 0 || index >= this.size)
        {
            Console.WriteLine("InsertAt : Index out of range");
            throw new IndexOutOfRangeException("Index out of range");
        }
        IncreaseCapacity();
        for (int i = this.size; i > index; i--)
        {
            this.arr[i] = this.arr[i - 1];
        }
        this.arr[index] = value;
        this.size++;
    }

    public void InsertAtBegin(T value)
    {
        InsertAt(0, value);
    }

    public void InsertAtEnd(T value)
    {
        Add(value);
    }

    public void RemoveAt(int index)
    {
        if(index < 0 || index >= this.size)
        {
            throw new IndexOutOfRangeException("Index out of range");
        }
        for (int i = index; i < size - 1; i++)
        {
            this.arr[i] = this.arr[i + 1];
        }
        this.size--;
        
        DecreaseCapacity();
    }

    public void RemoveAtBegin()
    {
        RemoveAt(0);
    }

    public void RemoveAtEnd()
    {
        RemoveAt(this.size - 1);
    }

    public bool IsEmpty()
    {
        return this.size == 0;
    }

    public bool Contains(T value)
    {
        for (int i = 0; i < this.size; i++)
        {
            if (EqualityComparer<T>.Default.Equals(this.arr[i], value))
            {
                return true;
            }
        }
        return false;
    }

    public int IndexOf(T value)
    {
        for (int i = 0; i < this.size; i++)
        {
            if (EqualityComparer<T>.Default.Equals(this.arr[i], value))
            {
                return i;
            }
        }
        return -1;
    }

    public int ReplaceByValue(T target, T value)
    {
        for (int i = 0; i < this.size; i++)
        {
            if (EqualityComparer<T>.Default.Equals(this.arr[i], target))
            {
                this.arr[i] = value;
                return i;
            }
        }
        return -1;
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < this.size; i++)
        {
            yield return this.arr[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
