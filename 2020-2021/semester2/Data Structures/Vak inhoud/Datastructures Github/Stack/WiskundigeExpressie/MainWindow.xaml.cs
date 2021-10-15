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

namespace WiskundigeExpressie
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
        private void btCheck_Click(object sender, RoutedEventArgs e)
        {
            var Correct = CheckExpression(tbExpression.Text);
            MessageBox.Show($"De expressie is {(Correct ? "correct" : "niet correct")} !");
        }
        #endregion

        #region berekeningslogica
        public bool CheckExpression(string expression)
        {
            bool Correct = true;
            
            Clear();            //clear the stack first
            foreach (var s in expression)
            {
                switch (s)
                {
                    case '(':
                    case '[':
                    case '{':
                        Push(s.ToString());
                        break;
                    case ')':
                        {
                            var first = Pop();
                            if (first == null || first[0] != '(')
                                Correct = false;
                        }
                        break;
                    case ']':
                        {
                            var first = Pop();
                            if (first == null || first[0] != '[')
                                Correct = false;
                        }
                        break;
                    case '}':
                        {
                            var first = Pop();
                            if (first == null || first[0] != '{')
                                Correct = false;
                        }
                        break;
                    default:
                        break;
                }
                if (!Correct)
                    break;
            }
            if (!IsEmpty())                 //If stack is not empty, some brackets where not closed !
                Correct = false;

            return Correct;
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
            return top == stackArray.Length-1;
        }

        /// <summary>
        /// Erase the full stack
        /// </summary>
        public void Clear()
        {
            top = -1;
        }

        public void ShowStack()
        {
            Debug.WriteLine($"Stack array: {string.Join(", ", stackArray)}");
        }
        #endregion
    }
}
