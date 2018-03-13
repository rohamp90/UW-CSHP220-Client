// CSHP220 
// Assignment 3
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
using System.Windows.Shapes;
using System.ComponentModel;

namespace HelloWorld
{
    /// <summary>
    /// Interaction logic for SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        CollectionView view;

        public SecondWindow()
        {
            InitializeComponent();

            // create a list of users to show up on List View Control
            var users = new List<Models.User>();

            users.Add(new Models.User { Name = "Dave", Password = "DavePwd" });
            users.Add(new Models.User { Name = "1Steve", Password = "StevePwd" });
            users.Add(new Models.User { Name = "Lisa", Password = "1isaPwd" });

            uxList.ItemsSource = users;
            view = (CollectionView)CollectionViewSource.GetDefaultView(uxList.ItemsSource);

        }

        //sort listview by Name
        private void GridViewColumnHeader_Click(object sender, RoutedEventArgs e)
        {
            view.SortDescriptions.Clear();
            view.SortDescriptions.Add(new SortDescription("Name", ListSortDirection.Ascending));
        }
        
        //sort listview by Password
        private void GridViewColumnHeader_Click_1(object sender, RoutedEventArgs e)
        {
            view.SortDescriptions.Clear();
            view.SortDescriptions.Add(new SortDescription("Password", ListSortDirection.Ascending));
        }
    }
}
