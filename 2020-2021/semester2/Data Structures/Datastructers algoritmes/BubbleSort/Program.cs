using System;

namespace BubbleSort
{
    class Program
    {
        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        } /// print array

        static void Main(string[] args)
        {
            //bubblesort
            int[] list = { 7, 2, 7, 8, 1, 75, 425, 2, 525, 2, 52, 1 };
            BubbleSort(list);
            PrintArray(list);

            //inteligent
            int[] list2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            BubbleSortIntelegent(list2);
            PrintArray(list2);

            //recursief + inteligent
            int[] list3 = { 3, 4, 5, 67, 54, 6, 5243, 42 };
            BubbleSortRecursief(list3,list3.Length-1);
            PrintArray(list3);

        }

        public static void BubbleSort(int[] list)              
        {
            // iteraties
            for (int i = 1; i <= list.Length - 1; i++)      
            {
                // overloop van links naar rechts
                for (int j = 0; j < list.Length - i; j++)   
                {
                    // compare
                    if (list[j] > list[j + 1])   
                    {
                        // swap
                        int temp = list[j];       
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
        }



        public static void BubbleSortIntelegent(int[] list)              
        {
            // iteraties
            for (int i = 1; i <= list.Length - 1; i++)      
            {
                //swap done indicator
                bool hasSwapped = false;
                // overloop van links naar rechts
                for (int j = 0; j < list.Length - i; j++)   
                {
                    // compare
                    if (list[j] > list[j + 1])   
                    {
                        // swap
                        int temp = list[j];     
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                        //noteer dat we minstens 1 swap hebben uitgevoerd
                        hasSwapped = true;       
                    }
                }
                //geen enkele swap binnen 1 iteratie => lijst is gesorteerd !!!
                if (!hasSwapped)
                {
                    // kqn ook met een debug
                    Console.WriteLine();
                    Console.WriteLine($"Bubble sorted detected no swaps done after {i} out of {list.Length - 1} iterations");
                    return;
                }
            }
        }

        public static void BubbleSortRecursief(int[] list, int endIndex)
        {
            var hasSwapped = false;               //swap done indicator

            if (endIndex == 0)              // base case (nog maar 1 getal te sorteren)
                return;

            for (int g = 0; g < endIndex; g++)   // overloop van links naar rechts tot aan de eindIndex
            {
                if (list[g] > list[g + 1])    // compare
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
                Console.WriteLine();
                Console.WriteLine($"Bubble sorted detected no swaps done after {list.Length - endIndex} out of {list.Length - 1} iterations");
                return;
            }
            BubbleSortRecursief(list, endIndex - 1);
        }











    }
}
