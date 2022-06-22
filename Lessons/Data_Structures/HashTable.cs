namespace Lessons.Tasks
{
    public class HashTable<T, U>
    {
        LinkedList<Entry>[] entries = new LinkedList<Entry>[100];
        private int count = 0;  
        private class Entry
        {
            public T key;
            public U value;

            public int CompareTo(object? obj)
            {
                throw new NotImplementedException();
            }

            public override bool Equals(object? obj)
            {
                var entry = obj as Entry;
                return key.Equals(entry.key);
            }
        }
        public HashTable()
        {
            //for (int i = 0; i < entries.Length; i++)
            //{
            //    entries[i] = new LinkedList<Entry>();
            //}
        }
        public U this[T key]
        {
            get
            {
                var hash = HashFunction(key);
                var linkedList = entries[hash];
                if(linkedList != null && linkedList.Find(e => e.key.Equals(key)) != null)
                {
                    return linkedList.Find(e => e.key.Equals(key)).value;
                }
                throw new KeyNotFoundException("Key does not exist");

            }
            set {
                var hash = HashFunction(key);
                var linkedList = entries[hash];
                var val = linkedList.Find(e => e.key.Equals(key));
                if(val == null)
                {
                    throw new KeyNotFoundException("Key does not exist");
                }
                val.value = value;
            }
        }
        /// <summary>
        /// Adds an item to the hashtable
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Add(T key, U value)
        {
            var hash = HashFunction(key);
            /*linked list objects are initialised here(when they are needed) to avoid looping through the entire
             *array each time a new instance of hashtable is instantiated
             */
            if(entries[hash] == null)
            {
                entries[hash] = new LinkedList<Entry>();
            }
            var entry = new Entry { key = key, value = value };
            entries[hash].ReplaceOrAdd(entry);
            count++;
        }

        public void Remove(T key)
        {
            var hash = HashFunction(key);
            var linkedList = entries[hash];
            if (linkedList != null)
            {
                var entry =  linkedList.Find(e => e.key.Equals(key));
                if(entry != null)
                {
                    linkedList.Remove(entry);
                    count--;
                    return;
                }
            }
            throw new KeyNotFoundException("Key does not exist");
        }

        public int Count()
        {
            return count;
        }

        public int HashFunction(T key)
        {
            var hash = key.GetHashCode();
            return Math.Abs(hash) % entries.Length;
        }

    }
}
