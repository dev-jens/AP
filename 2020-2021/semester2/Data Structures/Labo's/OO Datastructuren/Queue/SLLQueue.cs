using OO_Datastructuren.SLL;
using System;
using System.Collections.Generic;
using System.Text;

namespace OO_Datastructuren.Queue
{
    class SLLQueue
    {

        List QueueSLL = new List();

        public void EnQueue(int getal)
        {
            QueueSLL.AddLast(getal);

        }

        public int DeQueue()
        {
            if (!QueueSLL.IsEmpty)
                return QueueSLL.RemoveNode(QueueSLL.First);
            else
                throw new Exception("Queue is empty");
        } 
    }
}
