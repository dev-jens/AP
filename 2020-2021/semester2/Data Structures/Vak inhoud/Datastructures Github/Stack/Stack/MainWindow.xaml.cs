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

namespace Stack
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            UpdateUI();
        }

        #region WPF logica
        bool InputValid = false;

        private void btPush_Click(object sender, RoutedEventArgs e)
        {
            int value = 0;
            if (int.TryParse(tbInputStack.Text, out value))
            {
                Push(value);
                tbInputStack.Text = "";
            }
            UpdateUI();
        }

        private void btPop_Click(object sender, RoutedEventArgs e)
        {
            int value = Pop();
            if (value != -999999999)
                lbOutputStack.Items.Add(value);
            UpdateUI();
        }

        private void tbInputStack_TextChanged(object sender, TextChangedEventArgs e)
        {
            int value = 0;
            InputValid = int.TryParse(tbInputStack.Text, out value);
            UpdateUI();
        }

        void UpdateUI()
        {
            btPop.IsEnabled = !IsEmpty();
            btPush.IsEnabled = InputValid;
        }

        #endregion


        #region stack logica

        int[] stackArray = new int[5];
        int top = -1;


        public void Push(int getal)
        {
            if (IsFull())                   //uitbreiding voor Stack versie 2
            {
                var newArray = new int[stackArray.Length * 2];
                Array.Copy(stackArray, newArray, stackArray.Length);
                //for (int f = 0; f < stackArray.Length; f++)
                //    newArray[f] = stackArray[f];
                stackArray = newArray;
            }                                               //einde uitbreiding voor stack versie 2

            stackArray[++top] = getal;
            ShowStack();
        }

        public int Pop()
        {
            if (!IsEmpty())
            {
                int value = stackArray[top];
                stackArray[top] = 0;            //niet strict nodig, maar duidelijker om te debuggen
                top--;
                ShowStack();
                return value;
            }

            return -999999999;
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public bool IsFull()
        {
            return top == stackArray.Length - 1;
        }


        public void ShowStack()
        {
            Debug.WriteLine($"Stack array: {string.Join(", ", stackArray)}");
        }
        #endregion
    }
}