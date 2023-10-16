using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230307_Enqueue
{
   class Q<T>
    {
        sealed class Node
        {
            public T item;
            public Node Next;
            public Node(T item) { this.item = item; }
        }
        private Node _First;
        private Node _Last;

        private long size;
        private long pointer = 0;
        public Q()
        {


        }

        public void Enque(T item)
        {
            if (this._First != null)
            {
                this._Last.Next = new Node(item);
                this._Last = this._Last.Next; // make the new node to the last node
            }
            else 
            { // make a new node to the first and last node
                this._First = new Node(item);
                this._Last = this._First;
            }
            this.pointer++; // Increase counter of LinkedQueue

        }
        public void Deque(T item)
        {
            if (pointer > 0)
            {

                this.pointer--;
            }

        }
        public T Peek()
        {

            if (pointer >= 0)
            {
                return this._First.item;
            }
            else
            {
                throw new StackEmptyException("Der Stack ist leer");
            }
        }
        public void Clear()
        {
            this._Last = null;
            this._First = null;
        }

    }
}
class StackFullException : Exception
{
    public StackFullException()
    { }
    public StackFullException(string message) : base(message)
    { }
    public StackFullException(string message, Exception inner) : base(message, inner)
    { }
}
class StackEmptyException : Exception
{
    public StackEmptyException()
    { }
    public StackEmptyException(string message) : base(message)
    { }
    public StackEmptyException(string message, Exception inner) : base(message, inner)
    { }
}
