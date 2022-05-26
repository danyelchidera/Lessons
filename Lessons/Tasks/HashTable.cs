namespace Lessons.Tasks
{
    public class HashTable<T, U>
    {
        private class Entry
        {
            public T key;
            public U value;
        }

        LinkedList<Entry>[] entries = new LinkedList<Entry>[10];

        public void Add(T key, U vlaue)
        {
            var hash = HashFunction(key);
        }

        public int HashFunction(T key)
        {
            var hash = key.GetHashCode();
            if(hash < 0)
            {
                hash *= -1;
            }

            return hash % 10;
        }
    }
}
