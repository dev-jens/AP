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

namespace stackV1
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

        private void pushKnop_Click(object sender, RoutedEventArgs e)
        {
            int input = int.Parse(inputStack.Text);
            push(input);

            inputStack.Text = "";

            // Enable Pop button is it's disabled
            if (!popKnop.IsEnabled)
                popKnop.IsEnabled = true;
        }

        private void popKnop_Click(object sender, RoutedEventArgs e)
        {
            int waarde = pop();

            outputStack.Items.Add(waarde.ToString());

       
        }

        int[] stack = new int[5];
        int top = -1;


        private void push(int input)
        {
            if (top == stack.Length-1){ return; }
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
