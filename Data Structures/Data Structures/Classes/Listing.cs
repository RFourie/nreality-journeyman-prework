using System;
using System.Collections.Generic;
using System.Linq;

namespace Data_Structures
{
    public class Listing<T>
    {
        private T[] _items = new T[0];

        public IEnumerable<T> GetItems()
        {
            return _items;
        }

        public void Add(T item)
        {
            Array.Resize(ref _items,_items.Count() + 1);
            _items[_items.Count() - 1] = item;
        }

        public void Remove(T item)
        {
            int index = Array.IndexOf(_items, item);

            if (index != -1)
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

        public int BinarySearch(T item)
        {
            int index = Array.BinarySearch(_items, item);
            if (index != -1)
            {
                return index;
            }
            throw new Exception("Item was not found in list");
        }
    }
}
