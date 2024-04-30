using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public abstract class kuyruk
    {
        public abstract bool isEmpty();
        public abstract void push(object value);
        public abstract object pop();
        public abstract string displayElements();
        public abstract object peek();
    }
}
