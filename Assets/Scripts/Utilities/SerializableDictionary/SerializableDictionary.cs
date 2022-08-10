using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[System.Serializable]
public abstract class SerializableDictionary<TKey, TValue> : ScriptableObject, IDictionary<TKey, TValue>
{
    [System.Serializable]
    protected struct KeyValueContainer
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
    protected Dictionary<TKey, TValue> dictionary;

    // update dictionary equal to KVC
    // a Designer might go in and change a few things in the inspector
    private void OnEnable()
    {
        dictionary = new Dictionary<TKey, TValue>();

        keyValueContainers.ForEach((item) =>
        {
            dictionary.Add(item.Key, item.Value);
        });

        foreach(var item in dictionary)
        {
            Debug.Log($"Key: {item.Key}, Value: {item.Value}");
        }
    }


    // Set KVC equal to dictionary
    // other scripts may have changed a few things
    private void OnDisable()
    {
        keyValueContainers = new List<KeyValueContainer>();

        foreach(KeyValuePair<TKey, TValue> item in dictionary)
        {
            keyValueContainers.Add(new KeyValueContainer(item));
        }
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


    public void Add(TKey key, TValue value) => dictionary.Add(key, value);


    public bool ContainsKey(TKey key) => dictionary.ContainsKey(key);

    public bool Remove(TKey key) => dictionary.Remove(key);

    public bool TryGetValue(TKey key, out TValue value) => dictionary.TryGetValue(key, out value);

    public void Add(KeyValuePair<TKey, TValue> item) => this.Add(item.Key, item.Value);


    public void Clear() => dictionary.Clear();

    public bool Contains(KeyValuePair<TKey, TValue> item) => dictionary.Contains(item);

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
            this.Remove(item.Key);
            return true;
        }
        return false;
    }

    public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() => dictionary.GetEnumerator();

    // whats the difference?
    IEnumerator IEnumerable.GetEnumerator() => dictionary.GetEnumerator();
}
