using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class ILinkedList : LinkedListADT
    {

        
        
        public override string DisplayElements()
        {

            string temp = "";

            Node item = Head;
            
            while (item.Next != null)
            {
                temp += item.Data.ToString();
                temp += " >> ";
                item = item.Next;
            }
            temp += item.Data.ToString();
            return temp;
        }

        public override void InsertBetwen(int value, int y)
        {
            Node item = new Node()
            {
                Data = value,
            };

            int tmp = 0;

             
            Node tmpHead = Head;
            
            while (tmpHead.Next != null)
            {

                tmp++;

                if (tmp == y)                                                   
                    break;

                tmpHead = tmpHead.Next;
            }
            Node tmpitem = tmpHead.Next;

            tmpHead.Next = item;
            item.Next = tmpitem;

            

            Count++;
        }

        public override void InsertFirst(int value)
        {
            Node item = new Node()
            {
                Data = value,
            };

            if(Head==null)
            {
                Head = item;
                
            }
            else
            {
                item.Next = Head;
                Head = item;
            }

            Count++;
        }

        public override void InsertLast(int value)
        {
            Node item = new Node()
            {
                Data = value,
            };

            if(Head==null)
            {
                InsertFirst(value);
            }
            else
            {
                Node tmpHead = Head;

                while(tmpHead.Next!=null)
                {
                    tmpHead = tmpHead.Next;
                }

                tmpHead.Next = item;
                item.Next = null;

            }
            Count++;
            
        }

        public override void RemoveFirst()
        {
            Node item = Head.Next;

            Head = null;
            Head = item;
            Count--;
        }

        public override void Reverse(ref Node Head)
        {

            Node currNode = Head;
            Node nextNode = null;
            Node previNode = null;

            while (currNode.Next != null)
            {
                nextNode = currNode.Next;
                currNode.Next = previNode;
                previNode = currNode;
                currNode = nextNode;
            }
            currNode.Next = previNode;
            Head = currNode;
        }

        public override void YinelenenCıkar()
        {
            Node item = Head;
            Node item2 = Head;
            Node tmp = null;

            while(item.Next != null)
            {
                while (item2.Next != null)
                {
                    if (item.Data == item2.Next.Data)
                    {
                        tmp = item2.Next.Next;
                        item2.Next = null;
                        item2.Next = tmp;
                        Count--;
                    }
                    else
                        item2 = item2.Next;
                }
                        
                item = item.Next;
                item2 = item;
            }
            
        }
    }
}
