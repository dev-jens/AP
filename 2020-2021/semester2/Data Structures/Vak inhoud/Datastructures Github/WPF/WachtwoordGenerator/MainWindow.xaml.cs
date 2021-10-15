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

namespace WachtwoordGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] list = new string[3] { "TEST", "SVEN", "" };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            list[2] = "HALLO";
            //list1.ItemsSource = null;
            //list1.ItemsSource = list;
        }




        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            //Do something when user clicks button 'btnCalculate'
            var lengte = tbLengte.Text;
            var pwd = PaswoordGenerator(int.Parse(lengte));
            txtWachtwoord.Text = pwd;
        }

        /// <summary>
        /// Paswoord generator uit de oefeningen van "Zie Scherp", H7
        /// </summary>
        /// <param name="lengte"></param>
        /// <returns></returns>
        static string PaswoordGenerator(int lengte)
        {
            string resultaat = "";
            Random r = new Random();
            for (int i = 0; i < lengte; i++)
            {
                switch (r.Next(0, 3))
                {
                    case 0: //cijfer
                        resultaat += r.Next(0, 10);
                        break;
                    case 1: //kleine letters
                        resultaat += (char)r.Next('a', 'z' + 1);
                        break;
                    case 2: //hoofdletters
                        resultaat += (char)r.Next('A', 'Z' + 1);
                        break;
                }
            }
            return resultaat;
        }
    }
}
