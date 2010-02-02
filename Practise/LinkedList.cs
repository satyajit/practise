using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practise
{
    class ListNode
    {

        Object data;

        public Object Data
        {
            get { return data; }
            set { data = value; }
        }
        ListNode next;

        internal ListNode Next
        {
            get { return next; }
            set { next = value; }
        }

        public ListNode(ListNode next, Object data)
        {
            this.next = next;
            this.data = data;
        }
    }

    public class LinkedList 
    {
        private ListNode head;

        internal ListNode Head
        {
            get { return head; }
            set { head = value; }
        }
        private int count;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        //Creating a constructor that's takes data because creating null valued list is a problem
        public LinkedList(Object data)
        {
            this.head = new ListNode(null,data);
            this.count = 1;
        }

        public void AddToFirst(Object data)
        {
            ListNode temp = new ListNode(null, data);
            temp.Next = Head;
            Head = temp;
            count++;
        }
        public bool IsEmpty()
        {
            return count == 0;
        }
        public void RemoveFirst()
        {
            if (this.Count > 0)
            {
                Head = Head.Next;
                count--;
            }
            else
                throw new IndexOutOfRangeException();
        }

        
    }

 
}
