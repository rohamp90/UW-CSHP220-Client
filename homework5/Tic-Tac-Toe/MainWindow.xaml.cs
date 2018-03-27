// CSHP220 
// Assignment 5
// By: Roham Pardakhtim

using System.Windows;
using System.Windows.Controls;
using Tic_Tac_Toe.Models;

namespace Tic_Tac_Toe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Models.TicTacToe ticTacToe;


        public MainWindow()
        {
            InitializeComponent();
            NewGame();
        }

        // Creating a new game by clearing the board, starting with player 'X' turn
        public void NewGame()
        {
            ticTacToe = new TicTacToe();

            uxGrid.IsEnabled = true;
            uxTurn.Text = string.Format("{0} Turn", ticTacToe.Turn);

            foreach (Button button in uxGrid.Children)
            {
                button.IsEnabled = true;
                button.Content = string.Empty;
            }
        }

        // Creating new game, 
        private void uxNewGame_Click(object sender, RoutedEventArgs e)
        {
            NewGame();
        }

        // Closing the game
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        // When game is played
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Marks the current button and makes it disable
            Button currentButton = (Button)sender;
            currentButton.Style = ticTacToe.PlayerStyle;
            currentButton.Content = ticTacToe.Turn;
            currentButton.IsEnabled = false;

            // Logs the position of the played button ex: 00, 01, 11, 21
            var currentMove = currentButton.Tag.ToString().Remove(1, 1);
            ticTacToe.PlayedMoves = currentMove;

            // Checks for a winner
            if (ticTacToe.GameOver() == true)
            {
                uxTurn.Text = string.Format("{0} is a winer", ticTacToe.Turn);
                uxGrid.IsEnabled = false;
            }
            else
            {
                // Updates the player turn
                ticTacToe.SwitchTurn();
                uxTurn.Text = string.Format("{0} Turn", ticTacToe.Turn);
            }

        }
    }
}
