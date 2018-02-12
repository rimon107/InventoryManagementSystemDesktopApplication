using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Library
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            //throw new NotImplementedException("Create Test");
            if (candidate < 2)
            {
                return false;
            }
            return true;
        }
    }
}
