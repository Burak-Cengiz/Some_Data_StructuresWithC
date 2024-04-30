using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class Ikuyruk : kuyruk
    {
        public object[] kuyruk;
        public int front = -1;
        public int rear = -1;

        public int size = 0;

        private int count;
        public Ikuyruk(int count)
        {
            this.count = count;
            this.kuyruk = new object[count];
        }


        public override string displayElements()
        {
            string elements = "";

            if (this.isEmpty())
            {
                throw new Exception("boş");
            }
            else
            {
                int temp = front;
                while (temp != (rear+1))
                {
                    elements += kuyruk[temp];
                    elements += "<<";
                    temp++;
                }
            }
            return elements;
        }



        public override bool isEmpty()
        {
            return rear == -1 ? true : false;
        }

        public override object peek()
        {
            if (this.isEmpty())
            {
                throw new Exception("boş");
            }

            object temp = kuyruk[front];
            return temp;

        }

        public override object pop()
        {
            if (this.isEmpty())
            {
                throw new Exception("boş");
            }
            object temp = kuyruk[front];
            kuyruk[front] = null;
            size--;
            front++;
            return temp;

        }

        public override void push(object value)
        {

            if ((count == this.size) || (rear == count - 1))
            {
                throw new Exception("dolu ");
            }

            if (front == -1)
            {
                front = 0;
            }

            kuyruk[++rear] = value;

            this.size++;
        }
    }
}
