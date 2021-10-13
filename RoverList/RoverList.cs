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
            Node n = new Node(data);
            
            if (head == null)
            {
                head = n;
                current = n;
            }
            else
            {
                current.Next = n;
                current = n;
            }

            count += 1;
        }

        public override void Add(int Position, T data)
        {
            Node n = new Node(data);
            if (Position == 0)
            {
                Node hold = head;
                head = n;
                head.Next = hold;
            }
        }

        public override void Clear()
        {
            head = null;
            count = 0;
        }

        public override T ElementAt(int Position)
        {
            Node n;
            current = head;
            
            for (int i = 0; i < Position; i++)
            {
                n = current.Next;
            }

            return n.data;
        }

        public override void ListNodes()
        {
            throw new NotImplementedException();
        }

        public override bool RemoveAt(int Position)
        {
            Node n;
            current = head;
            
            for (int i = 0; i < Position - 1; i++)
            {
                n = current.Next;
            }

            n.Next = current.Next.Next;



        }
    }
}
