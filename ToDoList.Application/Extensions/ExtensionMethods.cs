using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Application.Extensions
{
    public static class ExtensionMethods
    {
        public static bool IsNullOrEmpty<ICollection>(this ICollection<object> value)
        {
            return value is null || value.Count == 0;
        }
    }
}
