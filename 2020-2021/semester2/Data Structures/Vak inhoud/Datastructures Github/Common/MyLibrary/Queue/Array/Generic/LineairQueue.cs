using System;
using System.Diagnostics;

namespace MyLibrary.Queue.Array.Generic
{
    public class LineairQueue<T>
    {
        #region private parts
        private readonly int initialLength;
        private bool canResize;
        private T[] queue;
        private int End = -1;
        #endregion

        #region constructor
        public LineairQueue(int initialLength = 5, bool canResize = true)
        {
            this.initialLength = initialLength;
            this.canResize = canResize;
            queue = new T[initialLength];
        }
        #endregion

        #region public members
        public void Enqueue(T value)
        {
            if (IsFull)  // end of the queue reached ?
            {
                if (canResize)          // can the queue be resized ?
                {
                    var newQueue = new T[queue.Length * 2];
                    System.Array.Copy(queue, newQueue, queue.Length);
                    queue = newQueue;
                }
                else
                    throw new Exception("Queue is full. It is not possible to added items");
            }

            if (End < queue.Length - 1)
                queue[++End] = value;

            PrintQueue();
        }

        public T Dequeue()
        {
            if (!IsEmpty)
            {
                var result = queue[0];
                for (int f = 0; f < End; f++)
                    queue[f] = queue[f + 1];
                queue[End] = default(T);                 //not required, but for easier debugging

                End--;
                PrintQueue();
                return result;
            }
            return default(T);
        }

        /// <summary>
        /// Remove everything from the queue and reset the size to the initial size
        /// </summary>
        public void Clear()
        {
            queue = new T[initialLength];
            End = -1;
        }

        public bool IsEmpty
        {
            get
            {
                return End == -1;
            }
        }

        public bool IsFull
        {
            get
            {
                return End == queue.Length - 1;
            }
        }

        public bool CanResize
        {
            get
            {
                return canResize;
            }
            set
            {
                canResize = value;
            }
        }
        #endregion

        #region private members
        private void PrintQueue()
        {
            Debug.WriteLine($"Array: {string.Join(", ", queue)}");
        }
        #endregion
    }
}
