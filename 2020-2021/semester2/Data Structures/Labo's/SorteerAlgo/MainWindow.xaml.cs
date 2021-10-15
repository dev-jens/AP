using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using SorteerAlgo.Algoritme_klassen;

namespace SorteerAlgo
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
        // public vars

        int[] list = null;
        //string[] strList = new string[] { "jens", "fred", "amber", "jordi", "sam" };
        
  
        private void btGenerate_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            RamdomGenerator rg = new RamdomGenerator();
            list = rg.Generate(ReadInput(tbAmount), ReadInput(tbMin), ReadInput(tbMax));
            Print(lbUnsorted,list);
        }

        private void btClear_Click(object sender, RoutedEventArgs e)
        {
            Clear();
        }

        private void btSort_Click(object sender, RoutedEventArgs e)
        {
            Button Btn = (Button)sender;
            lbSorted.Items.Clear();
            Stopwatch sw = new Stopwatch();    //Stopwatch voor tijdsmeting
            sw.Start();

            switch (Btn.Tag)
            {
                case "BS":   //Bubble sort
                    {
                        BubbleSort bs = new BubbleSort();
                        bs.Sort(list);
                        Print(lbSorted, list);
                    }
                    break;
                case "SS":   //Selection Sort
                    {
                        SelectionSort ss = new SelectionSort();
                        ss.Sort<int>(list);
                        Print(lbSorted, list);
                    }
                    break;
                case "IS":   //Insertion Sort
                    {
                        InsertionSort IS = new InsertionSort();
                        IS.Sort(list);
                        Print(lbSorted, list);
                    }
                    break;
                case "QS":   //Quicksort
                    {
                        QuickSort qs = new QuickSort();
                        qs.Sort(list);
                        Print(lbSorted, list);
                    }
                    break;
                case "MS":    //Merge sort
                    {
                        MergeSort ms = new MergeSort();
                        ms.Sort(list);
                        Print(lbSorted, list);
                    }
                    break;
                default:
                    MessageBox.Show("dit algoritme is nog niet in werking !");
                    break;
            }
            sw.Stop();
            lbTime.Text = $"Tijd: {sw.Elapsed.ToString(@"mm\:ss\.fff")}";

        }

        private void Print<T>(ListBox box, T[] arr) where T: IComparable<T> 
        {
            for (int i = 0; i < arr.Length; i++)
            {
                box.Items.Add(arr[i]);
            }
        }
        private void Clear()
        {
            lbSorted.Items.Clear();
            lbUnsorted.Items.Clear();
        }
        private int ReadInput(TextBox box)
        {
            int temp = 0;
            if (int.TryParse(box.Text, out temp))
                return temp;

            throw new Exception("ingevoerde waarde is ongeldig");
        }

        private void menuCars_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
