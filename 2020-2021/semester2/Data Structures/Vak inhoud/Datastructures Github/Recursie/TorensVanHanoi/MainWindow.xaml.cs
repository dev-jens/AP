using MyLibrary;
using MyLibrary.Queue.Array;
using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace TorensVanHanoi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TowersOfHanoiGame game;                // Our game class
        DispatcherTimer timer;                 // The timer is used to autoplay the game        
        private LineairQueueString moves;      // The queue is used to store all the moves when the game is 'autoplayed'

        public MainWindow()
        {
            InitializeComponent();

            Restart();
        }
        
        /// <summary>
        /// "Move" button clicked. There are many buttons to move a disk from a tower to another tower
        /// Hoewever for all the buttons there is only 1 click event method.
        /// We can determine by the 'sender' from which button the click has been triggered
        /// Each button has a Tag property (set in the XAML). With this Tag we can see which move is required.
        /// </summary>
        /// <param name="sender">the button which triggered the event</param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;    //Since sender is of type 'object' we must cast this to a 'Button'

            var From = int.Parse(b.Tag.ToString()[0].ToString());       //Get the "from" tower from the button Tag
            var To = int.Parse(b.Tag.ToString()[1].ToString());         //Get the "to" tower 

            game.Move(From, To);                                        //Do the move !

            ShowAll();                                                  //Update the UI

            if (game.IsGameFinished)                                    //show message if game has ended now...
                MessageBox.Show("Proficiat ! Je bent een 'pro' !");
        }

        /// <summary>
        /// Restart button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btRestart_Click(object sender, RoutedEventArgs e)
        {
            Restart();
        }

        /// <summary>
        /// Start the AutoPlay. The game will first calculate all the required moves and store them in a Queue
        /// These moves are afterwards played 1 by 1 with the timer so that the user can see them happening.
        /// The speed slider allows to change the playback speed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAutoPlay_Click(object sender, RoutedEventArgs e)
        {
            btAutoPlay.IsEnabled = false;           //During autoplay, it must not be possible to restart it
            slSpeed.IsEnabled = false;              
            Restart();                              //Reset the game

            moves = game.CalculateAllMoves();       //Calculate all the required moves and store them in a queue

            timer = new DispatcherTimer();          //Create and start the timer
            timer.Interval = new TimeSpan(0,0,0,0,(int)slSpeed.Value);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        /// <summary>
        /// Restart a new game
        /// </summary>
        private void Restart()
        {
            game = new TowersOfHanoiGame(int.Parse(tbDisks.Text));
            lblMinimum.Content = game.MinimumMoves;

            ShowAll();
        }

        /// <summary>
        /// Update the UI (update the towers, number of moves,...)
        /// </summary>
        private void ShowAll()
        {
            ShowTower(game.TowerItems(1), lb1);
            ShowTower(game.TowerItems(2), lb2);
            ShowTower(game.TowerItems(3), lb3);
            lblCount.Content = game.Moves;
        }

        /// <summary>
        /// Show 1 tower in a listbox, each disk is represented by a string ("=====")
        /// </summary>
        /// <param name="items">the items in the tower</param>
        /// <param name="lb">the listbox where the items should be added to</param>
        private void ShowTower(int[] items, ListBox lb)
        {
            lb.Items.Clear();
            foreach (var e in items)
            {
                lb.Items.Insert(0, MakeDiskVisual(e));
            }
        }

        private const char diskChar = '=';

        /// <summary>
        /// Make a "visual" disk from the specified value. 
        /// 1 = the smallest disk and will be represented as '='
        /// higher numbers will be larger disks 
        /// </summary>
        /// <param name="value">the disk size</param>
        /// <returns></returns>
        private string MakeDiskVisual(int value)
        {
            var s = new StringBuilder().Append(diskChar);
            for (int f = 0; f < value - 1; f++)
                s.Append(diskChar.ToString() + diskChar.ToString());
            return s.ToString();
        }

        /// <summary>
        /// The tick event of the timer. This is used to 'autoplay' the game.
        /// Each time a move will be played and shown to the user.
        /// When all moves have been played, the timer will be stopped
        /// The moves are located in a Queue and every tick a move is Dequeued.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!moves.IsEmpty)
            {
                var move = moves.Dequeue();                     // Get the next move
                var From = int.Parse(move[0].ToString());      //get "from" tower number
                var To = int.Parse(move[1].ToString());        //get "to" tower number
                game.Move(From, To);                           //Do the move !

                ShowAll();                                      //Show the current towers to the user
            }
            else
            {
                timer.Stop();
                btAutoPlay.IsEnabled = true;
                slSpeed.IsEnabled = true;
            }
        }
    }
}
