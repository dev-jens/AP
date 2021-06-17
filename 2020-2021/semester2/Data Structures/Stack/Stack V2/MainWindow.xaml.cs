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

namespace Stack_V2
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

        int[] stacker = new int[4];
        int top = -1;

        private void Push_btn_Click(object sender, RoutedEventArgs e)
        {
            // pak input
            int input = int.Parse(inputBox.Text);
            // push input naar stack
            Push(input);


            // clear
            inputBox.Text = "";
        }

        private void Pop_btn_Click(object sender, RoutedEventArgs e)
        {
            int gepopt = Pop();
            outputBox.Items.Add(gepopt);
        }


        public void Push(int input)
        {
            if (top == stacker.Length - 1)
            {
                int[] copyArray = new int[stacker.Length * 2];
                Array.Copy(stacker, copyArray, stacker.Length);

                stacker = copyArray;
            }
           

            top++;
            stacker[top] = input;

        }

        public int Pop()
        {
            if (top == -1) return -999999;

            int popIndex = stacker[top];
            top--;

            return popIndex;
        }
    }
}
