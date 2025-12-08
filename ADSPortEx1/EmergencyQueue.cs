using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx1
{
    //Queue implementation for Assessed Exercise 1

    //Please use lecture and lab materials from Week 2A to aid with implementation.

    //Do not delete the current function definitions, just replace the exceptions with the required functionality...

    //Don't forget to properly commit and document your work. 
    // Commit fairly frequently with proper descriptions, i.e. commit after implementing the enqueue function...

    //Lastly, don't forget about implementing your UI in 'Form1.cs'.
    // See lab material from week 1 to aid with this.

    class EmergencyQueue
    {
        private int maxsize = 10;
        public EmergencyCall[] store;
        private int head = 0;
        private int tail = 0;
        private int numItems;


        // Functions for EX.1A
        public EmergencyQueue()
        {
            store = new EmergencyCall[maxsize];
        }

        public EmergencyQueue(int size)
        {
            maxsize = size;
            store = new EmergencyCall[maxsize];
        }

        public void Enqueue(EmergencyCall value)
        {
            if (numItems == maxsize)
            {
                Console.WriteLine("Queue is full!");
                return;
            }
            store[tail] = value;
            tail = (tail+ 1) % maxsize;
            numItems++;
        }

        public EmergencyCall Dequeue()
        {
            if (numItems == 0)
            {
                Console.WriteLine("Queue is empty!");
            }
            EmergencyCall item = store[head];
            head = (head + 1) % maxsize;
            numItems--;
            return item;
        }

        public EmergencyCall Peek()
        {
            return store[head];
        }

        public int Count()
        {
            int count = 0;
            for (int i = head; i <= tail; i++)
            {
                count++;
            }
            return count;
        }

        public bool IsEmpty()
        {
            return numItems == 0;
        }

        public bool IsFull()
        {
            return numItems == maxsize;
        }

        // Functions for EX.1B

        public EmergencyCall PeekHighestSeverity()
        {
         
                EmergencyCall item = store[head];
                for (int i = head + 1; i < tail; ++i)
                {
                    if (store[i].SeverityLevel > item.SeverityLevel)
                    {
                        item = store[i];
                    }
                }
            return item;

           
        }
        public void DequeueFirstKCalls(int k)
        {
            for (int i =0; i < k; ++i)
            {
                Dequeue();
            }
        }
        // Functions for EX.1C



        //Free space, use as necessary to address task requirements... 







    } // End of class
}
