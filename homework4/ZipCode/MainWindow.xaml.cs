// CSHP220 
// Assignment 4
// By: Roham Pardakhtim
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace ZipCode
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            uxSubmit.IsEnabled = false;
        }


        private void uxTextbox_DataContextChanged(object sender, TextChangedEventArgs e)
        {
            // US Zip Code consists of 5 digits, or optionally has a - followed by 4 digits
            // Examples: 98006, 98006-1414
            // Canadian Postal Code contains three sets of uppercase lettrs and digits
            // Example: T1R2X4
            string zipCodePattern = @"^\d{5}(\-\d{4})?$|[A-Z]\d[A-Z]\d[A-Z]\d$";

            Regex regext = new Regex(zipCodePattern);
            uxSubmit.IsEnabled = regext.IsMatch(uxTextbox.Text);
        }

        // Help Message
        private void HelpButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("US Zip Codes: ##### or #####-####\nCanadian Postal Codes: A#B#C#\n\n Example:\n US Zip Codes: 98122 or 98012-4444 \n Canadian Postal Codes: T1R2X4 ","Zip Code Formatting Tips");
        }
    }
}
