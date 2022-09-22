namespace Libraries
{
    using System.Collections.Generic;
    using UnityEngine;

    [System.Serializable]
    public class SerializableDictionary<K, V> : Dictionary<K, V>, ISerializationCallbackReceiver
    {
        [System.Serializable]
        private struct SerializableKVP<TKey, TValue>
        {
            public TKey Key;
            public TValue Value;

            public SerializableKVP(TKey key, TValue value)
            {
                this.Key = key;
                this.Value = value;
            }
        }

        [SerializeField]
        private List<SerializableKVP<K, V>> dictionary = new List<SerializableKVP<K, V>>();

        public void OnBeforeSerialize()
        {
            dictionary.Clear();

            foreach (var kvp in this)
            {
                dictionary.Add(new SerializableKVP<K, V>(kvp.Key, kvp.Value));
            }
        }

        public void OnAfterDeserialize()
        {
            this.Clear();
            foreach (var kvp in dictionary)
            {
                this.Add(kvp.Key, kvp.Value);
            }
        }
    }
}