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

namespace Circular_Queue
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
        Cqueue CQ = new Cqueue(5);

        private void btn_Dequeue_Click(object sender, RoutedEventArgs e)
        {
            int val = CQ.DeQueue();
            lb_output.Items.Add(val);
        }

        private void btn_EnQueue_Click(object sender, RoutedEventArgs e)
        {
            CQ.EnQueue(int.Parse(tb_input.Text));
            tb_input.Text = "";
        }
    }
}
