public class Stack<T>
{
    private LinkedList<T> stack;

    public Stack()
    {
        stack = new LinkedList<T>();
    }

    public T Push(T data)
    {
        stack.Add(data);
        return data;
    }

    public T Pop()
    {
        return stack.RemoveLast();
    }

    public T peek()
    {
        return stack.ReturnLast();
    }

    public int Size()
    {
        return Size();
    }

    public bool IsEmpty()
    {
        return stack.IsEmpty();
    }

    public void Print()
    {
        stack.PrintList();
    }

}