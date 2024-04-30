using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class PriortyQueue : kuyruk
    {
        private object[] Queue;
        private int front = -1;
        
        private int size = 0;
        private int count = 0;
        public PriortyQueue(int size)
        {
            this.size = size;
            Queue = new object[size];
        }
        public override string displayElements()
        {
            throw new NotImplementedException();
        }

        public override bool isEmpty()
        {
            return count == 0;
        }

        public override object peek()
        {
            throw new NotImplementedException();
        }

        public override object pop()
        {
            if (this.isEmpty())
            {
                throw new Exception("Queue is empty...");
            }
            object temp = Queue[front];
            Queue[front] = null;
            front--;
            count--;
            return temp;
        }

        public override void push(object value)
        {
            if (count == size)
            {
                throw new Exception("Queue is full");
            }
            if (isEmpty())
            {
                front++;
                Queue[front] = value;
                count++;
            }
            else
            {
                int i;
                //Not3: Son elemandan başlayarak geriye doğru kuyruk kontrol ediliyor
                //Eklenecek elemanın pozisyonu belirleniyor
                //Var olan elemanlar kaydırılıyor
                for (i = count - 1; i >= 0; i--)
                {
                    if ((int)value > (int)Queue[i])
                        Queue[i + 1] = Queue[i];
                    else
                        break;
                }
                Queue[i + 1] = value;
                front++;
                count++;
            }
        }
    }
}
