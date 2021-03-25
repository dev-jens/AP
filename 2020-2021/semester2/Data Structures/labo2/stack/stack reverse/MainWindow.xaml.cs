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

namespace stack_reverse
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

        private void ReverseKnop_Click(object sender, RoutedEventArgs e)
        {
            string input = inputfield.Text;
            string[] inputSplit = input.Split(",");

            for (int i = 0; i < inputSplit.Length; i++)
            {
                int value = int.Parse(inputSplit[i]);
                push(value);
            }

            for (int i = 0; i < inputSplit.Length; i++)
            {
                int value = pop();
                outputField.Text += $"{value.ToString()}, ";
            }
            
        }

        int[] stack = new int[5];
        int top = -1;

        private void push(int input)
        {
            if (top == stack.Length - 1) { return; }
            top++;
            stack[top] = input;
        }

        private int pop()
        {
            int input = stack[top];
            top--;
            return input;
        }
    }
}
