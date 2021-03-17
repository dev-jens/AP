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

namespace Caesar_Encryptie
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

        private void Encrypt_btn__Click(object sender, RoutedEventArgs e)
        {
            string input = inputField.Text;
            int key = int.Parse(keyField.Text);

            char[] inputCharArray = stringToArr(input);
            char[] inputEncrypt = Encrypt(inputCharArray,key);

            string output = new string(inputEncrypt);

            outputfield.Text = output;
        }

        private void Decrypt_btn_Click(object sender, RoutedEventArgs e)
        {
            string input = inputField.Text;
            int key = int.Parse(keyField.Text);

            char[] inputCharArray = stringToArr(input);
            char[] inputEncrypt = DeCrypt(inputCharArray, key);

            string output = new string(inputEncrypt);

            outputfield.Text = output;
        }
        private void copyOutput_Click(object sender, RoutedEventArgs e)
        {
            string output = outputfield.Text;
            inputField.Text = output;
        }

        private char[] Encrypt(char[] plaintext, int key)
        {
            char[] result = new char[plaintext.Length];
            //werkt enkel voor kleine letters
            for (int i = 0; i < plaintext.Length; i++)
            {
                if (plaintext[i] == ' ')
                    result[i] = ' ';
                else
                {
                    int newchar = (int)plaintext[i] + key;
                    if (newchar > 122) //nodig voor encrypt
                        newchar -= 26;
                    else if (newchar < 97) //nodig voor decrypt
                        newchar += 26;

                    result[i] = (char)newchar;
                }
            }
            return result;
        }

        private char[] DeCrypt(char[] cipertext, int key)
        {
            return Encrypt(cipertext, -key);
        }

       private char[] stringToArr(string text)
        {
            char[] arr = new char[text.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i]= text[i];
            }

            return arr;

        }

       
    }
}
