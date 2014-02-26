using System;
using System.Collections.Generic;
using System.Linq;

namespace Data_Structures
{
    class Queueing<T>
    {
        private T[] _items = new T[0];

        public void Enqueue(T item)
        {
            Array.Resize(ref _items, _items.Count() + 1);
            _items[_items.Count() - 1] = item;
        }

        public void Dequeue()
        {
            if (_items.Length != 0)
            {
                const int index = 0;

                {
                    var newArray = new T[_items.Length - 1];

                    for (int i = 0; i < index; i++)
                    {
                        newArray[i] = _items[i];
                    }

                    for (int i = index; i < newArray.Length; i++)
                    {
                        newArray[i] = _items[i + 1];
                    }
                    _items = newArray;
                }
            }
            else 
                throw new Exception("Queue is currently empty");
        }

        public IEnumerable<T> GetItems()
        {
            return _items;
        }

        public string GetFirst()
        {
            var value = _items.GetValue(0).ToString();
            return value;
        }
    }
}
