class LRUCache {
public:

    unordered_map<int, int> cache;
    vector<int> v;
    int capacity;

    LRUCache(int capacity) {
        this->capacity = capacity;
    }

    int get(int key) {
        if (cache.find(key) == cache.end())
        {
            return -1;
        }

        v.erase(find(v.begin(), v.end(), key));
        v.push_back(key);

        return cache[key];
    }

    void put(int key, int value) {
        if (cache.find(key) != cache.end())
        {
            v.erase(find(v.begin(), v.end(), key));
            v.push_back(key);
            cache[key] = value;
        }
        else
        {
            if (v.size() >= capacity)
            {
                cache.erase(v[0]);
                v.erase(v.begin());
            }

            v.push_back(key);
            cache[key] = value;
        }
    }
};

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache* obj = new LRUCache(capacity);
 * int param_1 = obj->get(key);
 * obj->put(key,value);
 */