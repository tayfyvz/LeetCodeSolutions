public class LeastUsedCache
{
    public class LRUCache
    {
        private Dictionary<int, int> cache;
        private List<int> list;
        int capacity;
        
        public LRUCache(int capacity) 
        {
            cache = new Dictionary<int, int>(capacity);
            list = new List<int>();
            this.capacity = capacity;
        }
    
        public int Get(int key)
        {
            if (cache.ContainsKey(key))
            {
                list.Remove(key);
                list.Add(key);
                return cache[key];
            }

            return -1;
        }
    
        public void Put(int key, int value) 
        {
            if (cache.ContainsKey(key))
            {
                list.Remove(key);
                list.Add(key);
                cache[key] = value;
            }
            else
            {
                if (list.Count >= capacity)
                {
                    cache.Remove(list[0]);
                    list.RemoveAt(0);
                }
                list.Add(key);
                cache[key] = value;
            }
        }
    }    
}