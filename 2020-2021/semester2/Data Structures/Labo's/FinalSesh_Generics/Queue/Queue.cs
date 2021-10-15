using System;
using System.Collections.Generic;
using System.Text;

namespace FinalSesh_Generics.Queue
{
    class Queue<T>
    {
        private int front;
        private int rear;
        private T[] cArray;

        public Queue(int size)
        {
            front = rear = -1;
            cArray = new T[size];
        }

        public void EnQueue(T data)
        {
            if (IsFull())
            {
                var temp = new T[cArray.Length * 2];  //front =3
                int teller = 0;
                int j = front;
                
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

        public T DeQueue()
        {
            if (IsEmpty())
                throw new Exception("queue is empty");
            
            var tmpVal = cArray[front];
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
            return front == -1;
        }
    }
}
