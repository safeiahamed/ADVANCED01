using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentAdv_1
{
    internal class Cache<TKey,TValue>
    {
        private List<TKey> keys = new List<TKey>();
        private List<TValue> values = new List<TValue>();

        public void Add(TKey key, TValue value)
        {
            keys.Add(key);
            values.Add(value);
        }

        public TValue Get(TKey key)
        {
            int index = keys.IndexOf(key);

            if (index == -1)
                return default;

            return values[index];
        }

        public void Remove(TKey key)
        {
            int index = keys.IndexOf(key);

            if (index != -1)
            {
                keys.RemoveAt(index);
                values.RemoveAt(index);
            }
        }

        public bool Contains(TKey key)
        {
            return keys.Contains(key);
        }
    }
}
