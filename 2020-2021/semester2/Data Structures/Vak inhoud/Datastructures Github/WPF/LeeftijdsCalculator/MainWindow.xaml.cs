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

namespace LeeftijdsCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dtBirth.DisplayDateEnd = DateTime.Now;      //Prevent that future dates can be selected
            calBirth.DisplayDateEnd = DateTime.Now;
        }

        #region WPF logica
        private void btCalculate_Click(object sender, RoutedEventArgs e)
        {
            DateTime date;
            if (DateTime.TryParse(tbBirthDate.Text, out date))
            {
                if (date < DateTime.Now)
                {
                    var age = CalculateAge(date);
                    lblAge.Text = $"U bent dan momenteel {Math.Truncate(age)} jaren jong.";
                }
                else
                    MessageBox.Show("In de toekomst geboren worden is momenteel nog niet mogelijk...");
            }
            else
                MessageBox.Show("De ingevoerde datum is niet correct");
        }



        private void dtBirth_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            var age = CalculateAge(dtBirth.SelectedDate.Value);
            lblAge.Text = $"U bent dan momenteel {Math.Truncate(age)} jaren jong.";
        }

        private void calBirth_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            var age = CalculateAge(calBirth.SelectedDate.Value);
            lblAge.Text = $"U bent dan momenteel {Math.Truncate(age)} jaren jong.";
        }

        #region berekeningslogica
        private double CalculateAge(DateTime date)
        {
            return (double)DateTime.Now.Subtract(date).Days / 365;
        }
        #endregion

        #endregion
    }

    
}
