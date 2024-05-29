﻿using System;
using System.Collections.Generic;
namespace CustomList
{
    public class CustomList<T>
    {
        private List<T> _items;

        public CustomList()
        {
            _items = new List<T>();
        }

        public List<T> GetAll()
        {
            return _items;
        }

        public void Add(T item)
        {
            _items.Add(item);
        }

        public void Remove(T item)
        {
            if (!_items.Remove(item))
            {
                throw new ArgumentException("Item not found in the list");
            }
        }

        public bool Contains(T item)
        {
            return _items.Contains(item);
        }

        public bool Any()
        {
            return _items.Count > 0;
        }

        public void Clear()
        {
            _items.Clear();
        }

        public T? FirstOrDefault()
        {
            return _items.Count > 0 ? _items[0] : default(T);
        }

        public T? ElementAtOrDefault(int index)
        {
            return (index >= 0 && index < _items.Count) ? _items[index] : default(T);
        }

        public T? LastOrDefault()
        {
            return _items.Count > 0 ? _items[_items.Count - 1] : default(T);
        }
    }
}