using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Library
{
    public static class RandomNumberGenerator
    {
        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();

        public static string RandomNumberGenerate(int min, int max)
        {
            lock (syncLock)  // synchronize
            {
                return random.Next(min, max).ToString();
            }
            
        }

    }
}
