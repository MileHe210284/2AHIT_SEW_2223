using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230316_ADT_5
{
    class Que<T>
    {
        private long size = 50;
        public long pointer = 0;

        sealed class Node
        {
            public T Item;
            public Node Next;
            public Node(T item) 
            { 
                this.Item = item; 
            }
        }

        private Node _First;
        private Node _Last;

        public Que()
        {


        }

        public void Enqueue(T item)
        {
            
            if (this._First != null)
            {
                this._Last.Next = new Node(item);
                this._Last = this._Last.Next; // make the new node to the last node
                this.pointer++;
            }
            else if(this._First == null)
            { // make a new node to the first and last node
                this._First = new Node(item);
                this._Last = this._First;
                this.pointer++;
            }
            else if(pointer == size)
            {
                throw new StackFullException("stack is full already; nothing to add here;");
            }
        }
        public void Dequeue()
        {
            if (pointer == 0)
            {
                throw new StackEmptyException("stack is empty; nothing to take out here");
            }
            else 
            {

                this._First = this._First.Next;
               
                this.pointer--;
            }
           
        }
        public T Peek()
        {
            if (pointer <= 0)
            {
                throw new StackEmptyException("stack is empty; nothing to see here");
            }
            else
            {
                return this._Last.Item;
            }

        }
        public void Clear()
        {
            if (this._Last !=null && this._First !=null) {
                this._Last = null; //looses all references to it so it gets thrown away
                this._First = null; //looses all references to it so it gets thrown away
                pointer = 0;
            }
            else
            {
                throw new StackEmptyException("stack already empty; can't clear");
            }
                
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



