using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System;

namespace Stacks
{
    public class Stack<T>
    {
        List<T> contents = new List<T>();
        //constructor 
        public Stack()
        {

        }
        //gets the number of items in stack
        public int Count
        {
            get
            {
                return contents.Count;
            }
        }
        //push the items into the  stack
        public void Push(T item)
        {
            contents.Add(item);
        }
        //remove the items from the stack
        public T Pop()
        {
            if (contents.Count == 0)
            {
                throw new InvalidOperationException("Cant pop from the stack");
            }
            else
            {
                T item = contents[contents.Count - 1];
                contents.RemoveAt(contents.Count - 1);
                return item;
                //contents.Remove(item);
            }
        }
        //Peek method (peeks at the top item on the stack)
        public T Peek()
        {
            if (contents.Count == 0)
            {
                throw new InvalidOperationException("Cant peek from the stack");
            }
            else
            {
                T item = contents[contents.Count - 1];
                return item;
            }
        }
    }
}
    