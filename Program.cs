using DSA.DynamicList;
using DSA.LinkedList;
using DSA.Queue;
using DSA.Stack;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- DATA STRUCTURE TESTER ---");
            Console.WriteLine("1. Dynamic List");
            Console.WriteLine("2. Singly Linked List");
            Console.WriteLine("3. Doubly Linked List");
            Console.WriteLine("4. Circular Linked List");
            Console.WriteLine("5. Queue List (Time Efficient)");
            Console.WriteLine("6. Queue List 2 (Space Efficient)");
            Console.WriteLine("7. Queue Linked List");
            Console.WriteLine("8. Stack List");
            Console.WriteLine("9. Stack Linked List");
            Console.WriteLine("0. Exit");

            Console.Write("Choose option: ");
            int choice = int.Parse(Console.ReadLine()!);

            switch (choice)
            {
                case 1:
                    TestDynamicList();
                    break;
                case 2:
                    TestLinkedList();
                    break;
                case 3:
                    TestDoublyLinkedList();
                    break;
                case 4:
                    TestCircularLinkedList();
                    break;
                case 5:
                    TestQueueList();
                    break;
                case 6:
                    TestQueueList2();
                    break;
                case 7:
                    TestQueueLinkedList();
                    break;
                case 8:
                    TestStackList();
                    break;
                case 9:
                    TestStackLinkedList();
                    break;
                case 0:
                    return;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }

    // ---------------- DYNAMIC LIST ----------------
    static void TestDynamicList()
    {
        var list = new DynamicList<int>();

        while (true)
        {
            Console.WriteLine("\n--- Dynamic List ---");
            Console.Write("1. Add | ");
            Console.Write("2. Insert At Begin | ");
            Console.Write("3. Insert At Index | ");
            Console.WriteLine();
            Console.Write("4. Remove At Begin | ");
            Console.Write("5. Remove At End | ");
            Console.Write("6. Remove At Index | ");
            Console.WriteLine();
            Console.Write("7. Display | ");
            Console.Write("8. Contains | ");
            Console.Write("9. Index Of | ");
            Console.WriteLine();
            Console.Write("10. Is Empty | ");
            Console.Write("11. Get Size | ");
            Console.Write("12. Get At Index | ");
            Console.WriteLine();
            Console.Write("13. Replace By Value | ");
            Console.Write("14. Clear | ");
            Console.Write("0. Back");
            Console.WriteLine();

            Console.Write("Choose: ");
            int option = int.Parse(Console.ReadLine()!);

            try
            {
                switch (option)
                {
                    case 1:
                        Console.Write("Enter value: ");
                        list.Add(int.Parse(Console.ReadLine()!));
                        break;

                    case 2:
                        Console.Write("Enter value: ");
                        list.InsertAtBegin(int.Parse(Console.ReadLine()!));
                        break;

                    case 3:
                        Console.Write("Index: ");
                        int idx = int.Parse(Console.ReadLine()!);
                        Console.Write("Value: ");
                        int val = int.Parse(Console.ReadLine()!);
                        list.InsertAt(idx, val);
                        break;

                    case 4:
                        list.RemoveAtBegin();
                        break;

                    case 5:
                        list.RemoveAtEnd();
                        break;

                    case 6:
                        Console.Write("Index: ");
                        list.RemoveAt(int.Parse(Console.ReadLine()!));
                        break;

                    case 7:
                        list.PrintList();
                        Console.WriteLine();
                        break;

                    case 8:
                        Console.Write("Value: ");
                        Console.WriteLine(list.Contains(int.Parse(Console.ReadLine()!)));
                        break;

                    case 9:
                        Console.Write("Value: ");
                        Console.WriteLine(list.IndexOf(int.Parse(Console.ReadLine()!)));
                        break;

                    case 10:
                        Console.WriteLine("Is Empty: " + list.IsEmpty());
                        break;

                    case 11:
                        Console.WriteLine("Size: " + list.GetSize());
                        break;

                    case 12:
                        Console.Write("Index: ");
                        Console.WriteLine("Value: " + list.GetAt(int.Parse(Console.ReadLine()!)));
                        break;

                    case 13:
                        Console.Write("Target value: ");
                        int target = int.Parse(Console.ReadLine()!);
                        Console.Write("New value: ");
                        int newValue = int.Parse(Console.ReadLine()!);
                        int replacedIndex = list.ReplaceByValue(target, newValue);
                        Console.WriteLine(
                            replacedIndex == -1
                                ? "Value not found"
                                : $"Replaced at index {replacedIndex}"
                        );
                        break;

                    case 14:
                        list.Clear();
                        Console.WriteLine("List cleared");
                        break;

                    case 0:
                        return;

                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

    // ---------------- SINGLY LINKED LIST ----------------
    static void TestLinkedList()
    {
        var list = new DSA.LinkedList.LinkedList<int>();

        while (true)
        {
            Console.WriteLine("\n--- Singly Linked List ---");
            Console.Write("1. Insert At End | ");
            Console.Write("2. Insert At Begin | ");
            Console.Write("3. Insert At Index | ");
            Console.WriteLine();
            Console.Write("4. Delete At End | ");
            Console.Write("5. Delete At Begin | ");
            Console.Write("6. Delete At Index | ");
            Console.WriteLine();
            Console.Write("7. Clear All | ");
            Console.Write("8. Contains | ");
            Console.Write("9. Index Of | ");
            Console.WriteLine();
            Console.Write("10. Display | ");
            Console.Write("11. Reverse The List | ");
            Console.Write("12. Check Is Empty | ");
            Console.Write("0. Back");
            Console.WriteLine();

            Console.Write("Choose: ");
            int option = int.Parse(Console.ReadLine()!);

            try
            {
                switch (option)
                {
                    case 1:
                        Console.Write("Value: ");
                        list.InsertAtEnd(int.Parse(Console.ReadLine()!));
                        break;

                    case 2:
                        Console.Write("Value: ");
                        list.InsertAtBegin(int.Parse(Console.ReadLine()!));
                        break;

                    case 3:
                        Console.Write("Index: ");
                        int idx = int.Parse(Console.ReadLine()!);
                        Console.Write("Value: ");
                        list.InsertAt(idx, int.Parse(Console.ReadLine()!));
                        break;

                    case 4:
                        list.DeleteAtEnd();
                        break;

                    case 5:
                        list.DeleteAtBegin();
                        break;

                    case 6:
                        Console.Write("Index: ");
                        list.DeleteAt(int.Parse(Console.ReadLine()!));
                        break;

                    case 7:
                        list.Clear();
                        break;

                    case 8:
                        Console.Write("Value: ");
                        Console.WriteLine(list.Contains(int.Parse(Console.ReadLine()!)));
                        break;

                    case 9:
                        Console.Write("Value: ");
                        Console.WriteLine(list.IndexOf(int.Parse(Console.ReadLine()!)));
                        break;

                    case 10:
                        list.Display();
                        break;

                    case 11:
                        list.Reverse();
                        break;

                    case 12:
                        var msg = list.IsEmpty() ? "Empty" : "Not Empty";
                        Console.WriteLine(msg);
                        break;

                    case 0:
                        return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

    // ---------------- DOUBLY LINKED LIST ----------------
    static void TestDoublyLinkedList()
    {
        var list = new DoublyLinkedList<int>();

        while (true)
        {
            Console.WriteLine("\n--- Doubly Linked List ---");
            Console.Write("1. Insert At End | ");
            Console.Write("2. Insert At Begin | ");
            Console.Write("3. Insert At Index | ");
            Console.WriteLine();
            Console.Write("4. Delete At End | ");
            Console.Write("5. Delete At Begin | ");
            Console.Write("6. Delete At Index | ");
            Console.WriteLine();
            Console.Write("7. Clear All | ");
            Console.Write("8. Contains | ");
            Console.Write("9. Index Of | ");
            Console.WriteLine();
            Console.Write("10. Display | ");
            Console.Write("11. Display In Reverse | ");
            Console.Write("12. Check Is Empty | ");
            Console.Write("0. Back");
            Console.WriteLine();

            Console.Write("Choose: ");
            int option = int.Parse(Console.ReadLine()!);

            try
            {
                switch (option)
                {
                    case 1:
                        Console.Write("Value: ");
                        list.InsertAtEnd(int.Parse(Console.ReadLine()!));
                        break;

                    case 2:
                        Console.Write("Value: ");
                        list.InsertAtBegin(int.Parse(Console.ReadLine()!));
                        break;

                    case 3:
                        Console.Write("Index: ");
                        int idx = int.Parse(Console.ReadLine()!);
                        Console.Write("Value: ");
                        list.InsertAt(idx, int.Parse(Console.ReadLine()!));
                        break;

                    case 4:
                        list.DeleteAtEnd();
                        break;

                    case 5:
                        list.DeleteAtBegin();
                        break;

                    case 6:
                        Console.Write("Index: ");
                        list.DeleteAt(int.Parse(Console.ReadLine()!));
                        break;

                    case 7:
                        list.Clear();
                        break;

                    case 8:
                        Console.Write("Value: ");
                        Console.WriteLine(list.Contains(int.Parse(Console.ReadLine()!)));
                        break;

                    case 9:
                        Console.Write("Value: ");
                        Console.WriteLine(list.IndexOf(int.Parse(Console.ReadLine()!)));
                        break;

                    case 10:
                        list.Display();
                        break;

                    case 11:
                        list.DisplayReverse();
                        break;

                    case 12:
                        var msg = list.IsEmpty() ? "Empty" : "Not Empty";
                        Console.WriteLine(msg);
                        break;

                    case 0:
                        return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

     }

    // ---------------- CIRCULAR LINKED LIST ----------------
    static void TestCircularLinkedList()
    {
        var list = new CircularLinkedList<int>();

        while (true)
        {
            Console.WriteLine("\n--- Circular Linked List ---");
            Console.Write("1. Insert At End | ");
            Console.Write("2. Insert At Begin | ");
            Console.Write("3. Insert At Index | ");
            Console.WriteLine();
            Console.Write("4. Delete At End | ");
            Console.Write("5. Delete At Begin | ");
            Console.Write("6. Delete At Index | ");
            Console.WriteLine();
            Console.Write("7. Clear All | ");
            Console.Write("8. Contains | ");
            Console.Write("9. Index Of | ");
            Console.WriteLine();
            Console.Write("10. Display | ");
            Console.Write("11. Check Is Empty | ");
            Console.Write("0. Back");
            Console.WriteLine();

            Console.Write("Choose: ");
            int option = int.Parse(Console.ReadLine()!);

            try
            {
                switch (option)
                {
                    case 1:
                        Console.Write("Value: ");
                        list.InsertAtEnd(int.Parse(Console.ReadLine()!));
                        break;

                    case 2:
                        Console.Write("Value: ");
                        list.InsertAtBegin(int.Parse(Console.ReadLine()!));
                        break;

                    case 3:
                        Console.Write("Index: ");
                        int idx = int.Parse(Console.ReadLine()!);
                        Console.Write("Value: ");
                        list.InsertAt(idx, int.Parse(Console.ReadLine()!));
                        break;

                    case 4:
                        list.DeleteAtEnd();
                        break;

                    case 5:
                        list.DeleteAtBegin();
                        break;

                    case 6:
                        Console.Write("Index: ");
                        list.DeleteAt(int.Parse(Console.ReadLine()!));
                        break;

                    case 7:
                        list.Clear();
                        break;

                    case 8:
                        Console.Write("Value: ");
                        Console.WriteLine(list.Contains(int.Parse(Console.ReadLine()!)));
                        break;

                    case 9:
                        Console.Write("Value: ");
                        Console.WriteLine(list.IndexOf(int.Parse(Console.ReadLine()!)));
                        break;

                    case 10:
                        list.Display();
                        break;

                    case 11:
                        var msg = list.IsEmpty() ? "Empty" : "Not Empty";
                        Console.WriteLine(msg);
                        break;

                    case 0:
                        return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

    // ---------------- QUEUE LIST ------------------
    static void TestQueueList()
    {
        var queue = new QueueList<int>();

        while (true)
        {
            Console.WriteLine("\n--- Queue List (Using Array - Time Efficient) ---");
            Console.Write("1. EnQueue Element | ");
            Console.Write("2. DeQueue Element | ");
            Console.Write("3. Get Front | ");
            Console.Write("0. Back");
            Console.WriteLine();

            Console.Write("Choose: ");
            int option = int.Parse(Console.ReadLine()!);

            try
            {
                switch (option)
                {
                    case 1:
                        Console.Write("Value: ");
                        queue.EnQueue(int.Parse(Console.ReadLine()!));
                        break;

                    case 2:
                        int dRes = queue.DeQueue();
                        Console.WriteLine($"Dequeue : {dRes}");
                        break;

                    case 3:
                        Console.WriteLine($"Front Element : {queue.GetFront()}");
                        break;

                    case 0:
                        return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

    // ---------------- QUEUE LIST 2 ------------------
    static void TestQueueList2()
    {
        var queue2 = new QueueList2<int>();

        while (true)
        {
            Console.WriteLine("\n--- Queue List (Using Array - Space Efficient) ---");
            Console.Write("1. EnQueue Element | ");
            Console.Write("2. DeQueue Element | ");
            Console.Write("3. Get Front | ");
            Console.Write("0. Back");
            Console.WriteLine();

            Console.Write("Choose: ");
            int option = int.Parse(Console.ReadLine()!);

            try
            {
                switch (option)
                {
                    case 1:
                        Console.Write("Value: ");
                        queue2.EnQueue(int.Parse(Console.ReadLine()!));
                        break;

                    case 2:
                        int dRes = queue2.DeQueue();
                        Console.WriteLine($"Dequeue : {dRes}");
                        break;

                    case 3:
                        Console.WriteLine($"Front Element : {queue2.GetFront()}");
                        break;

                    case 0:
                        return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

    // ---------------- QUEUE LINKED LIST ------------------
    static void TestQueueLinkedList()
    {
        var queueLL = new QueueLinkedList<int>();

        while (true)
        {
            Console.WriteLine("\n--- Queue Linked List (Using Linked List) ---");
            Console.Write("1. EnQueue Element | ");
            Console.Write("2. DeQueue Element | ");
            Console.Write("3. Get Front | ");
            Console.Write("4. Check Is Empty | ");
            Console.Write("0. Back");
            Console.WriteLine();

            Console.Write("Choose: ");
            int option = int.Parse(Console.ReadLine()!);

            try
            {
                switch (option)
                {
                    case 1:
                        Console.Write("Value: ");
                        queueLL.EnQueue(int.Parse(Console.ReadLine()!));
                        break;

                    case 2:
                        int dRes = queueLL.DeQueue();
                        Console.WriteLine($"Dequeue : {dRes}");
                        break;

                    case 3:
                        Console.WriteLine($"Front Element : {queueLL.GetFront()}");
                        break;

                    case 4:
                        Console.WriteLine(queueLL.IsEmpty() ? "Empty" : "Not Empty");
                        break;

                    case 0:
                        return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

    // ---------------- STACK LIST ------------------
    static void TestStackList()
    {
        var stack = new StackList<int>();

        while (true)
        {
            Console.WriteLine("\n--- Stack List ---");
            Console.Write("1. Push Element | ");
            Console.Write("2. Pop Element | ");
            Console.Write("3. Get Peak | ");
            Console.Write("4. Check Is Empty | ");
            Console.Write("0. Back");
            Console.WriteLine();

            Console.Write("Choose: ");
            int option = int.Parse(Console.ReadLine()!);

            try
            {
                switch (option)
                {
                    case 1:
                        Console.Write("Value: ");
                        stack.Push(int.Parse(Console.ReadLine()!));
                        break;

                    case 2:
                        int popRes = stack.Pop();
                        Console.WriteLine($"Pop : {popRes}");
                        break;

                    case 3:
                        Console.WriteLine($"Peak Element : {stack.GetPeak()}");
                        break;

                    case 4:
                        Console.WriteLine(stack.IsEmpty() ? "Empty" : "Not Empty");
                        break;

                    case 0:
                        return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

    // ---------------- STACK LINKED LIST ------------------
    static void TestStackLinkedList()
    {
        var stackLL = new StackList<int>();

        while (true)
        {
            Console.WriteLine("\n--- Stack Linked List ---");
            Console.Write("1. Push Element | ");
            Console.Write("2. Pop Element | ");
            Console.Write("3. Get Peak | ");
            Console.Write("4. Check Is Empty | ");
            Console.Write("0. Back");
            Console.WriteLine();

            Console.Write("Choose: ");
            int option = int.Parse(Console.ReadLine()!);

            try
            {
                switch (option)
                {
                    case 1:
                        Console.Write("Value: ");
                        stackLL.Push(int.Parse(Console.ReadLine()!));
                        break;

                    case 2:
                        int popRes = stackLL.Pop();
                        Console.WriteLine($"Pop : {popRes}");
                        break;

                    case 3:
                        Console.WriteLine($"Peak Element : {stackLL.GetPeak()}");
                        break;

                    case 4:
                        Console.WriteLine(stackLL.IsEmpty() ? "Empty" : "Not Empty");
                        break;

                    case 0:
                        return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
