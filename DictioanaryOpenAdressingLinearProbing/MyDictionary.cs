
namespace MyDictionary
{
    public class MyDictionary
    {
        private int _capacity;
        private int[] _keys;
        private string[] _values;
        private int _count;

        public MyDictionary(int initialCapacity)
        {
            _keys = new int[initialCapacity];
            _values = new string[initialCapacity];
            _capacity = initialCapacity;
        }

        public void Add(int key, string value)
        {
            if (_count == _capacity)
                Resize();

            var index = _count;
            _keys[index] = key;
            _values[index] = value ?? throw new ArgumentNullException(nameof(value), "Value can not be null");
            _count++;
        }

        private void Resize()
        {
            int newCapacity = _capacity * 2;
            int[] newKeys = new int[newCapacity];
            string[] newValues = new string[newCapacity];

            for (int i = 0; i < _capacity; i++)
            {
                newKeys[i] = _keys[i];
                newValues[i] = _values[i];
            }

            _keys = newKeys;
            _values = newValues;
            _capacity = newCapacity;
        }
        public string Get(int key)
        {
            for (int i = 0; i < _capacity; i++)
            {
                if (_keys[i] == key)
                    return _values[i];
            }

            return $" Key:[{key}] is not present in the dictionary";
        }
        public string this[int key]
        {
            get => Get(key);
        }
    }
}