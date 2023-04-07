using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictioanaryOpenAdressingLinearProbing
{
    public class OtusDictionary
    {
        private int _capacity;
        private int _count;
        private int[] _keys;
        private string[] _values;
        public OtusDictionary(int initialCapacity = 2)
        {
            _keys = new int[initialCapacity];
            _values = new string[initialCapacity];
            _capacity = initialCapacity;
        }
        public void Add(int key, string value)
        {
            int index = key % _capacity;
            int originalIndex = index;

            while (_keys[index] != 0 && _keys[index] != key)
            {
                index = (index + 1) % _capacity;
                if (index == originalIndex)
                    continue;
                //Table is full and key is not found,so double the capacity
                int newCapacity = _capacity * 2;
                int[] newKeys = new int[newCapacity];
                string[] newValues = new string[newCapacity];

                //rehash all existing keys and values
                for (int i = 0; i < _capacity; i++)
                {
                    if (_keys[i] != 0)
                    {
                        int newIndex = _keys[i] % newCapacity;
                        while (newKeys[newIndex] != 0)
                        {
                            newIndex = (newIndex + 1) % newCapacity;
                        }
                        newKeys[newIndex] = _keys[i];
                        newValues[newIndex] = _values[i];
                    }
                }
                _keys = newKeys;
                _values = newValues;
                _capacity = newCapacity;
                //recalculate the index for the new key
                index = key % _capacity;
                originalIndex = index;

            }
            _keys[index] = key;
            _values[index] = value;
            _count++;
        }
        public string Get(int key)
        {
            int index = key % _capacity;
            int originalIndex = index;

            while (_keys[index] != 0 && _keys[index] != key)
            {
                index = (index + 1) % _capacity;

                if (index == originalIndex)
                {
                    //key is not found
                    throw new KeyNotFoundException();
                }
            }
            if (_keys[index] == 0)
            {
                throw new KeyNotFoundException();
            }
            return _values[index];
        }
        //Indexer
        public string this[int key]
        {
            get => Get(key);
            set => Add(key, value);
        }

    }
}
