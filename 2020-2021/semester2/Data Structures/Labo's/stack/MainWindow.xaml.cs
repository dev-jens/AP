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

namespace stack
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

        StackInt stack = new StackInt();

        private void btn_push_Click(object sender, RoutedEventArgs e)
        {
            int input = int.Parse(tb_input.Text);
            stack.Push(input);
            tb_input.Text = "";
            btn_pop.IsEnabled = true;
        }

        private void btn_pop_Click(object sender, RoutedEventArgs e)
        {
            int val = stack.pop();
            if (val != -99999)
            {
                btn_pop.IsEnabled = true;
                lb_output.Items.Add(val);
            }
            else
            {
                btn_pop.IsEnabled = false;
            }
        }
    }
}
