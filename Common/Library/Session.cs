using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Library
{
    public static class Session<T>
    {
        public static T User { get; set; }

        public static bool LoginStatus { get; set; }
    }
}
