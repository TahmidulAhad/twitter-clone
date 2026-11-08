using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Utilities.Extensions
{
    public static class ListExtensions
    {
        public static T? LastOrNull<T>(this List<T> items) where T : class
        {
            return items.Count > 0 ? items[^1] : null;
        }
    }
}
