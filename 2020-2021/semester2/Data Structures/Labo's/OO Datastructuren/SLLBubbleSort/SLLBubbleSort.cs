using System;
using System.Collections.Generic;
using System.Text;
using OO_Datastructuren.SLL;

namespace OO_Datastructuren.SLLBubbleSort
{
    class SLLBubbleSort
    {
        //List list = new List();

        public void Sort(List list)
        {
            var currentOuter = list.First;
            var currentInner = list.First;
            var last = list.Last;

            while (currentOuter != null)
            {
                while (!ReferenceEquals(currentInner, last))
                {
                    if (currentInner.Value > currentInner.Next.Value)
                    {
                        //swap
                        var temp = currentInner.Value;
                        currentInner.Value = currentInner.Next.Value;
                        currentInner.Next.Value = temp;
                    }
                    //Are we at the end of the iteration ?
                    if (!ReferenceEquals(currentInner.Next, last))
                        currentInner = currentInner.Next;
                    else
                        last = currentInner;            //update the last for the next iteration to be 1 less
                }
                currentOuter = currentOuter.Next;
                currentInner = list.First;
            }
        }



    }
}
