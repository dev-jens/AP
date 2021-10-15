using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Circular_Queue
{
    class Cqueue
    {
        private int front;
        private int rear;
        private int[] cArray; 
        
        public Cqueue(int size)
        {
            front = rear = -1;
            cArray = new int[size];
        }

        public void EnQueue(int data)
        {
            if (IsFull())
            {
                int[] temp = new int[cArray.Length * 2];  //front =3
                int teller = 0;
                int j = front;
                Debug.WriteLine("front=  " + front);
                do
                {
                    temp[teller] = cArray[j];
                    teller++;
                    j = (j + 1) % cArray.Length;
                } while (j != front);
                front = 0;
                rear = cArray.Length - 1;

                cArray = temp;
            }
            else if (IsEmpty())
            {
                front++;
            }
            rear = (rear + 1) % cArray.Length;
            cArray[rear] = data;
        }

        public int DeQueue()
        {
            if (IsEmpty())
            {
                return -9999;
            }
            int tmpVal = cArray[front];
            if (front == rear)
            {
                front = rear = -1;
            }
            else
            {
                front = (front + 1) % cArray.Length;
            }
            return tmpVal;
        }

        public bool IsFull()
        {
            return (rear + 1) % cArray.Length == front;
        }

        public bool IsEmpty()
        {
            return front == -1 ;
        }
    }
}
