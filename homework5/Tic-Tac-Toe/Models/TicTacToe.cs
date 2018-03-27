using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Tic_Tac_Toe.Models
{
    class TicTacToe
    {
        private char turn;
        private List<string> xMoves;
        private List<string> oMoves;
        private Style xStyle = Application.Current.FindResource("XPlayerStyle") as Style;
        private Style oStyle = Application.Current.FindResource("OPlayerStyle") as Style;


        // Constructor starting with player X
        public TicTacToe()
        {
            Turn = 'X';
            xMoves = new List<string>();
            oMoves = new List<string>();
        }

        // Property for turn assignment
        public char Turn
        {
            get
            {
                return turn;
            }

            set
            {
                turn = value;
            }
        }


        // Property to log the played moves
        public string PlayedMoves
        {

            set
            {
                if (turn == 'X')
                {
                    xMoves.Add(value);
                }
                else
                {
                    oMoves.Add(value);
                }
            }
        }

        // Property to assign player's style
        public Style PlayerStyle
        {
            get
            {
                if (turn == 'X')
                {
                    return xStyle;
                }
                else
                {
                    return oStyle;
                }

            }
        }

        // Switch player Turn
        public void SwitchTurn()
        {
            if (Turn == 'X')
            {
                Turn = 'O';
            }
            else
            {
                Turn = 'X';
            }
        }

        // Check to see game is over for current player (aka there is a winner)
        public bool GameOver()
        {
            if (turn == 'X')
            {
                return WinnerCheck(xMoves);
            }
            else if (turn == 'O')
            {
                return WinnerCheck(oMoves);
            }
            return false;
        }

        // Algorithm to look for a winner, looking for posibilities of each tile
        public bool WinnerCheck(List<string> playedMoves)
        {
            switch (playedMoves.Last())
            {
                case "00":

                    if ((playedMoves.Contains("01") && playedMoves.Contains("02")) ||
                        (playedMoves.Contains("10") && playedMoves.Contains("20")) ||
                        (playedMoves.Contains("11") && playedMoves.Contains("22")))
                        return true;
                    break;

                case "01":

                    if ((playedMoves.Contains("00") && playedMoves.Contains("02")) ||
                        (playedMoves.Contains("11")) && (playedMoves.Contains("21")))
                        return true;
                    break;


                case "02":

                    if ((playedMoves.Contains("00") && playedMoves.Contains("01")) ||
                        (playedMoves.Contains("12") && playedMoves.Contains("22")) ||
                        (playedMoves.Contains("11") && playedMoves.Contains("20")))
                        return true;
                    break;

                case "10":

                    if ((playedMoves.Contains("00") && playedMoves.Contains("20")) ||
                    (playedMoves.Contains("11") && playedMoves.Contains("12")))
                        return true;
                    break;

                case "11":

                    if ((playedMoves.Contains("00") && playedMoves.Contains("22")) ||
                        (playedMoves.Contains("01") && playedMoves.Contains("21")) ||
                        (playedMoves.Contains("02") && playedMoves.Contains("20")) ||
                        (playedMoves.Contains("10") && playedMoves.Contains("12")))
                        return true;
                    break;

                case "12":

                    if ((playedMoves.Contains("02") && playedMoves.Contains("22")) ||
                        (playedMoves.Contains("10") && playedMoves.Contains("11")))
                        return true;
                    break;

                case "20":

                    if ((playedMoves.Contains("00") && playedMoves.Contains("10")) ||
                        (playedMoves.Contains("21") && playedMoves.Contains("22")) ||
                        (playedMoves.Contains("11") && playedMoves.Contains("02")))
                        return true;
                    break;

                case "21":

                    if ((playedMoves.Contains("20") && playedMoves.Contains("22")) ||
                        (playedMoves.Contains("11") && playedMoves.Contains("01")))
                        return true;
                    break;

                case "22":

                    if ((playedMoves.Contains("12") && playedMoves.Contains("02")) ||
                        (playedMoves.Contains("20") && playedMoves.Contains("21")) ||
                        (playedMoves.Contains("11") && playedMoves.Contains("00")))
                        return true;
                    break;

                default:
                    break;
            }

            return false;
        }

    }


}
