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

namespace Stack_Reverse
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

        private void btn_reverse_Click(object sender, RoutedEventArgs e)
        {
            string[] lijst = lb_input.Text.Split(',');
            foreach (var item in lijst)
            {
                stack.Push(int.Parse(item));
            }
            string output = "";
            while (!stack.IsEmpty())
                output += " " + stack.pop();
            tb_out.Text = output;
               
        }

       
    }
}
