using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FTRC.Extensions
{
    public static class IListExtensions
    {
        public static void RemoveSingle<T>(this IList<T> list, Predicate<T> pred)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (pred(list[i]))
                {
                    list.RemoveAt(i);
                    break;
                }
            }
        }
    }
}
