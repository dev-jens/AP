using System;
using System.Collections.Generic;
using System.Text;

namespace FinalSesh_Generics.SorteerAlgoritme
{
    class bubbleSort
    {
        public void Sort<T>(T[] lijst) where T : IComparable<T>
        {

            for (int i = 1; i <= lijst.Length - 1; i++)
            {
                bool hasswapped = false;

                for (int j = 0; j < lijst.Length - i; j++)
                {
                    if (lijst[j].CompareTo(lijst[j + 1]) > 0)
                    {
                        var temp = lijst[j];
                        lijst[j] = lijst[j + 1];
                        lijst[j + 1] = temp;
                        hasswapped = true;
                    }
                }
                if (!hasswapped)
                {
                    return;
                }
            }
        }

        public void Sort<T>(T[] lijst , Comparer<T> comparer) where T : IComparable<T>
        {

            for (int i = 1; i <= lijst.Length - 1; i++)
            {
                bool hasswapped = false;

                for (int j = 0; j < lijst.Length - i; j++)
                {
                    if (comparer.Compare(lijst[j], lijst[j + 1]) > 0)
                    {
                        var temp = lijst[j];
                        lijst[j] = lijst[j + 1];
                        lijst[j + 1] = temp;
                        hasswapped = true;
                    }
                }
                if (!hasswapped)
                {
                    return;
                }

            }
        }

        public void Sort<T>(SLL_Generic.List<T> list) where T : IComparable<T>              //SLL Lijst
        {
            var currentOuter = list.First;
            var currentInner = list.First;
            var last = list.Last;

            while (currentOuter != null)
            {
                while (!ReferenceEquals(currentInner, last))
                {
                    if (currentInner.Value.CompareTo(currentInner.Next.Value) > 0)
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


        public void SortRecursive<T>(T[] list) where T : IComparable<T>             // lijst met lengte n
        {
            SortRecursive(list, list.Length - 1);
        }

        private void SortRecursive<T>(T[] list, int endIndex) where T : IComparable<T>
        {
            var hasSwapped = false;               //swap done indicator

            if (endIndex == 0)              // base case (nog maar 1 getal te sorteren)
                return;

            for (int g = 0; g < endIndex; g++)   // overloop van links naar rechts tot aan de eindIndex
            {
                if (list[g].CompareTo(list[g + 1]) > 0)    // compare
                {
                    var temp = list[g];       // swap
                    list[g] = list[g + 1];
                    list[g + 1] = temp;
                    hasSwapped = true;        //noteer dat we minstens 1 swap hebben uitgevoerd
                }
            }
            //geen enkele swap binnen 1 iteratie => lijst is gesorteerd, dus ook niet verder doen.
            if (!hasSwapped)
            {
                return;
            }
            SortRecursive(list, endIndex - 1);
        }

    }
}

