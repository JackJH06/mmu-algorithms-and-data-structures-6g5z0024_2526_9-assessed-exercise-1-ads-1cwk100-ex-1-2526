using System;
using System.Collections.Generic;
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
        private int [] store = new int[maxsize];
        private int head = 0;
        private int tail = 0;
        private int numItems;


        // Functions for EX.1A
        public EmergencyQueue()
        {
            store = new EmergencyQueue [maxsize];
        }

        public EmergencyQueue(int size)
        {
            throw new NotImplementedException();
        }

        public void Enqueue(EmergencyCall value)
        {
            store[tail] = value;
            tail++;
            numItems++;

        }

        public EmergencyCall Dequeue()
        {
            int headItem;
            headItem = store[head];
            head++;
            numItems--;
            return headItem;
        }

        public EmergencyCall Peek()
        {
            return EmergencyCall;
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
            throw new NotImplementedException();
        }

        public bool IsFull()
        {
            throw new NotImplementedException();
        }

        // Functions for EX.1B

        public EmergencyCall PeekHighestSeverity()
        {
            throw new NotImplementedException();
        }

        public void DequeueFirstKCalls(int k)
        {
            throw new NotImplementedException();
        }

        // Functions for EX.1C



        //Free space, use as necessary to address task requirements... 







    } // End of class
}
