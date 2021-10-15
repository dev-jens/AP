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

namespace Browser
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

        #region WPF

        string currentUrl = "";
        bool Ignore = true;
        
        private void btGo_Click(object sender, RoutedEventArgs e)
        {
            if (currentUrl != "")
                Push(currentUrl);

            currentUrl = tbUrl.Text;
            Ignore = true;
            Browser.Navigate(tbUrl.Text);
            Ignore = false;
            UpdateUi();
        }

        private void btBack_Click(object sender, RoutedEventArgs e)
        {
            string url = Pop();
            Ignore = true;
            Browser.Navigate(url);
            Ignore = false;
            tbUrl.Text = url;
            UpdateUi();
        }

        void UpdateUi()
        {
            btBack.IsEnabled = !IsEmpty();
        }

        /// <summary>
        /// Dit event wordt afgevuurd wanneer de browser naar een andere pagina gaat, dit kan bv. zijn doordat de gebruiker op een link klikt in de pagina.
        /// Dit willen we opvangen en dat kan via dit event.
        /// Probleem hierbij is dat wanneer we zelf de Navigate aanroepen vanuit code hierboven, dat dan ook dit event wordt gettriggerd.
        /// Daarom dat de Navigate vlag is voorzien, zodat we op dat moment dit event kunnen negeren omdat we het zelf hebben getriggerd in feite.
        /// en de URL niet nogmaals op de stack moet worden gepushed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Browser_NavigationStarting(object sender, Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNavigationStartingEventArgs e)
        {
            if (Ignore) return;

            Push(currentUrl);
            currentUrl = e.Uri.OriginalString;
            tbUrl.Text = currentUrl;
            UpdateUi();
        }

        #endregion

        #region stack logica
        string[] stackArray = new string[5];
        int top = -1;
        
        public void Push(string getal)
        {
            if (IsFull())                   //uitbreiding voor Stack versie 2
            {
                var newArray = new string[stackArray.Length * 2];
                Array.Copy(stackArray, newArray, stackArray.Length);
                //for (int f = 0; f < stackArray.Length; f++)
                //    newArray[f] = stackArray[f];
                stackArray = newArray;
            }                                               //einde uitbreiding voor stack versie 2

            stackArray[++top] = getal;
            ShowStack();
        }

        public string Pop()
        {
            if (!IsEmpty())
            {
                var value = stackArray[top];
                stackArray[top] = null;            //niet strict nodig, maar duidelijker om te debuggen
                top--;
                ShowStack();
                return value;
            }

            return null;
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public bool IsFull()
        {
            return top == stackArray.Length - 1;
        }

        public void ShowStack()
        {
            Debug.WriteLine($"Stack array: {string.Join(", ", stackArray)}");
        }
        #endregion

    }
}
