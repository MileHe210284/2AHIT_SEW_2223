using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230214_ADT_Übung1
{
    class ArrayStack<T>
    {
        private readonly long size;
        private T[] elements;
        private long pointer = 0;

        public ArrayStack(long size)
        {
            this.size = size;
            elements = new T[size];
        }
        public void push(T element)
        {
            if (pointer >= size)
            {
                throw new StackFullException("Stack ist voll");
            }
            else
            {
                elements[pointer] = element;
                pointer++;
            }
        }
        public void pop(T elements)
        {
            T topElement;
            if (pointer <= 0)
            {
                throw new StackEmptyException("stack ist leer");
            }
            else
            {
                pointer--;
            }

        }
        public void peek(T elements)
        {


        }
    }

    class StackFullException : Exception
    {
        public StackFullException()
        {

        }
        public StackFullException(string message) : base(message)
        {

        }
        public StackFullException(string message, Exception inner) : base(message, inner)
        {

        }
    }
    class StackEmptyException : Exception
    {
        public StackEmptyException()
        {

        }
        public StackEmptyException(string message) : base(message)
        {

        }
        public StackEmptyException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
