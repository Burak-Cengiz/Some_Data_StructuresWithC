using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_LinkedList
{
    public abstract class LinkedListADT
    {
        public abstract void Push(int value);
        public abstract int Pop();
        public abstract bool IsEmpty();
        public abstract int Peek();
        
    }
    public class Node
    {
        public int Data;
        public Node Next;
    }
}
