using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.Delegates
{
    public static class Lambda
    {         
        public static IEnumerable<T> MyWhereVersion<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            foreach(var item in source)
            {
                if(predicate(item))
                {
                    yield return item;
                }
            }
        }
    }
}
