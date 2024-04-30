using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    
    public abstract class LinkedListADT
    {
        public Node Head;
        public int Count = 0;
        public abstract void InsertFirst(int value);
        public abstract void InsertLast(int value);
        public abstract string DisplayElements();
        public abstract void Reverse(ref Node Head);
        
        public abstract void RemoveFirst();

        public abstract void InsertBetwen(int value,int y);
        public abstract void YinelenenCıkar();


    }
    public class Node
    {
        public int Data;
        public Node Next;
    }

}
