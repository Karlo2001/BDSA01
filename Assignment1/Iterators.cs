using System;
using System.Collections.Generic;

namespace Assignment1
{
    public static class Iterators
    {
        public static IEnumerable<T> Flatten<T>(IEnumerable<IEnumerable<T>> items)
        {
            foreach (var list in items)
            {
                foreach (var item in list)
                {
                    yield return item;
                }
            }
        }

        public static IEnumerable<T> Filter<T>(IEnumerable<T> items, Predicate<T> predicate)
        {
            foreach(var item in items)
            {
                if(predicate(item))
                {
                    yield return item;
                }
            }
        }

        public static bool Odd(int i)
        {
            return i % 2 == 1;
        }
        public static bool Even(int i)
        {
            return i % 2 == 0;
        }
        public static bool DivisibleByFour(int i)
        {
            return i % 4 == 0;
        }
        public static bool LengthEqualsThree(string str)
        {
            return str.Length == 3;
        }
    }
}
