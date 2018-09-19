using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternsSample.Behavioural
{
    /*
     Provide a way to access the elements of an aggregate object sequentially 
     without exposing its underlying representation.
     */

    public class Item
    {
        public Item(string name)
        {
            this.name = name;
        }

        private string name;
        public string Name
        {
            get { return name; }
        }
    }

    public interface ICollection
    {
        IIterator GetIterator();
    }

    public class Collection : ICollection
    {
        ArrayList collection = new ArrayList();

        public IIterator GetIterator()
        {
            return new Iterator(this);
        }

        public int Count
        {
            get { return collection.Count; }
        }

        public object this [int index]
        {
            get { return collection[index]; }
            set { collection.Add(value); }
        }
    }

    public interface IIterator
    {
        Item First();
        Item Next();
        bool IsDone { get; }
        int Step { get; set; }
        Item CurrentItem { get; }
    }

    public class Iterator : IIterator
    {
        Collection _collection;
        int _current = 0;
        int _step = 1;

        public Iterator(Collection collection)
        {
            this._collection = collection;
        }

        public int Step
        {
            get { return _step; }
            set
            {
                _step = value;
            }
        }

        public Item CurrentItem
        {
            get
            {
                if (_collection != null && _collection.Count > 0)
                    return _collection[_current] as Item;
                return null;
            }
        }

        public bool IsDone
        {
            get
            {
                return _current >= _collection.Count;
            }
        }

        public Item First()
        {
            if (_collection != null && _collection.Count > 0)
                return _collection[0] as Item;

            return null;
        }

        public Item Next()
        {
            _current += _step;
            if (!IsDone)
                return _collection[_current] as Item;

            return null;
        }
    }
}
