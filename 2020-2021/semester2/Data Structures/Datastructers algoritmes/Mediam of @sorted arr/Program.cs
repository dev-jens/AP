using System;

namespace Mediam_of__sorted_arr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar1 = { 1, 12, 15, 26, 38 };
            int[] ar2 = { 2, 13, 17, 30, 45 };

            int n1 = ar1.Length;
            int n2 = ar2.Length;
            if (n1 == n2)
                Console.Write("Median is " +
                            getMedian(ar1, ar2, n1));
            else
                Console.Write("arrays are of unequal size");
        }
        // same size
        static int getMedian(int[] ar1,
                        int[] ar2,
                        int n)
        {
            int i = 0;
            int j = 0;
            int count;
            int m1 = -1, m2 = -1;

            // Since there are 2n elements,
            // median will be average of
            // elements at index n-1 and n in
            // the array obtained after
            // merging ar1 and ar2
            for (count = 0; count <= n; count++)
            {
                // Below is to handle case
                // where all elements of ar1[] 
                // are smaller than smallest
                // (or first) element of ar2[]
                if (i == n)
                {
                    m1 = m2;
                    m2 = ar2[0];
                    break;
                }

                /* Below is to handle case where all
                elements of ar2[] are smaller than
                smallest(or first) element of ar1[] */
                else if (j == n)
                {
                    m1 = m2;
                    m2 = ar1[0];
                    break;
                }
                /* equals sign because if two
                arrays have some common elements */
                if (ar1[i] <= ar2[j])
                {
                    // Store the prev median
                    m1 = m2;
                    m2 = ar1[i];
                    i++;
                }
                else
                {
                    // Store the prev median
                    m1 = m2;
                    m2 = ar2[j];
                    j++;
                }
            }

            return (m1 + m2) / 2;
        }

        // diffrent size
        static int getMedianDif(int[] ar1, int[] ar2,
                     int n, int m)
        {

            // Current index of input array ar1[]
            int i = 0;

            // Current index of input array ar2[]
            int j = 0;

            int count;
            int m1 = -1, m2 = -1;

            // Since there are (n+m) elements, 
            // There are following two cases 
            // if n+m is odd then the middle 
            //index is median i.e. (m+n)/2 
            if ((m + n) % 2 == 1)
            {
                for (count = 0;
                    count <= (n + m) / 2;
                    count++)
                {
                    if (i != n && j != m)
                    {
                        m1 = (ar1[i] > ar2[j]) ?
                              ar2[j++] : ar1[i++];
                    }
                    else if (i < n)
                    {
                        m1 = ar1[i++];
                    }

                    // for case when j<m,
                    else
                    {
                        m1 = ar2[j++];
                    }
                }
                return m1;
            }

            // median will be average of elements
            // at index ((m+n)/2 - 1) and (m+n)/2
            // in the array obtained after merging
            // ar1 and ar2
            else
            {
                for (count = 0;
                    count <= (n + m) / 2;
                    count++)
                {
                    m2 = m1;
                    if (i != n && j != m)
                    {
                        m1 = (ar1[i] > ar2[j]) ?
                              ar2[j++] : ar1[i++];
                    }
                    else if (i < n)
                    {
                        m1 = ar1[i++];
                    }

                    // for case when j<m,
                    else
                    {
                        m1 = ar2[j++];
                    }
                }
                return (m1 + m2) / 2;
            }








        }
    }
