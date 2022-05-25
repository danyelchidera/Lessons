

public class LinkedList<T>
{
   private class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public Node(T data)
        {
            this.Data = data;
        }
    }

    private Node<T> first;
    private Node<T> last;

    private int Count;

    public void Add(T data)
    {
        Node<T> newNode = new Node<T>(data);
        if (IsEmpty())
        {
            first = last = newNode;
        }
        else
        {
            last.Next = newNode;
            last = newNode;
        }
        Count++;

    }

    public bool Check(T data)
    {
        return Index(data) != -1;
    }

    public int Index(T data)
    {
        int counter = 0;
        var current = first;
        while (current != null)
        {
            if (current.Data.Equals(data))
            {
                return counter;
            }
            current = current.Next;
            counter++;
        }
        return -1;
    }

    public bool Remove(T data)
    {
        if (IsEmpty())
        {
            return false;
        }

        if (first.Data.Equals(data))
        {
            var temp = first;
            first = first.Next;
            temp.Next = null;
            return true;
        }


        var current = first;

        while (current.Next != null)
        {
            var next = current.Next;
            if (next.Data.Equals(data))
            {
                current.Next = next.Next;
                next.Next = null;
                return true;
            }
            current = next;
        }

        return false;

    } 

    public T RemoveFirst()
    {
        if (IsEmpty())
        {
            throw new EmptyListException("List is empty");
        }
        T data = first.Data;
        if (ContainsOneItem())
        {
            first = last = null;
        }
        else
        {
            var temp = first;
            first = first.Next;
            temp.Next = null;
        }

        Count--;

        return data;
    }

    public T RemoveLast()
    {

        if (IsEmpty())
        {
            throw new EmptyListException("List is empty");
        }

        T data = last.Data;

        if (ContainsOneItem())
        {

            first = last = null;
        }
        else
        {
            var current = first;
            while (current.Next != last)
            {
                current = current.Next;
            }

            current.Next = null;
            last = current;
        }
        Count--;
        return data;
    }



    public void Reverse()
    {
        if (IsEmpty())
        {
            return;
        }

        var current = first;

        while (current.Next != null)
        {
            var second = current.Next;
            current.Next = second.Next;

            second.Next = first;
            first = second;
        }

        last = current;
    }

    public void AddFirst(T data)
    {
        Node<T> newNode = new Node<T>(data);
        if (IsEmpty())
        {
            last = newNode;
        }

        newNode.Next = first;
        first = newNode;
        Count++;
    }

    public T ReturnLast()
    {
        if(IsEmpty())
            throw new EmptyListException("List is Empty");
        return last.Data;
    }


    public T FindKthNodeFromEnd(int k)
    {
        Node<T> a = first;
        Node<T> b = first;

        for (int i = 0; i < k - 1; i++)
        {
            b = b.Next;
            if (b != null)
            {
                throw new NullReferenceException();
            }
        }

        while (b != last)
        {
            a = a.Next;
            b = b.Next;
        }

        return a.Data;
    }

    public int Size()
    {
        return Count;
    }

    public bool IsEmpty()
    {
        return first == null;
    }

    private bool ContainsOneItem()
    {
        return first == last;
    }

    public void PrintLast(){
        System.Console.Write(last.Data);
    }

    public void PrintList()
    {
        Node<T> current = first;
        while(current != null)
        {
            Console.WriteLine(current.Data);
            current = current.Next;
        }

    }


}