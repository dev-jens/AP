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

namespace Calculator
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

        private void TelOpKnop_Click(object sender, RoutedEventArgs e)
        {
            double getal1 = int.Parse(InputGet1.Text);
            double getal2 = int.Parse(InputGet2.Text);

            double uitkomst = TelOp(getal1, getal2);
            Outputfield.Text = uitkomst.ToString();
        }

        private void minKnop_Click(object sender, RoutedEventArgs e)
        {
            double getal1 = int.Parse(InputGet1.Text);
            double getal2 = int.Parse(InputGet2.Text);

            double uitkomst = TrekAf(getal1, getal2);
            Outputfield.Text = uitkomst.ToString();

        }

        private void DelenKnop_Click(object sender, RoutedEventArgs e)
        {
            double getal1 = int.Parse(InputGet1.Text);
            double getal2 = int.Parse(InputGet2.Text);

            double uitkomst = Deel(getal1, getal2);
            Outputfield.Text = uitkomst.ToString();
        }

        private void maalKnop_Click(object sender, RoutedEventArgs e)
        {
            double getal1 = int.Parse(InputGet1.Text);
            double getal2 = int.Parse(InputGet2.Text);

            double uitkomst = Vermenigvuldig(getal1, getal2);
            Outputfield.Text = uitkomst.ToString();
        }

        private double TelOp(double a, double b) { return a + b; }
        private double TrekAf(double a, double b) { return a - b; }
        private double Vermenigvuldig(double a, double b) { return a * b; }
        private double Deel(double a, double b) { return a / b; }

    }
}
