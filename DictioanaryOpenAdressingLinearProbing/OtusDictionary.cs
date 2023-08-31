
namespace DictioanaryOpenAdressingLinearProbing
{
    public class OtusDictionary
    {
        private int _capacity;
        private int[] _keys;
        private string[] _values;
        public OtusDictionary(int initialCapacity)
        {
            _keys = new int[initialCapacity];
            _values = new string[initialCapacity];
            _capacity = initialCapacity;
        }

        public void Add(int key, string value)
        {
            try
            {
                if (key == 0)
                {
                    Console.WriteLine("Key cannot be equal to 0.");
                    return;
                }
                int index = FindEmptySlot(key);

                if (_keys[index] == key)
                {
                    throw new Exception();
                }

                _values[index] = value ?? throw new ArgumentNullException(nameof(value));
                _keys[index] = key;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"null value not permitted.{ex.Message}");   
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Key {key} already exists. Value will not be overridden. {ex.Message}");
            }
        }

        private int FindEmptySlot(int key)
        {
            int index = Math.Abs(key) % _capacity;
       
            int originalIndex = index;

            while (_keys[index] != 0 && _keys[index] != key)
            {
                index = (index + 1) % _capacity;

                if (index != originalIndex)
                    continue;

                ResizeAndRehash();
                index = Math.Abs(key) % _capacity;
                originalIndex = index;
            }

            return index;
        }

        private void ResizeAndRehash()
        {
            int newCapacity = _capacity * 2;
            int[] newKeys = new int[newCapacity];
            string[] newValues = new string[newCapacity];

            for (int i = 0; i < _capacity; i++)
            {
                int newIndex = FindEmptySlot(_keys[i]);
                newKeys[newIndex] = _keys[i];
                newValues[newIndex] = _values[i];
            }

            _keys = newKeys;
            _values = newValues;
            _capacity = newCapacity;
        }

        public string Get(int key)
        {
            int index = FindKeyIndex(key);

            if (_keys[index] == 0)
            {
                Console.WriteLine("Key does not exist ");
            }

            return _values[index];
        }

        private int FindKeyIndex(int key)
        {
            int index = Math.Abs(key) % _capacity;

            while (_keys[index] != 0 && _keys[index] != key && index != 0)
            {
                index = (index + 1) % _capacity;
            }

            return index;
        }

        public string this[int key]
        {
            get => Get(key);
            set => Add(key, value);
        }
    }
}
