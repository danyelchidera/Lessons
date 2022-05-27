namespace Lessons.Tasks
{
    public class Queue<T>
    {
        private LinkedList<T> queue;

        public Queue()
        {
            queue = new LinkedList<T>();
        }
        //kkkkk
        public bool IsEmpty()
        {
            return queue.IsEmpty();
        }

        public void Enqueue(T data)
        {
            queue.Add(data);
        }

        public T Dequeue()
        {
            return queue.RemoveFirst();
        }

        public int Size()
        {
            return queue.Size();
        }

    }
}