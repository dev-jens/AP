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

namespace queue_circular
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

        int[] Queue = new int[5];
        int front = 0;
        int rear = -1;


        private void enqueue_btn_Click(object sender, RoutedEventArgs e)
        {
            int input = int.Parse(inputbox.Text);


        }

        private void DeQueue_Click(object sender, RoutedEventArgs e)
        {

        }


        public void EnQueue(int getal)
        {
            
        }

        public int DeQueue()
        {

            return 0;
        }

    }
}
