using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SorteerAlgoritmen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        #region WPF logics
        Randomgenerator ranLijst = new Randomgenerator(6, 50, 0);

        private void BubbleSort_Click(object sender, RoutedEventArgs e)
        {
            BubbleSort bs = new BubbleSort();
            
            Clear();
           
            int[] unSortedList = ranLijst.Generate();
            PrintArray(unSortedList, true);

            int[] sortedList = bs.Sort(unSortedList);
            PrintArray(sortedList,false);
        }

        private void SelectioSort_btn_Click(object sender, RoutedEventArgs e)
        {
            SelectionSort ss = new SelectionSort();

            Clear();

            int[] unSortedList = ranLijst.Generate();
            PrintArray(unSortedList, true);

            int[] sortedList = ss.Sort(unSortedList);
            PrintArray(sortedList, false);
        }

        private void InsertionSort_Click(object sender, RoutedEventArgs e)
        {
            InsertionSort Is = new InsertionSort();

            Clear();

            int[] unSortedList = ranLijst.Generate();
            PrintArray(unSortedList, true);

            int[] sortedList = Is.Sort(unSortedList);
            PrintArray(sortedList, false);

        }

        private void QuickSort_Click(object sender, RoutedEventArgs e)
        {
            QuickSort qs = new QuickSort();

            Clear();

            int[] unSortedList = ranLijst.Generate();
            PrintArray(unSortedList, true);

            qs.Sort(unSortedList);
            PrintArray(unSortedList, false);
        }
        private void MergeSort_Click(object sender, RoutedEventArgs e)
        {
            MergeSort Is = new MergeSort();

            Clear();

            int[] unSortedList = ranLijst.Generate();
            PrintArray(unSortedList, true);

            int[] sortedList = Is.Sort(unSortedList);
            PrintArray(sortedList, false);

        }

        #endregion wpf






        #region CosoleWaardig
        public void Clear()
        {
            lbSorted.Items.Clear();
            lbUnsorted.Items.Clear();
        }

        public void PrintArray(int[] list, bool IsSorted)
        {
            if (IsSorted)
            {
                for (int i = 0; i < list.Length; i++)
                {
                    lbUnsorted.Items.Add(list[i]);
                }
            }
            else
            {
                for (int i = 0; i < list.Length; i++)
                {
                    lbSorted.Items.Add(list[i]);
                }
            }
        }




        #endregion end

       
    }
}
