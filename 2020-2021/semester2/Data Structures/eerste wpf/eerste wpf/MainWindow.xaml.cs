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

namespace eerste_wpf
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //som
            string text1 = getal1.Text;
            string text2 = getal2.Text;

            int som = int.Parse(text1) + int.Parse(text2);

            textbox.Text = $"de som van {text1} en {text2} is {som}";
        }

     
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string text1 = getal1.Text;
            string text2 = getal2.Text;

            int verschil = int.Parse(text1) - int.Parse(text2);

            textbox.Text = $"de verschil van {text1} en {text2} is {verschil}";
        }

        private void textbox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
