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
using System.Diagnostics;

namespace StackV1
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


        private int[] stack = new int[5];
        int top = -1;

        private void pushKnop_Click(object sender, RoutedEventArgs e)
        {
            int input = int.Parse(inputField.Text);
           
            push(input);           
            inputField.Text = "";

        }

        private void PopKnop_Click(object sender, RoutedEventArgs e)
        {
            int value = pop();
            if (value != 404) 
            { 
                pushKnop.IsEnabled = true;
                outputField.Items.Add(value);
            }
            else
                return;
        }

        private void push(int getal) 
        {
            if (top == stack.Length - 1) {
                var newArray = new int[stack.Length * 2];
                Array.Copy(stack, newArray, stack.Length);
                //for (int f = 0; f < stackArray.Length; f++)
                //    newArray[f] = stackArray[f];
                stack= newArray;
        
           
            }

            top++;
            stack[top] = getal;

            ShowStack();

        }

        private int pop()
        {
            if (top >= 0)
            {
                int stackOut = stack[top];
                top--;
                return stackOut;
            }
            return 404; 
            
        }

        public void ShowStack()
        {
            Debug.WriteLine($"Array: {string.Join(", ", stack)}");
        }

    }
}
