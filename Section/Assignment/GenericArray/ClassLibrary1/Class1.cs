using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{

    public class Database<TKey, TValue>
    {
        // Declare private fields for keys, values, and count.
        private TKey[] keys;
        private TValue[] values;
        private int count;


        public Database()
        {
            keys = new TKey[10];
            values = new TValue[10];
            count = 0;
        }

        public void Add(TKey key, TValue value)
        {
            
            keys[count] = key;
            values[count] = value;
            count++;
        }
        public bool Remove(TKey key) 
        {
            int index = System.Array.IndexOf(keys, key);
            if (index == -1) 
            {
                return false;
            }

            for (int i = index;i<count -1;i++) 
            {
                keys[i] = keys[i+1];
                values[i] = values[i+1];
            }
            count--;
            return true;
        }
        public bool TryGetValue(TKey key, out TValue value)
        {
            int index = System.Array.IndexOf(keys, key);
            if (index == -1)
            {
                value = default;
                return false;
            }
            value = values[index];
            return true;

        }
        public int Count
        {
            get { return count; }
        }

    }
}
