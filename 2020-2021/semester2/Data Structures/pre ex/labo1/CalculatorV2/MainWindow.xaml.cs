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

namespace CalculatorV2
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


        double uitkomst;
        string rekenSom = "";

        private void TelOpKnop_Click(object sender, RoutedEventArgs e)
        {
            double getal1 = int.Parse(InputField.Text);
            uitkomst += getal1;
            rekenSom += $"{getal1.ToString()} + ";
            InputField.Clear();
         
          
        }

        private void minKnop_Click(object sender, RoutedEventArgs e)
        {
            double getal1 = int.Parse(InputField.Text);
            uitkomst -= getal1;
            rekenSom += $"{getal1.ToString()} - ";
            InputField.Clear();

        }

        private void DelenKnop_Click(object sender, RoutedEventArgs e)
        {
            double getal1 = int.Parse(InputField.Text);
            uitkomst /= getal1;
            rekenSom += $"{getal1.ToString()} /";
            InputField.Clear();
        }

        private void maalKnop_Click(object sender, RoutedEventArgs e)
        {
            double getal1 = int.Parse(InputField.Text);
            uitkomst *= getal1;
            rekenSom += $"{getal1.ToString()} *";
            InputField.Clear();


        }

       

        private void uikomst_Click(object sender, RoutedEventArgs e)
        {
            rekenSom += $"={uitkomst.ToString()}";
            outputField.Text = uitkomst.ToString();
            outputField2.Text = rekenSom;

        }

        private double TelOp(double a, double b) { return a + b; }
        private double TrekAf(double a, double b) { return a - b; }
        private double Vermenigvuldig(double a, double b) { return a * b; }
        private double Deel(double a, double b) { return a / b; }
    }
}

