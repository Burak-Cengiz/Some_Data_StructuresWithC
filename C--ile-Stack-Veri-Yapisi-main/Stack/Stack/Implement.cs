using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Implement : Istack
    {
        private object[] items;
        private int top = -1;


        public Implement(int itemCount)
        {
            this.items = new object[itemCount];
        }

        public int Top 
        { 
            get
            {
                return top;
            }
            set
            {
                top = value;
            }
        }

        public bool IsEmpty()
        {
            return Top == -1 ? true : false;
        }

        public object Peek()
        {
            return items[Top];
        }

        public object Pop()
        {
            if (this.IsEmpty())
            {
                throw new Exception("Hata: Stack boş");
            }
            Object temp = items[Top--];
            return temp;
        }

        public void Push(object item)
        {
            if(items.Length == Top + 1)
            {
                throw new Exception("Hata : stack doldu");
            }

            items[++Top] = item;
        }
    }
}
