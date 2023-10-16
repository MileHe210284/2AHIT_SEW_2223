using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Test3
{
    class stack2
    {
    }
    public sealed class linkedStack<T>
    {
        private int _Count;
        private Node _Top;
       
        public int count
        {
            get { return _Count; }
        }
        private sealed class Node
        {
            public Node next;
            public T item;
            public Node(T item, Node next)
            {
                this.item = item;
                this.next = next;
            }
        }
        public void Push(T item)
        {
            this._Top = new Node(item, _Top);
            this._Count++;
        }

        public T peek()
        {
        if(this._Top== null)
            {
                throw new Exception("message");
            }
            else
            {
                return this._Top.item;
            }
        }
        public T pop()
        {
            if (this._Top == null)
            {
                throw new Exception("message");
            }
            else
            {
                return this._Top.item;
            }
       
        }
    }
}
