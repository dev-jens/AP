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

namespace ReeksOmkeren
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

        #region WPF logica
        private void btPush2_Click(object sender, RoutedEventArgs e)
        {
            string[] lijst = tbInputStack2.Text.Split(',');
            foreach (var item in lijst)
            {
                Push(int.Parse(item));
            }
            string output = "";
            while (!IsEmpty())
                output += " " + Pop();
            lbOutput2.Text = output;
        }
        #endregion

        #region stack logica

        int[] stackArray = new int[10];
        int top = -1;


        public void Push(int getal)
        {
            if (IsFull())
            {
                var newArray = new int[stackArray.Length * 2];
                for (int f = 0; f < stackArray.Length; f++)
                    newArray[f] = stackArray[f];
                stackArray = newArray;
            }

            stackArray[++top] = getal;
        }

        public int Pop()
        {
            if (!IsEmpty())
            {
                return stackArray[top--];
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


        #endregion
    }
}
