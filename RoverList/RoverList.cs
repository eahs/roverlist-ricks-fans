using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverList
{
    public class RoverList<T> : RoverListBase<T>
    {
        // Add any variables you need here
        private int count;

        public RoverList()
        {
            count = 0;
            head = null;
            current = null;
        }

        public override int Count => count;

        public override void Add(T data)
        {
            Add(Count, data);
        }

        public override void Add(int Position, T data)
        {
            Node n = new Node(data);
            current = head;
            
            if (Position == 0)
            {
                n.Next = head;
                head = n;
            }
            
            else 
            {
                current = NodeAt(Position - 1);
                n.Next = current.Next?.Next;
                current.Next = n;
            }
            count += 1;
        }

        public override void Clear()
        {
            head = null;
            count = 0;
        }

        public override T ElementAt(int Position)
        {
            var node = NodeAt(Position);
            if (node is null)
            {
                throw new IndexOutOfRangeException();
            }
            
            return node.Data;
        }

        public override void ListNodes()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(ElementAt(i));
            }
        }

        public override bool RemoveAt(int Position)
        {
            if (Position == 0)
            {
                head = head.Next;
            }
            else
            {
                current = NodeAt(Position - 1);
                current.Next = current.Next.Next;
            }

            count -= 1;
            return true;
        }

        private Node NodeAt(int Position)
        {
            current = head;

            for (int i = 0; i < Position; i++)
            {
                current = current.Next;
            }

            return current;
        }
    }
}
