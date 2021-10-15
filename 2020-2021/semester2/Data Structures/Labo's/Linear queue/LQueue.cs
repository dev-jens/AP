using System;
using System.Collections.Generic;
using System.Text;

namespace Linear_queue
{
    class LQueue
    {
        int[] QueueArr = new int[5];
        int rear = -1;
        int front = 0;


        public void EnQueue(int getal)
        {
            if (rear == QueueArr.Length - 1)
            {
                int[] temp = new int[QueueArr.Length*2];
                for (int i = 0; i < rear; i++)
                {
                     temp[i] = QueueArr[i];
                }
                QueueArr = temp;
            }
            rear++;
            QueueArr[rear] = getal;

        }

        public int DeQueue()
        {
            if (rear == -1)
            {
                return -999999;
            }
            int eersteGet = QueueArr[front];
            for (int i = 0; i < rear; i++)
            {
                QueueArr[i] = QueueArr[i + 1];
            }
            rear--;
            return eersteGet;
        }

    }
}
