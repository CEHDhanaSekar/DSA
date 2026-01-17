namespace DSA.LinkedList;

public sealed class CircularLinkedList<T>
{
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

    private Node? tail;
    private int Count = 0;

    public CircularLinkedList()
    {
        tail = null;
    }

    public int GetCount()
    {
        return Count;
    }

    public bool IsEmpty()
    {
        return tail == null;
    }

    public void Display()
    {
        if(tail == null)
        {
            Console.WriteLine("No Elements in this list");
            return;
        }
        var temp = tail.next;
        do
        {
            Console.Write($"{temp!.value} -> ");
            temp = temp!.next;
        } while (temp != tail.next);
        Console.WriteLine("END");
    }

    public void InsertAtBegin(T value)
    {
        var newNode = new Node(value);

        if(tail == null)
        {
            newNode.next = newNode;
            tail = newNode;
        }
        else
        {
            newNode.next = tail.next;
            tail.next = newNode;
        }

        Count++;
    }

    public void InsertAtEnd(T value)
    {
        var newNode = new Node(value);

        if(tail == null)
        {
            newNode.next = newNode;
            tail = newNode;
        }
        else
        {
            newNode.next = tail.next;
            tail.next = newNode;
            tail = newNode;
        }

        Count++;
    }

    public void InsertAt(int index, T value)
    {
        if (index < 0 || index > Count)
            throw new IndexOutOfRangeException();

        if(index == 0)
        {
            InsertAtBegin(value);
        }
        else if(index == Count)
        {
            InsertAtEnd(value);
        }
        else
        {
            var newNode = new Node(value);
            var temp = tail;

            for(int i = 0; i < index; i++)
            {
                temp = temp!.next;
            }

            newNode.next = temp!.next;
            temp.next = newNode;
        }

        Count++;
    }

    public void DeleteAtEnd()
    {
        this.DeleteAt(Count - 1);
    }

    public void DeleteAtBegin()
    {
        this.DeleteAt(0);
    }

    public void DeleteAt(int index)
    {
        if (Count == 0)
        {
            Console.WriteLine("No Elements in this list");
            return;
        }

        if (index < 0 || index >= Count)
            throw new IndexOutOfRangeException();

        if(index == 0)
        {
            if(tail!.next == tail)
            {
                tail = null;
            }
            else
            {
                tail.next = tail!.next!.next;
            }
        }
        else
        {
            var temp = tail;
            for(int i = 0; i < index; i++)
            {
                temp = temp!.next;
            }
            temp!.next = temp!.next!.next;
            tail = temp;
        }
        Count--;
    }

    public bool Contains(T value)
    {
        if (Count == 0)
            return false;

        var temp = tail!.next;
        do
        {
            if (EqualityComparer<T>.Default.Equals(temp!.value, value))
                return true;

            temp = temp.next;

        } while (temp != tail.next);

        return false;
    }

    public int IndexOf(T value)
    {
        if (Count == 0)
            return -1;

        var temp = tail!.next;
        var idx = 0;
        do
        {
            if (EqualityComparer<T>.Default.Equals(temp!.value, value))
                return idx;

            temp = temp.next;
            idx++;

        } while (temp != tail.next);

        return -1;
    }

    public void Clear()
    {
        tail = null;
        Count = 0;
    }
}
