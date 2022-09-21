using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[System.Serializable]
public abstract class SerializableDictionary<TKey, TValue> : ScriptableObject, IDictionary<TKey, TValue>
{
    [System.Serializable]
    private struct KeyValueContainer
    {
        [field: SerializeField] public TKey Key;
        [field: SerializeField] public TValue Value;

        public KeyValueContainer(TKey key, TValue value)
        {
            this.Key = key;
            this.Value = value;
        }

        public KeyValueContainer(KeyValuePair<TKey, TValue> item)
        {
            this.Key = item.Key;
            this.Value = item.Value;
        }
    }

    [field: SerializeField] private List<KeyValueContainer> keyValueContainers;
    private Dictionary<TKey, TValue> dictionary;

    protected void OnEnable()
    {
        // sets dictionary to values in inspector in case
        // an editor goes in and changes values in inspector
        // other than this, dictionary should always equal inspector values
        dictionary = new Dictionary<TKey, TValue>();

        keyValueContainers.ForEach((item) => dictionary.Add(item.Key, item.Value));
    }

    public ICollection<TKey> Keys => dictionary.Keys;

    public ICollection<TValue> Values => dictionary.Values;

    public int Count => dictionary.Count;

    public bool IsReadOnly => false;

    public TValue this[TKey key] 
    {
        get => this.ContainsKey(key) ? dictionary[key] : default(TValue);
        set => dictionary[key] = value;
    }


    public void Add(TKey key, TValue value)
    {
        if (this.Contains(key, value) == false)
        {
            dictionary.Add(key, value);
            keyValueContainers.Add(new KeyValueContainer(key, value));
        }
    }

    public bool ContainsKey(TKey key)
    {
        return dictionary.ContainsKey(key) && keyValueContainers.Exists(item => item.Key.Equals(key));
    }

    public bool Remove(TKey key)
    {
        return dictionary.Remove(key) && keyValueContainers.Remove(keyValueContainers.First(item => item.Key.Equals(key)));
    }

    public bool TryGetValue(TKey key, out TValue value) => dictionary.TryGetValue(key, out value);

    public void Add(KeyValuePair<TKey, TValue> item) => this.Add(item.Key, item.Value);


    public void Clear()
    {
        dictionary.Clear();
        keyValueContainers.Clear();
    }

    public bool Contains(TKey key, TValue value) => this.Contains(new KeyValuePair<TKey, TValue>(key, value));


    public bool Contains(KeyValuePair<TKey, TValue> item)
    {
        return dictionary.Contains(item) && keyValueContainers.Contains(new KeyValueContainer(item));
    }

    public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
    {
        foreach(KeyValuePair<TKey, TValue> item in dictionary)
        {
            if (arrayIndex >= array.Count())
            {
                return;
            }

            array[arrayIndex] = item;
            arrayIndex++;
        }
    }

    public bool Remove(KeyValuePair<TKey, TValue> item)
    {
        if (this.Contains(item))
        {
            return this.Remove(item.Key);
        }
        return false;
    }

    public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() => dictionary.GetEnumerator();

    // whats the difference?
    IEnumerator IEnumerable.GetEnumerator() => dictionary.GetEnumerator();
}
