using System;
using System.Diagnostics;

namespace MyLibrary.Queue.Array
{
    /// <summary>
    /// The circular queue has 2 pointers Front and Rear.
    /// Rear points to the lastly added element (last in line)
    /// Front points to the element that is waiting to be dequeued (front in line)
    /// example a queue of size = 5 with 4 elements already in it
    ///       1 2 3 4 -  
    ///       F     R
    /// a Enqueue(5) with add the element at the rear position
    ///       1 2 3 4 5 
    ///       F       R
    /// a Dequeue will remove the element at the front position
    ///       - 2 3 4 5
    ///         F     R
    /// a Enqueue(7) while Rear is at the end of the array will rotate Rear to the first position
    ///       7 2 3 4 5
    ///       R F
    /// another Enqueue(8) while the array is full will double the size and copy the elements
    /// note that the copy takes into account the rear and front positions to make space in between them
    ///       7 8 - - - - 2 3 4 5
    ///         R         F  



    ///       7 2 3 4 5
    ///           R F
    /// another Enqueue(8) while the array is full will double the size and copy the elements
    /// note that the copy takes into account the rear and front positions to make space in between them
     //         7 2 3 3 8 - - - 4 5   
    ///                 R       F     
    ///         
    /// 
    /// When the queue is empty, Rear points to the last position in the array
    /// Front does not point to any element, Front is set to int.MinValue
    ///       - - - - - 
    ///               R  
    /// Enqueue(3) with an empty queue will rotate Rear to index = 0 and set Front = Rear
    ///       3 - - - -   
    ///       R  
    ///       F
    /// Enqueue(8)
    ///       3 8 - - -
    ///         R  
    ///       F
    /// Dequeue()
    ///       3 8 - - -   
    ///         R  
    ///         F
    /// </summary>
    public class CircularQueueInt
    {
        private int length = 5;
        private readonly bool autoResize;
        private int[] queue;
        private int Front = int.MinValue;    // Minvalue => Queue is empty !
        private int Rear;

        
        /// <summary>
        /// Create a new queue with the specified (initial) length
        /// </summary>
        /// <param name="InitialLength">the initial length</param>
        /// <param name="AutoResize">if TRUE the  queue will automatically double in size when full</param>
        public CircularQueueInt(int InitialLength, bool AutoResize = true)
        {
            length = InitialLength;
            autoResize = AutoResize;
            queue = new int[length];
            Rear = length - 1;              //start at the last position
        }

        /// <summary>
        /// Add an element to the end of the queue
        /// If the queue is full (and AutoSize is set), the Queue is doubled in size
        /// </summary>
        /// <param name="value">The value to be added to the queue</param>
        public void Enqueue(int value)
        {
            if (IsFull)
            {
                if (!autoResize)
                    throw new Exception("Queue is full. No items can be added");

                length = length * 2;                    //Enlarge with size x 2
                var temp = new int[length];
                for(int f = 0; f < queue.Length; f++)
                {
                    if (f <= Rear)
                    {
                        temp[f] = queue[f];             //vooraan
                    }
                    else
                    {
                        temp[f + (temp.Length - queue.Length)] = queue[f];  //achteraan
                    }
                }
                if (Front != 0) 
                    Front += temp.Length - queue.Length;
                
                queue = temp;
            }

            if (++Rear == queue.Length)
                Rear = 0;
            queue[Rear] = value;
            if (Front == int.MinValue)        //First element in queue ? 
                Front = Rear;       //Set Front = Rear position

            PrintQueue();
        }

        /// <summary>
        /// Get the first element waiting in the queue
        /// </summary>
        /// <returns>the value of the first element</returns>
        public int Dequeue()
        {
            if (IsEmpty)
                throw new Exception("The queue is already empty");

            int result = queue[Front];
            queue[Front] = 0;                   //not required, but for easier debugging

            if (Front == Rear)
                Front = int.MinValue;         // => Queue = empty 
            else if (++Front == queue.Length)      //otherwise increment and check end of circle 
                Front = 0;
            PrintQueue();
            return result;
        }

        /// <summary>
        /// Check if the queue is empty
        /// </summary>
        public bool IsEmpty
        {
            get
            {
                return Front == int.MinValue;
            }
        }

        /// <summary>
        /// Check if the queue is Full
        /// </summary>
        public bool IsFull
        {
            get
            {
                return Rear + 1 == Front || Rear - (queue.Length - 1) == Front;
            }
        }

        /// <summary>
        /// Get a Clone (read-only copy) of the queue.
        /// </summary>
        public int[] Queue
        {
            get
            {
                return (int[])queue.Clone();    // We return a clone (=copy of the array in an new array) so that the queue cannot be changed by the caller
            }
        }

        private void PrintQueue()
        {
            Debug.WriteLine($"Array2: {string.Join(", ", queue)}");
        }

    }
}
