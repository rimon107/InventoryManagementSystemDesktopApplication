using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Library
{
    public class MessageEventArgs<T> : EventArgs
    {
        public bool check { get; set; }

        public T Entity { get; set; }

        public MessageEventArgs(T Entity)
        {
            this.Entity = Entity;
        }

    }
}
