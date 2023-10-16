using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Test3
{
    class q
    {

    }

    public sealed class LinkedQueue<T>
    {
        private Node _First;
        private Node _Last;
        private int _Count = 0;

        sealed class Node 
        {
            public T item;
            public Node Next;
            
            public Node(T item)
            {
                this.item = item;
            }
        }
        public int Count
        {
            get { return _Count; }
        }

        public void Enqueue(T item)
        {
            if(this._First== null)
            {
                this._First = new Node(item);
                this._Last = this._First;
            }
            else
            {
                this._Last.Next = new Node(item);
                this._Last = this._Last.Next;
            }

        }

        public T Dequeue()
        {
            if(this._First== null)
            {
                throw new Exception("message");
            }
            T item = this._First.item;
            this._First = this._First.Next;
            this._Count--;
            return item;
            if(this._First== null)
            {
                this._Last = null;
            }
        }

        public T Peek()
        {
           if(this._First== null)
            {
                throw new Exception("message");
            }
            else
            {
                return this._First.item;
            }
        }
    }

}
