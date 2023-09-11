
namespace MyDictionary
{
    public class MyDictionary
    {
        private int _capacity;
        private int[] _keys;
        private string[] _values;
        public MyDictionary(int initialCapacity)
        {
            _keys = new int[initialCapacity];
            _values = new string[initialCapacity];
            _capacity = initialCapacity;
        }

        public void Add(int key, string value)
        {
            var index = Math.Abs(key) % _capacity;

            if (_values[index] == null)
            {
                _values[index] = value ?? throw new ArgumentNullException(nameof(value), "Value can not be null");
                _keys[index] = key;
            }
            else
            {
                int newCapacity = _capacity * 2;
                int[] newKeys = new int[newCapacity];
                string[] newValues = new string[newCapacity];

                for (int i = 0; i < _capacity; i++)
                {
                    var newIndex = Math.Abs(_keys[i]) % _capacity;
                    newKeys[newIndex] = _keys[newIndex];
                    newValues[newIndex] = _values[newIndex];
                }

                _keys = newKeys;
                _values = newValues;
                _capacity = newCapacity;
                Add(key, value);
            }
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

        public string this[int key] => Get(key);
    }
}