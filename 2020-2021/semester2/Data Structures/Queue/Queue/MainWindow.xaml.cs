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

namespace Queue
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


        int[] queue = new int[5];
        int rear = -1;

        private void Enqueue_btn_Click(object sender, RoutedEventArgs e)
        {
            int input = int.Parse(inputbox.Text);
            EnQueue(input);
            inputbox.Text = "";
        }

        private void Dequeue_btn_Click(object sender, RoutedEventArgs e)
        {
            int result = DeQueue();
            outputbox.Items.Add(result);
        }



        public void EnQueue(int getal)
        {
            if (queue.Length-1 == rear)
                return;
            queue[++rear] = getal;
        }

        public int DeQueue()
        {
            if (rear == -1)
                return -99999;

            int front = queue[0];
            for (int i = 0; i < rear ; i++)
            {
                queue[i] = queue[i + 1];
            }
            rear--;
            return front;
        }
    }
}
