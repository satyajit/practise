using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Practise;

namespace Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            Practise.PIELinkedList p = new Practise.PIELinkedList();
            LinkedList ll = new LinkedList(5);

            p.display(ll);
            ll.AddToFirst(3);
            p.display(ll);
            ll.RemoveFirst();
            ll.RemoveFirst();
            p.display(ll);
            ll.RemoveFirst();
        }
    }
}
