using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Library
{
    public static class Entity<T> where T : class
    {
        public static T entity { get; set; }
        public static bool check { get; set; }
    }
}
