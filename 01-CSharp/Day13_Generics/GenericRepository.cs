using System;
using System.Collections.Generic;
using System.Text;

namespace Day13_Generics;

public class GenericRepository<T>
{
    private readonly List<T> _items = new();

    public void Add(T item)
    {
        _items.Add(item);
    }

    public List<T> GetAll()
    {
        return _items;
    }

    public int Count
    {
        get
        {
            return _items.Count;
        }
    }

    
    
    
}
