using MyLibrary;
using MyLibrary.Queue.Array;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        #region lineair queue

        int[] queue = new int[5];
        int End = -1;

        void Enqueue(int value)
        {
            if (End < queue.Length - 1)
                queue[++End] = value;

            PrintQueue();
        }

        int Dequeue()
        {
            if (End >= 0)
            {
                int result = queue[0];
                for (int f = 0; f < End; f++)
                    queue[f] = queue[f + 1];
                queue[End] = 0;                 //not required, but for easier debugging

                End--;
                PrintQueue();
                return result;
            }
            return -9999999;
        }

        bool IsEmpty()
        {
            return End == -1;
        }

        void PrintQueue()
        {
            Debug.WriteLine($"Array: {string.Join(", ", queue)}");
        }
        #endregion

        #region WPF lineair queue
        private void btEnqueue_Click(object sender, RoutedEventArgs e)
        {
            Enqueue(int.Parse(tbIn.Text));
            ShowQueue();
            tbIn.Text = "";
        }

        private void btDequeue_Click(object sender, RoutedEventArgs e)
        {
            var result = Dequeue();
            ShowQueue();
            lbOut.Items.Add(result);    // Show element that comes out of the queue
        }

        /// <summary>
        /// Toon de huidige inhoud van de queue
        /// </summary>
        private void ShowQueue()
        {
            lbStack.Items.Clear();
            Array.ForEach<int>(queue, a => lbStack.Items.Add(a));
        }
        #endregion

        #region circular queue
        const int length = 5;
        int[] queue2 = new int[length];
        int Front = int.MinValue;    // Minvalue => Queue is empty !
        int Rear = length - 1;  //start at the last position    

        void Enqueue2(int value)
        {
            if (Rear + 1 != Front && Rear - (queue2.Length - 1) != Front)
            {
                if (++Rear == queue2.Length)
                    Rear = 0;
                queue2[Rear] = value;
                if (Front == int.MinValue)        //First element in queue ? 
                    Front = Rear;       //Set Front = Rear position

                PrintQueue2();
            }
        }

        int Dequeue2()
        {
            if (!IsEmpty2())
            {
                int result = queue2[Front];
                queue2[Front] = 0;             //not required, but for easier debugging

                if (Front == Rear)
                    Front = int.MinValue;         // => Queue = empty 
                else if (++Front == queue2.Length)      //otherwise increment and check end of circle 
                    Front = 0;
                PrintQueue2();
                return result;
            }
            return -9999999;
        }

        bool IsEmpty2()
        {
            return Front == int.MinValue;
        }

        void PrintQueue2()
        {
            Debug.WriteLine($"Array2: {string.Join(", ", queue2)}");
        }
        #endregion

        #region WPF Circular Queue
        private CircularQueueInt queueObj = new CircularQueueInt(5);

        private void btEnqueue2_Click(object sender, RoutedEventArgs e)
        {
            //Enqueue2(int.Parse(tbIn2.Text));              // Zonder OO
            queueObj.Enqueue(int.Parse(tbIn2.Text));        //OO versie
            ShowQueue2();
            tbIn2.Text = "";
        }

        private void btDequeue2_Click(object sender, RoutedEventArgs e)
        {
            //var result = Dequeue2();                      //Zonder OO
            var result = queueObj.Dequeue();                // OO versie
            ShowQueue2();
            lbOut2.Items.Add(result);                       //Toon wat er uit de queue is gekomen
        }

        private void ShowQueue2()
        {
            lbStack2.Items.Clear();
            //Array.ForEach<int>(queue2, a => lbStack2.Items.Add(a));   //Zonder OO
            Array.ForEach<int>(queueObj.Queue, a => lbStack2.Items.Add(a)); // Met OO
        }
        #endregion
    }
}
