using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryDemo
{
    class MyDictionary<T1, T2>
    {
        T1[] _keys;
        T2[] _values;
        public MyDictionary()
        {
            _keys = new T1[0];
            _values = new T2[0];
        }
        public void Add(T1 key, T2 value)
        {
            T1[] _tempKeys = _keys;
            T2[] _tempValues = _values;
            _keys = new T1[_keys.Length + 1];
            _values = new T2[_values.Length + 1];
            for (int i = 0; i < _tempKeys.Length; i++)
            {
                _keys[i] = _tempKeys[i];
                _values[i] = _tempValues[i];
            }
            _keys[_keys.Length - 1] = key;
            _values[_values.Length - 1] = value;
        }

        public int Length
        {
            get { return _keys.Length; }
        }

        public T1[] Keys
        {
            get { return _keys; }
        }

        public T2[] Values
        {
            get { return _values; }
        }

    }
}
