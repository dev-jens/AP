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

namespace Linear_queue
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

        LQueue Q = new LQueue();

        private void btn_EnQueue_Click(object sender, RoutedEventArgs e)
        {
            int input = int.Parse(tb_input.Text);
            Q.EnQueue(input);
            tb_input.Text = "";
        }

        private void btn_Dequeue_Click(object sender, RoutedEventArgs e)
        {
            int val = Q.DeQueue();
            lb_output.Items.Add(val);
        }

       

     
    }
}
