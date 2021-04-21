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

namespace Calculator_V2
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

        private enum Operation {Plus,Min,Maal,Delen,None }

        private string expression = "";
        private Operation lastOperation =Operation.None;
        private double result = 0;


        private void PlusKnop_Click(object sender, RoutedEventArgs e)
        {
            expression += $"{inputField.Text} + ";
            outputField.Text = expression;
            Calculate();
            lastOperation = Operation.Plus;


        }

        private void MinKnop_Click(object sender, RoutedEventArgs e)
        {
            expression += $"{inputField.Text} - ";
            outputField.Text = expression;
            Calculate();
            lastOperation = Operation.Min;

        }

        private void MaalKnop_Click(object sender, RoutedEventArgs e)
        {
            expression += $"{inputField.Text} * ";
            outputField.Text = expression;
            Calculate();
            lastOperation = Operation.Maal;
        }

        private void DeelKnop_Click(object sender, RoutedEventArgs e)
        {
            expression += $"{inputField.Text} / ";
            outputField.Text = expression;
            Calculate();
            lastOperation = Operation.Delen;
        }

        private void UikomstKnop_Click(object sender, RoutedEventArgs e)
        {
            expression += $"{inputField.Text} = ";
            Calculate();
            outputField.Text = $"{expression} {result}";

            expression = "";
            lastOperation = Operation.None;
            result = 0;
        }

        private void Calculate() 
        {
            double input = double.Parse(inputField.Text);
            inputField.Text = "";

            switch (lastOperation)
            {
                case Operation.Plus:
                    result += input;
                    break;
                case Operation.Min:
                    result -= input;
                    break;
                case Operation.Maal:
                    result *= input;
                    break;
                case Operation.Delen:
                    result /= input;
                    break;
                case Operation.None:
                    result = input;
                    break;
            }


        }
    }
}
