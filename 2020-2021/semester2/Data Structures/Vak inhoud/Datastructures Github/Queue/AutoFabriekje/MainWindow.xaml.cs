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
using System.Windows.Threading;

namespace AutoFabriekje
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        DispatcherTimer timer;

        public MainWindow()
        {
            InitializeComponent();

            // at startup this code is executed to initialize the queues and the Timer
            int max = 10;
            CreateQueues(3, max);  //create 3 queues of length = 10
            pbQueueCars.Maximum = max;
            pbQueueEngine.Maximum = max;
            pbQueueTires.Maximum = max;

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(10);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        #region multi lineair boolean queues in jagged array

        bool[][] queues;
        int[] End;

        void CreateQueues(int count, int initialSize)
        {
            queues = new bool[count][];
            End = new int[count];
            for (int f = 0; f < count; f++)
            {
                queues[f] = new bool[initialSize];
                End[f] = -1;
            }
        }

        void Enqueue(int queue, bool value)
        {
            if (IsFull(queue))
            {
                var newQ = new bool[queues[queue].Length * 2];
                for (int f = 0; f <= End[queue]; f++)
                    newQ[f] = queues[queue][f];
                queues[queue] = newQ;
            }
            if (!IsFull(queue))
                queues[queue][++End[queue]] = value;

            //PrintArray();
        }

        bool? Dequeue(int queue)
        {
            if (!IsEmpty(queue))
            {
                bool result = queues[queue][0];
                for (int f = 0; f < End[queue]; f++)
                    queues[queue][f] = queues[queue][f + 1];
                queues[queue][End[queue]] = false;                 //not required, but for easier debugging

                End[queue]--;
                //PrintArray();
                return result;
            }
            return null;
        }

        bool IsEmpty(int queue)
        {
            return End[queue] == -1;
        }

        bool IsFull(int queue)
        {
            return End[queue] == queues[queue].Length - 1;
        }

        int Count(int queue)
        {
            return End[queue] + 1;
        }


        int Length(int queue)
        {
            return queues[queue].Length;
        }
        #endregion

        #region WPF code
        private void btTires_Click(object sender, RoutedEventArgs e)
        {
            for (int f = 0; f < 5; f++)
                Enqueue(0, true);
            ShowQueues();
        }

        private void btEngine_Click(object sender, RoutedEventArgs e)
        {
            for (int f = 0; f < 5; f++)
                Enqueue(1, true);
            ShowQueues();
        }

        private void btProduce_Click(object sender, RoutedEventArgs e)
        {
            for (int f = 0; f < 4; f++)
                Dequeue(0);
            Dequeue(1);

            Enqueue(2, true);
            ShowQueues();
        }

        private void btSell_Click(object sender, RoutedEventArgs e)
        {
            Dequeue(2);
            ShowQueues();
        }

        private void AddLog(int day, string message)
        {
            lbLogbook.Items.Add($"Dag {day}: {message}");
            lbLogbook.ScrollIntoView(lbLogbook.Items[lbLogbook.Items.Count - 1]);
        }

        private void ShowQueues()
        {
            pbQueueTires.Maximum = Length(0);
            pbQueueTires.Value = Count(0);
            lblTires.Text = Count(0).ToString();
            pbQueueEngine.Maximum = Length(1);
            pbQueueEngine.Value = Count(1);
            lblEngines.Text = Count(1).ToString();
            pbQueueCars.Maximum = Length(2);
            pbQueueCars.Value = Count(2);
            lblStock.Text = Count(2).ToString();
        }
        #endregion

        #region timer for daily handling

        int ticks = 0;                  // total number of ticks (1 tick every 10 ms)
        int day = 0;                    // total number of days passed
        int nextDelivery = 1;           // day of the next delivery

        private void Timer_Tick(object sender, EventArgs e)
        {
            ticks++;
            if (ticks >= slDayLength.Value)
            {
                ticks = 0;
                day++;

                var sellToday = new Random().Next(100) <= slSellPercentage.Value;
                if (sellToday)
                {
                    if (!IsEmpty(2))
                    {
                        Dequeue(2);
                        AddLog(day, $"Auto verkocht ({Count(2)} in stock)");
                    }
                    else
                        AddLog(day, "Geen auto in stock");
                }

                if (Count(0) >= 4 && Count(1) >= 0 && Count(2) < 10)
                {
                    for (int f = 0; f < 4; f++)
                        Dequeue(0);
                    Dequeue(1);
                    Enqueue(2, true);
                    AddLog(day, $"Auto geproduceerd  ({Count(2)} in stock)");
                }
                else if (Count(2) == 10)
                    AddLog(day, "stock volzet");
                else
                    AddLog(day, "onvoldoende voorraad");

                if (nextDelivery == day)
                {
                    if (Count(2) <= 5)
                    {
                        for (int f = 0; f < 30; f++)
                            Enqueue(0, true);
                        for (int f = 0; f < 10; f++)
                            Enqueue(1, true);
                        AddLog(day, $"nieuwe levering ({Count(0)} banden / {Count(1)} motors)");
                    }
                    else
                        AddLog(day, "levering geweigerd");
                    nextDelivery = day + 7;
                }

                ShowQueues();
            }
        }
        #endregion
    }
}
