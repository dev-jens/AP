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

namespace Reverse_stack
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

        private void Reverse_btn_Click(object sender, RoutedEventArgs e)
        {
            string[] lijst = inputBox.Text.Split(',');
            string[] reversedArray = Reverse(lijst);
            PrintArray(reversedArray);
            inputBox.Text = "";
        }

        public string[] Reverse(string[] lijst)
        {
            Array.Reverse(lijst);
            return lijst;
        }

        public void PrintArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                outputBox.Items.Add(array[i]);
            }
        }
    }
}
