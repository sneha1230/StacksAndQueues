using System.Collections;
using System.Collections.Generic;
using System.Text;
using System;

namespace Queues
{
    public class Queues<T>
    {
        List<T> contents = new List<T>();
        //constructor 
        public Queues()
        {

        }
        //gets the number of items in Queues
        public int Count
        {
            get
            {
                return contents.Count;
            }
        }
        //enqueue method means adding element to the queue
        public void Enqueue(T item)
        {
            contents.Add(item);
        }
        //Dequeue method means removing element from queue
        public T Dequeue()
        {
            if (contents.Count == 0)
            {
                throw new InvalidOperationException("Cant dequeue from the queue");
            }
            else
            {
                T item = contents[0];
                contents.RemoveAt(0);
                return item;
            }
        }
    }

}