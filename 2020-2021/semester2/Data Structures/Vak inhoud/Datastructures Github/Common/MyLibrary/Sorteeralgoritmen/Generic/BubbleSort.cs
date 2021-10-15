
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using SLLG = MyLibrary.SLL.Generic;

namespace MyLibrary.Sorteeralgoritmen.Generic
{
    public class BubbleSort
    {
        /// <summary>
        /// Sort the list using the default comparer.
        /// </summary>
        /// <typeparam name="T">The type of elements in the list, the type must implement IComparable</typeparam>
        /// <param name="list">the list to be sorted</param>
        public void Sort<T>(T[] list) where T: IComparable<T>  // lijst met lengte n
        {
            var n = list.Length;
            for (int f = 1; f <= n - 1; f++)      // iteraties
            {
                for (int g = 0; g < n - f; g++)   // overloop van links naar rechts
                {
                    if (list[g].CompareTo(list[g + 1]) > 0)    // compare 
                    {
                        var temp = list[g];       // swap
                        list[g] = list[g + 1];
                        list[g + 1] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// Sort the list, using the specified comparer
        /// </summary>
        /// <typeparam name="T">type of the list elements</typeparam>
        /// <param name="list">the list to be sorted</param>
        /// <param name="comparer">the comparer which will determine the order</param>
        public void Sort<T>(T[] list, IComparer<T> comparer)  // lijst met lengte n
        {
            var n = list.Length;
            for (int f = 1; f <= n - 1; f++)      // iteraties
            {
                for (int g = 0; g < n - f; g++)   // overloop van links naar rechts
                {
                    if (comparer.Compare(list[g], list[g + 1]) > 0)    // compare 
                    {
                        var temp = list[g];       // swap
                        list[g] = list[g + 1];
                        list[g + 1] = temp;
                    }
                }
            }
        }
        public void Sort<T> (SLLG.List<T> list) where T: IComparable<T>              //SLL Lijst
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

        /// <summary>
        /// De iets intelligentere versie die reeds stopt wanneer er geen swap meer nodig was binnen de laatste iteratie
        /// </summary>
        /// <param name="list"></param>
        public void SortIntelligent<T>(T [] list) where T:IComparable<T>              // lijst met lengte n
        {
            var n = list.Length;
            for (int f = 1; f <= n - 1; f++)      // iteraties
            {
                var hasSwapped = false;             //swap done indicator
                for (int g = 0; g < n - f; g++)   // overloop van links naar rechts
                {
                    if (list[g].CompareTo(list[g + 1]) > 0)    // compare
                    {
                        var temp = list[g];       // swap
                        list[g] = list[g + 1];
                        list[g + 1] = temp;
                        hasSwapped = true;        //noteer dat we minstens 1 swap hebben uitgevoerd
                    }
                }
                //geen enkele swap binnen 1 iteratie => lijst is gesorteerd !!!
                if (!hasSwapped)
                {
                    Debug.WriteLine($"Bubble sorted detected no swaps done after {f} out of {n - 1} iterations");
                    return;
                }
            }
        }

        /// <summary>
        /// De recursieve versie
        /// </summary>
        /// <param name="list"></param>
        public void SortRecursive<T>(T[] list) where T:IComparable<T>             // lijst met lengte n
        {
            SortRecursive(list, list.Length - 1);
        }

        //Waarom recursief ?
        //We kunnen immers de verschillende iteraties van de bubblesort aanzien als een kleinere versie van hetzelfde
        //Elke iteratie doet net hetzelfde, alleen 1 item minder bekijken.
        //Dit geven we aan met de endIndex. Daar stopt een iteratie
        //Voor de 1e iteratie is dat het einde van de array en voor de volgende telkens 1 item minder.
        //De base case is als we enkel nog index = 0 moeten sorteren. Dan is de lijst immers sowieso volledig gesorteerd.

        /// <summary>
        /// Doe de bubble sort recursief. Deze methode doet 1 iteratie en roept vervolgens zichzelf aan voor de volgende iteratie.
        /// We gebruiken hier tevens de intelligentere versie met de swapCheck controle.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="endIndex"></param>
        private void SortRecursive<T>(T [] list, int endIndex) where T:IComparable<T>
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
                Debug.WriteLine($"Bubble sorted detected no swaps done after {list.Length - endIndex} out of {list.Length - 1} iterations");
                return;
            }
            SortRecursive(list, endIndex - 1);
        }

    }
}
