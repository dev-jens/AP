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

namespace Calculator2
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

        #region WPF

        private string expression = "";
        private Operation lastOperation;
        private double result = 0;

        private void btSum_Click(object sender, RoutedEventArgs e)
        {
            expression += tbNumber.Text + "+";
            lblResult.Text = expression;
            Calculate();
            lastOperation = Operation.Add;
        }

        private void btSubtract_Click(object sender, RoutedEventArgs e)
        {
            expression += tbNumber.Text + "-";
            lblResult.Text = expression;
            Calculate();
            lastOperation = Operation.Subtract;
        }

        private void btMultiply_Click(object sender, RoutedEventArgs e)
        {
            expression += tbNumber.Text + "*";
            lblResult.Text = expression;
            Calculate();
            lastOperation = Operation.Multiply;
        }

        private void btDivide_Click(object sender, RoutedEventArgs e)
        {
            expression += tbNumber.Text + "/";
            lblResult.Text = expression;
            Calculate();
            lastOperation = Operation.Divide;
        }

        private void btEquals_Click(object sender, RoutedEventArgs e)
        {
            expression += tbNumber.Text + "=";
            Calculate();
            lblResult.Text = expression + result.ToString();
            //reset everything for next expression
            expression = "";
            lastOperation = Operation.None;
            result = 0;
        }

        #endregion

        #region berekeningslogica
        void Calculate()
        {
            double nr = double.Parse(tbNumber.Text);
            tbNumber.Text = "";
            switch (lastOperation)
            {
                case Operation.Add:
                    result += nr;
                    break;
                case Operation.Subtract:
                    result -= nr;
                    break;
                case Operation.Divide:
                    result /= nr;
                    break;
                case Operation.Multiply:
                    result *= nr;
                    break;
                default:
                    result = nr;
                    break;
            }
        }
        #endregion
    }

    enum Operation
    {
        None,
        Add,
        Subtract,
        Divide,
        Multiply
    }
}
