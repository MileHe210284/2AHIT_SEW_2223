using System;

namespace _13_Test3
{
    class stack
    {
        
    }
    public sealed class LinkedStack<T>
    {
        private int _Count;
        private Node _Top;

       
        public int Count
        {
            get { return _Count; }
        }
        private sealed class Node
        {
            public T item;
            public Node next;
       
            public Node(T item, Node next)
            {
                this.item = item;
                this.next = next;
            }
        }
      public void Push(T item)
        {
            this._Top = new Node(item, this._Top);
            this._Count++;
        }
        public T Peek()
        {
           if(this._Top == null)
            {
                throw new Exception("message");
            }
            else
            {
                return this._Top.item;
            }
        }
        public T Pop()
        {
            if(this._Top != null)
            {
                T item = this._Top.item;
                this._Top = this._Top.next;
                this._Count--;
                return (item);
            }
            else
            {
                throw new Exception("message");
            }
      
        }
    }
}
