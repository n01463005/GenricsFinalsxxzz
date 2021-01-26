using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Container<int> container = new Container<int>();
            container.Add(3);
            container.Add(13);
            container.Add(23);
        }
    }
    public class Container<T> where T : struct
    {
        private List<T> list = new List<T>();
        public void Add(T item)
        {
            list.Add(item);
        }
        public T Get(int num)
        {
            return list[num];
        }

        public List<T> Sorted()
        {
            return list.OrderByDescending(list => list).ToList();
        }
    }
}

