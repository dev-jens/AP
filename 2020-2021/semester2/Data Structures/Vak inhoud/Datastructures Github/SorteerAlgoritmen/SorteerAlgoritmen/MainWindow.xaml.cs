using MyLibrary;
using MyLibrary.SLL;
using MyLibrary.Sorteeralgoritmen;
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

        /// <summary>
        /// Genereer een aantal willekeurige getallen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btGenerate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                UpdateUI(true);
                var rg = new RandomGenerator(ReadInput(tbAmount), ReadInput(tbMin), ReadInput(tbMax), cbUnique.IsChecked.Value);
                var list = rg.GenerateNumbers();
                SetList(lbUnsorted, list);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                UpdateUI();
            }
        }



        /// <summary>
        /// Beide listboxen leegmaken
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btClear_Click(object sender, RoutedEventArgs e)
        {
            lbUnsorted.Items.Clear();
            lbSorted.Items.Clear();
        }

        /// <summary>
        /// Sorteer de lijst met behulp van een bepaald algoritme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSort_Click(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;        //Van welke knop komt de click ?
            lbSorted.Items.Clear();             //Gesorteerde lijst wissen
            UpdateUI(true);
            int[] list = null;                  //De te sorteren lijst

            Stopwatch sw = new Stopwatch();    //Stopwatch voor tijdsmeting
            sw.Start();

            switch (b.Tag)
            {
                case "BS":   //Bubble sort
                    {
                        var bs = new BubbleSort();
                        var list2 = GetSLLList(lbUnsorted);
                        bs.SortSLL(list2);
                        SetList(lbSorted, list2);
                    }
                    break;
                case "SS":   //Selection Sort
                    {
                        var ss = new SelectionSort();
                        if (!(lbUnsorted.Items[0] is String))
                        {
                            list = GetList(lbUnsorted);
                            ss.Sort(list);
                            SetList(lbSorted, list);
                        }
                        else
                        {
                            var stringList = GetStringList(lbUnsorted);
                            ss.Sort(stringList);
                            SetList(lbSorted, stringList);
                        }
                    }
                    break;
                case "IS":   //Insertion Sort
                    {
                        var ins = new InsertionSort();
                        if (!(lbUnsorted.Items[0] is Auto))   //Speciaal geval, sorteren van Auto's
                        {
                            list = GetList(lbUnsorted);
                            ins.Sort(list);
                            SetList(lbSorted, list);
                        }
                        else
                        {
                            var carList = GetAutoList(lbUnsorted);
                            ins.Sort(carList);
                            SetList(lbSorted, carList);
                        }
                    }
                    break;
                case "QS":   //Quicksort
                    {
                        var qs = new QuickSort();
                        list = GetList(lbUnsorted);
                        qs.Sort(list);
                        SetList(lbSorted, list);
                    }
                    break;
                case "MS":    //Merge sort
                    {
                        var ms = new MergeSort();
                        list = GetList(lbUnsorted);
                        var sortedList = ms.Sort(list);
                        SetList(lbSorted, sortedList);
                    }
                    break;
                default:
                    MessageBox.Show("dit algoritme is nog niet in werking !");
                    break;
            }
            sw.Stop();
            lbTime.Text = $"Tijd: {sw.Elapsed.ToString(@"mm\:ss\.fff")}";

            if (!CheckIfOrdered(list))
                MessageBox.Show("De lijst is niet correct gesorteerd");

            UpdateUI();
        }

        /// <summary>
        /// Helper methode om de invoer om te zetten naar een integer
        /// </summary>
        /// <param name="box"></param>
        /// <returns></returns>
        private int ReadInput(TextBox box)
        {
            int temp = 0;
            if (int.TryParse(box.Text, out temp))
                return temp;

            throw new Exception("ingevoerde waarde is ongeldig");
        }

        /// <summary>
        /// Haal de waarden uit een listbox en zet ze om naar een array
        /// </summary>
        /// <param name="box"></param>
        /// <returns></returns>
        private int[] GetList(ListBox box)
        {
            int[] list = new int[box.Items.Count];
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = (int)box.Items[i];
            }
            return list;
        }

        private ListInt GetSLLList(ListBox box)
        {
            var list = new ListInt();
            for (int i = 0; i < box.Items.Count; i++)
            {
                list.AddLast((int)box.Items[i]);
            }
            return list;
        }
        private string[] GetStringList(ListBox box)
        {
            string[] list = new string[box.Items.Count];
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = (string)box.Items[i];
            }
            return list;
        }

        private Auto[] GetAutoList(ListBox box)
        {
            var list = new Auto[box.Items.Count];
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = (Auto)box.Items[i];
            }
            return list;
        }

        /// <summary>
        /// Voeg de lijst met getallen toe aan een listbox
        /// </summary>
        /// <param name="box"></param>
        /// <param name="list"></param>
        private void SetList(ListBox box, int[] list)
        {
            foreach (var i in list)
                box.Items.Add(i);
        }

        private void SetList(ListBox box, ListInt list)
        {
            var node = list.First;
            while (node != null)
            {
                box.Items.Add(node.Value);
                node = node.Next;
            }
        }


        private void SetList(ListBox box, string[] list)
        {
            foreach (var i in list)
                box.Items.Add(i);
        }

        private void SetList(ListBox box, Auto[] list)
        {
            foreach (var i in list)
                box.Items.Add(i);
        }

        private void UpdateUI(bool busy = false)
        {
            Mouse.OverrideCursor = busy ? Cursors.Wait : null;
        }

        /// <summary>
        /// Overloop en controleer of de lijst wel degelijk gesorteerd is
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        private bool CheckIfOrdered(int[] list)
        {
            if (list == null || list.Length == 0) return true;

            var current = list[0];
            foreach (var item in list)
            {
                if (item < current)
                    return false;
                current = item;
            }
            return true;
        }

        /// <summary>
        /// Geef manueel een getal in, voeg dit toe aan de lijst van unsorted elementen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbManual_KeyDown(object sender, KeyEventArgs e)
        {
            int nr = 0;
            if (e.Key == Key.Enter && int.TryParse(tbManual.Text, out nr))
            {
                if (int.TryParse(tbManual.Text, out nr))
                {
                    lbUnsorted.Items.Add(nr);
                } else
                {
                    lbUnsorted.Items.Add(tbManual.Text);
                }
                tbManual.Text = "";
            }
        }

        /// <summary>
        /// Voeg een aantal willekeurige auto's toe (code zelf te schrijven)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuCars_Click(object sender, RoutedEventArgs e)
        {
            string[] modellen = new[] { "Opel", "BMW", "Ford", "Mercedes", "Fiat" };
            string[] colors = new[] { "Groen", "Rood", "Blauw", "Wit", "Zwart" };

            for (var i = 0; i < ReadInput(tbAmount); i++)
            {
                var a = new Auto()
                {
                    Model = modellen[new Random().Next(0, modellen.Length)],
                    Kleur = colors[new Random().Next(0, colors.Length)],
                    Bouwjaar = 2000 + new Random().Next(0, 20),
                    Brandstof = (Brandstof)new Random().Next(0, 3),
                    AantalKm = new Random().Next(ReadInput(tbMin), ReadInput(tbMax))
                };
                lbUnsorted.Items.Add(a);
            }
        }
    }
}
