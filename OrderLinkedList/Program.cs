using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> l = new LinkedList<int>();

            Insert(l, 7);
            Insert(l, 2);
            Insert(l, 3);
            Insert(l, 8);

            foreach (var item in l)
            {
                Console.WriteLine("{0}", item);
            }
            Console.ReadKey();
        }

        static void Insert(LinkedList<int> l, int item)
        {
            if (l.First == null)
                l.AddFirst(item);
            else if (item <= l.First.Value)
                l.AddFirst(item);
            else if (item >= l.Last.Value)
                l.AddLast(item);
            else
            {
                LinkedListNode<int> node = l.First;
                while (item >= node.Value)
                    node = node.Next;
                l.AddBefore(node, item);

            }
        }
    }
}
