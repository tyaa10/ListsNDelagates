using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    class MySort
    {
        public delegate int MyComparator(object o1, object o2);
        public static void IntSortAsc(List<int> _integers) {

            bool sorted = false;
            do
            {
                sorted = true;
                for (int i = 0; i < _integers.Count - 1; i++)
                {
                    if (_integers[i] - _integers[i + 1] > 0)
                    {
                        int tmp = _integers[i];
                        _integers[i] = _integers[i + 1];
                        _integers[i + 1] = tmp;
                        sorted = false;
                    }
                }
            } while (!sorted);
        }

        public static void UniversalSort(ArrayList _items, MyComparator _comparator)
        {
            bool sorted = false;
            do
            {
                sorted = true;
                for (int i = 0; i < _items.Count - 1; i++)
                {
                    if (_comparator(_items[i], _items[i + 1]) > 0)
                    {
                        object tmp = _items[i];
                        _items[i] = _items[i + 1];
                        _items[i + 1] = tmp;
                        sorted = false;
                    }
                }
            } while (!sorted);
        }
    }
}
