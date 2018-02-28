// CSHP220 
// Assignment 1
// By: Roham Pardakhtim

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

namespace HelloWorld
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

        // echos the password back in a message box
        private void uxSubmit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Submitting password: " + uxPassword.Text);
        }

        // method to enable submit button if there is text in uxName and uxPassword
        public void enableSubmit()
        {
            if (uxName.Text != string.Empty && uxPassword.Text != string.Empty)
            {
                uxSubmit.IsEnabled = true;
            }
            else
            {
                uxSubmit.IsEnabled = false;
            }
        }

        private void uxName_TextChanged(object sender, TextChangedEventArgs e)
        {
            enableSubmit();
        }

        private void uxPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            enableSubmit();
        }


    }
}
