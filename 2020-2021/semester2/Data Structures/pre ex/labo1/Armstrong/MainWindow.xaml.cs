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

namespace Armstrong
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

        private void Btn_Calculate_Click(object sender, RoutedEventArgs e)
        {
            string input = inputField.Text;

            bool IsArmstrong = IsArmstrongNum(input);

            if (IsArmstrong)
            {
                outputField.Text = $"{input} is een armstrong";
            }
            else
            {
                outputField.Text = $"{input} is geen armstrong";
            }

        }
        private bool IsArmstrongNum(string input)
        {
            //1° Aantal cijfers ontdekken
            int aantalcijfers = 0;
            int deling = 0;
            int maaltien = 10;
            int getal = int.Parse(input);
            do
            {
                deling = getal / maaltien;
                maaltien *= 10;
                aantalcijfers++;
            } while (deling != 0);

            //2° Kijken of het armstrong is
            int som = 0;
            int enkelgetal = 0;
            int aantalloops = aantalcijfers;
            int tussengetal = getal;
            while (aantalloops > 0)
            {
                enkelgetal = tussengetal / (int)Math.Pow(10, aantalloops - 1);
                som += (int)Math.Pow(enkelgetal, aantalcijfers);

                tussengetal = tussengetal - (enkelgetal * (int)Math.Pow(10, aantalloops - 1));
                aantalloops--;
            }

            if (som == getal)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
