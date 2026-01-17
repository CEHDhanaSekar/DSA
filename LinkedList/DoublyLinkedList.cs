namespace DSA.LinkedList;

public sealed class DoublyLinkedList<T>
{
    private class Node
    {
        public T value;
        public Node? prev;
        public Node? next;

        public Node(T value)
        {
            this.value = value;
            this.next = null;
            this.prev = null;
        }
    }

    private Node? head;
    private Node? tail;
    private int Count = 0;

    public DoublyLinkedList()
    {
        head = null;
        tail = null;
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

    public void DisplayReverse()
    {
        var temp = tail;
        while (temp != null)
        {
            Console.Write($"{temp.value} -> ");
            temp = temp.prev;
        }
    }

    public int GetCount()
    {
        return Count;
    }

    public T Get(int index)
    {
        if (index < 0 || index >= Count)
            throw new IndexOutOfRangeException();

        if (index == 0)
        {
            return head!.value;
        }
        else if (index == Count - 1)
        {
            return tail!.value;
        }
        Node current;
        if (index <= Count / 2)
        {
            current = head!;
            for (int i = 0; i < index; i++)
                current = current.next!;
        }
        else
        {
            current = tail!;
            for (int i = Count - 1; i > index; i--)
                current = current.prev!;
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
        newNode.prev = tail;
        if (tail == null)
        {
            head = newNode;
        }
        else
        {
            tail.next = newNode;
        }
        tail = newNode;
        Count++;
    }

    public void InsertAtBegin(T item)
    {
        var newNode = new Node(item);
        newNode.next = head;
        if (head == null)
        {
            tail = newNode;
        }
        else
        {
            head.prev = newNode;
        }
        head = newNode;
        Count++;
    }

    public void InsertAt(int index, T item)
    {
        if (index < 0 || index > Count)
        {
            throw new IndexOutOfRangeException();
        }

        if (index == 0)
        {
            InsertAtBegin(item);
            return;
        }
        else if (index == Count)
        {
            InsertAtEnd(item);
            return;
        }

        var newNode = new Node(item);
        Node? temp = null;

        if (index <= Count / 2)
        {
            temp = head;
            for (int i = 1; i < index; i++)
            {
                temp = temp!.next;
            }
        }
        else
        {
            temp = tail;
            for (int i = Count - 1; i >= index; i--)
            {
                temp = temp!.prev;
            }
        }

        Node? nextNode = temp!.next;
        newNode.prev = temp;
        newNode.next = temp!.next;
        temp.next = newNode;
        nextNode!.prev = newNode;
        Count++; 
    }

    public void DeleteAtBegin()
    {
        if(Count == 0)
        {
            Console.WriteLine("There is no element in this list");
            return;
        }

        var temp = head!.next;

        if(temp == null)
            tail = null;
        else
            temp.prev = null;

        head = temp;
        Count--;
    }

    public void DeleteAt(int index)
    {
        if (index < 0 || index >= Count)
            throw new IndexOutOfRangeException();

        if (index == 0)
        {
            DeleteAtBegin();
            return;
        }

        if (index == Count - 1)
        {
            DeleteAtEnd();
            return;
        }

        Node current;

        if (index <= Count / 2)
        {
            current = head!;
            for (int i = 0; i < index; i++)
                current = current.next!;
        }
        else
        {
            current = tail!;
            for (int i = Count - 1; i > index; i--)
                current = current.prev!;
        }

        current.prev!.next = current.next;
        current.next!.prev = current.prev;
        Count--;
    }

    public void DeleteAtEnd()
    {
        if (Count == 0)
        {
            Console.WriteLine("There is no element in this list");
            return;
        }

        var temp = tail!.prev;

        if (temp == null)
            head = null;
        else
            temp.next = null;

        tail = temp;
        Count--;
    }

    public bool Contains(T item)
    {
        if (head == null)
        {
            return false;
        }
        Node temp = head;
        while (temp != null)
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

    public void Clear()
    {
        head = null;
        tail = null;
        Count = 0;
    }
}
