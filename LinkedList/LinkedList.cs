namespace DSA.LinkedList;

public sealed class LinkedList<T>
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

    private Node? head;
    private int Count;

    public LinkedList()
    {
        head = null;
        Count = 0;
    }

    public void Display()
    {
        var temp = head;
        while (temp != null)
        {
            Console.Write($"{temp.value} -> ");
            temp = temp.next;
        }
        Console.WriteLine("End");
    }

    public int GetCount()
    {
        return Count;
    }

    public T Get(int index)
    {
        if (index < 0 || index >= Count)
            throw new IndexOutOfRangeException();

        Node current = head!;
        for (int i = 0; i < index; i++)
        {
            current = current.next!;
        }
        return current.value;
    }

    public bool IsEmpty()
    {
        return head == null;
    }

    public void InsertAtEnd(T item)
    {
        var newNode = new Node(item);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            var temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = newNode;
        }
        Count++;
    }

    public void InsertAtBegin(T item)
    {
        var newNode = new Node(item);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            newNode.next = head;
            head = newNode;
        }
        Count++;
    }

    public void InsertAt(int index, T item)
    {
        if (index < 0 || index > Count)
            throw new IndexOutOfRangeException();

        if (index == 0)
        {
            InsertAtBegin(item);
            return;
        }

        Node temp = head!;
        for (int i = 0; i < index - 1; i++)
        {
            temp = temp.next!;
        }

        var newNode = new Node(item);
        newNode.next = temp.next;
        temp.next = newNode;
        Count++;
    }

    public void DeleteAtBegin()
    {
        this.DeleteAt(0);
    }

    public void DeleteAtEnd()
    {
        this.DeleteAt(Count - 1);
    }

    public void DeleteAt(int index)
    {
        if(Count == 0)
        {
            Console.WriteLine("There is no element in this list");
            return;
        }

        if (index < 0 || index >= Count)
            throw new IndexOutOfRangeException();

        if (index == 0)
        {
            head = head!.next;
            Count--;
            return;
        }

        Node current = head!;
        for (int i = 0; i < index - 1; i++)
        {
            current = current.next!;
        }

        current.next = current.next!.next;
        Count--;
    }

    public bool Contains(T item)
    {
        if(head == null)
        {
            return false;
        }
        Node temp = head;
        while(temp != null)
        {
            if (EqualityComparer<T>.Default.Equals(temp.value, item))
            {
                return true;
            }
            temp = temp.next!;
        }
        return false;
    }

    public int IndexOf(T item)
    {
        if (head == null)
        {
            return -1;
        }
        Node temp = head;
        int index = 0;
        while (temp != null)
        {
            if (EqualityComparer<T>.Default.Equals(temp.value, item))
            {
                return index;
            }
            temp = temp.next!;
            index++;
        }
        return -1;
    }

    public T[] ToArray()
    {
        T[] array = new T[Count];
        Node? temp = head;
        int index = 0;
        while (temp != null)
        {
            array[index] = temp.value!;
            temp = temp.next;
            index++;
        }
        return array;
    }

    public void Reverse()
    {
        if(head == null || head.next == null)
        {
            return;
        }

        Node? prevNode = null;
        Node? currentNode = head;
        Node? nextNode = head.next;

        while (currentNode != null)
        {
            nextNode = currentNode.next;
            currentNode.next = prevNode;
            prevNode = currentNode;
            currentNode = nextNode;
        }

        head = prevNode;
    }

    public void Clear()
    {
        head = null;
        Count = 0;
    }

}
 