
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors {
    /// <summary>
    /// Creates Rock, Paper, Scissors that belong to the data type Rolls 
    /// </summary>
    enum Rolls { Rock, Paper, Scissors }
    public partial class frmRockPaperScissors : Form {
        // Declare field variables
        private int player1WinsTotal = 0;
        private int player2WinsTotal = 0;
        private int tieTotal = 0;
        private int gamesPlayed = 0;
        private int player1Roll;
        private int player2Roll;
        // Creates a random number generator
        Random random = new Random(Guid.NewGuid().GetHashCode());

        public frmRockPaperScissors() {
            InitializeComponent();
        }

        /// <summary>
        /// Shows the calculated numbers in the output labels
        /// </summary>
        private void ShowOutputLabels() {
            lblTotalPlayer1Wins.Text = player1WinsTotal.ToString("n0");
            lblTotalPlayer2Wins.Text = player2WinsTotal.ToString("n0");
            lblOutputTieGames.Text = tieTotal.ToString("n0");
            lblTotalGamesPlayed.Text = gamesPlayed.ToString("n0");
        }
        /// <summary>
        /// Randomizes the throw for a player
        /// </summary>
        /// <returns></returns>
        private int GetRandomThrow() {
            return random.Next(3);
        }

        /// <summary>
        ///  The players' throws are randomized to create a computer vs computer rock-paper-scissors game
        /// </summary>
        private void Throw() {
            // Loops from 1 to the number of games specified by the trackbar
            for (int i = 1; i <= gamesPlayed; i++) {                
                // Randomizes the throw and assigns the throw to the field variable
                int player1 = GetRandomThrow();
                player1Roll = player1;
                int player2 = GetRandomThrow();
                player2Roll = player2;

                // Determines of player 1 or player 2 won
                bool didPlayer1Win = DidThrowWin(player1, player2);
                bool didPlayer2Win = DidThrowWin(player2, player1);

                // Adds 1 to player 1 wins, player 2 wins, or the tie total
                if (didPlayer1Win == true) {
                    player1WinsTotal += 1;
                } else if (didPlayer2Win == true) {
                    player2WinsTotal += 1;
                } else if (didPlayer1Win == false && didPlayer2Win == false) {
                    tieTotal += 1;
                }
            }
            
            // Shows the calculated numbers in the output labels
            ShowOutputLabels();
            
            // Outputs the statistics for who won depending on the total wins of the two players
            if (player1WinsTotal > player2WinsTotal) {
                lblWhoWonStatistics.Text = "Игрок 1 выиграл!\r\n" + "Выиграл " + player1WinsTotal.ToString("n0") + 
                    " / " + gamesPlayed.ToString("n0");
            } else if (player2WinsTotal > player1WinsTotal) {
                lblWhoWonStatistics.Text = "Игрок 2 выиграл!\r\n" + "Выиграл " + player2WinsTotal.ToString("n0") + 
                    " / " + gamesPlayed.ToString("n0");
            } else if (player1WinsTotal == player2WinsTotal) {
                lblWhoWonStatistics.Text = "Ничья!\r\nИграть ещё\r\nдо победы." + 
                    "Tie " + tieTotal.ToString("n0") + " / " + gamesPlayed.ToString("n0");
            }
        }

        /// <summary>
        /// The player 1 picks an rock, paper, or scissors and player 2 throws are randomized to create a player vs computer game
        /// </summary>
        /// <param name="player1Throw">the roll of player 1</param>
        private void Throw(int player1Throw) {
            // Adds 1 to the number of games played
            gamesPlayed += 1;
            
            // Assigning the roll of the user to player 1
            int player1 = player1Throw;
            
            // Randomizes the throw and assigns the throw to the field variable
            int player2 = GetRandomThrow();
            player2Roll = player2;

            // Determines of player 1 or player 2 won
            bool didPlayer1Win = DidThrowWin(player1, player2);
            bool didPlayer2Win = DidThrowWin(player2, player1);

            // Outputs the statistics for who won the game between the two players
            if (didPlayer1Win) {
                player1WinsTotal += 1;
                lblWhoWonStatistics.Text = "Игрок 1 бросил " + (Rolls)player1Roll + ".\r\nИгрок 2 бросил " + 
                    (Rolls)player2Roll + ".\r\nИгрок 1 выиграл!\r\n" + "Выиграл " + player1WinsTotal.ToString("n0") + 
                    " / " + gamesPlayed.ToString("n0");
            } else if (didPlayer2Win) {
                player2WinsTotal += 1;
                lblWhoWonStatistics.Text = "Игрок 1 бросил " + (Rolls)player1Roll + ".\r\nИгрок 2 бросил " + 
                    (Rolls)player2Roll + ".\r\nPlayer 2 выиграл!\r\n" + "Выиграл " + player2WinsTotal.ToString("n0") + 
                    " / " + gamesPlayed.ToString("n0");
            } else if (!didPlayer1Win && !didPlayer2Win) {
                tieTotal += 1;
                lblWhoWonStatistics.Text = "Игрок 1 бросил " + (Rolls)player1Roll + ".\r\nИгрок 2 бросил " + 
                    (Rolls)player2Roll + ".\r\nничья!\r\n" + "ничья " + tieTotal.ToString("n0") + " / " + 
                    gamesPlayed.ToString("n0");
            }
            
            // Shows the calculated numbers in the output labels
            ShowOutputLabels();
        }

        /// <summary>
        /// Player 1  and 2 pick an rock, paper, or scissors  to create a player vs player game
        /// </summary>
        /// <param name="player1Throw">the roll of player 1</param>
        /// <param name="player2Throw">the roll of player 2</param>
        private void Throw(int player1Throw, int player2Throw) {
            // Adds 1 to the number of games played
            gamesPlayed += 1;

            // Assigning the roll of the player 1 and player 2
            int player1 = player1Throw;
            int player2 = player2Throw;

            // Determines of player 1 or player 2 won
            bool didPlayer1Win = DidThrowWin(player1, player2);
            bool didPlayer2Win = DidThrowWin(player2, player1);

            // Outputs the statistics for who won the game between the two players
            if (didPlayer1Win) {
                player1WinsTotal += 1;
                lblWhoWonStatistics.Text = "Игрок 1 бросил " + (Rolls)player1Roll + ".\r\nИгрок 2 бросил " + 
                    (Rolls)player2Roll + ".\r\nИгрок 1 выигрывает!\r\n" + "выиграл " + player1WinsTotal.ToString("n0") + 
                    " / " + gamesPlayed.ToString("n0");
            } else if (didPlayer2Win) {
                player2WinsTotal += 1;
                lblWhoWonStatistics.Text = "Игрок 1 бросил " + (Rolls)player1Roll + ".\r\nИгрок 2 бросил " +
                    (Rolls)player2Roll + ".\r\nИгрок 2 выигрывает!\r\n" + "выиграл " + player2WinsTotal.ToString("n0") + 
                    " / " + gamesPlayed.ToString("n0");
            } else if (!didPlayer1Win && !didPlayer2Win) {
                tieTotal += 1;
                lblWhoWonStatistics.Text = "Игрок 1 бросил " + (Rolls)player1Roll + ".\r\nИгрок 2 бросил " +
                    (Rolls)player2Roll + ".\r\nничья!\r\n" + "ничья " + tieTotal.ToString("n0") + " / " + 
                    gamesPlayed.ToString("n0");
            }
            
            // Shows the calculated numbers in the output labels
            ShowOutputLabels();
        }

        /// <summary>
        /// Determines if a player wins rock, paper, scissors
        /// </summary>
        /// <param name="player1Throw">the roll of player 1</param>
        /// <param name="player2Throw">the roll of player 2</param>
        /// <returns>true if player 1 wins</returns>
        private bool DidThrowWin(int player1Throw, int player2Throw) {
            // returns true for all the possibilities of player 1 winning rock, paper, scissor
            return ((player1Throw == (int)Rolls.Paper && player2Throw == (int)Rolls.Rock) ||
                (player1Throw == (int)Rolls.Scissors && player2Throw == (int)Rolls.Paper) ||
                (player1Throw == (int)Rolls.Rock && player2Throw == (int)Rolls.Scissors));
        }

        /// <summary>
        /// Clears the labels on the GUI
        /// </summary>
        private void ClearLabels() {
            lblWhoWonStatistics.Text = "";
            lblTotalGamesPlayed.Text = "";
            lblTotalPlayer1Wins.Text = "";
            lblTotalPlayer2Wins.Text = "";
            lblOutputTieGames.Text = "";
        }

        /// <summary>
        /// Resets the trackbar 
        /// </summary>
        private void ClearTrackbar() {
            trNumberOfGames.Value = 10;
            lblPickedNumberOfGames.Text = "";
        }

        /// <summary>
        /// Clears the field variables
        /// </summary>
        private void ClearFieldVariables() {
            player1WinsTotal = 0;
            player2WinsTotal = 0;
            tieTotal = 0;
            gamesPlayed = 0;
        }
        /// <summary>
        /// Shows player 1's buttons for the two players game
        /// </summary>
        private void ShowPlayer1Buttons() {
            // Sets all player 1's buttons and a label to be visible on the GUI
            btn2Player1Rock.Visible = true;
            btn2Player1Paper.Visible = true;
            btn2Player1Scissors.Visible = true;
            lblPlayer1Turn.Visible = true;

            // Sets all player 2's buttons and a label to be invisible on the GUI
            btn2Player2Rock.Visible = false;
            btn2Player2Paper.Visible = false;
            btn2Player2Scissors.Visible = false;
            lblPlayer2Turn.Visible = false;

            // Sets the Play Game button to be invisible on the GUI
            btnTwoPlayersPlayGame.Visible = false;
        }

        /// <summary>
        /// Shows player 2's buttons for the two players game
        /// </summary>
        private void ShowPlayer2Buttons() {
            // Sets all player 1's buttons and a label to be invisible on the GUI
            btn2Player1Rock.Visible = false;
            btn2Player1Paper.Visible = false;
            btn2Player1Scissors.Visible = false;
            lblPlayer1Turn.Visible = false;

            // Sets all player 2's buttons and a label to be visible on the GUI
            btn2Player2Rock.Visible = true;
            btn2Player2Paper.Visible = true;
            btn2Player2Scissors.Visible = true;
            lblPlayer2Turn.Visible = true;
        }

        /// <summary>
        /// Shows no players' button  for the two players game
        /// </summary>
        private void ShowNoPlayerButtons() {
            // Sets all player 1's buttons and a label to be invisible on the GUI
            btn2Player1Rock.Visible = false;
            btn2Player1Paper.Visible = false;
            btn2Player1Scissors.Visible = false;
            lblPlayer1Turn.Visible = false;

            // Sets all player 2's buttons and a label to be invisible on the GUI
            btn2Player2Rock.Visible = false;
            btn2Player2Paper.Visible = false;
            btn2Player2Scissors.Visible = false;
            lblPlayer2Turn.Visible = false;

            // Sets the Play Game button to be visible on the GUI
            btnTwoPlayersPlayGame.Visible = true;
        }

        /// <summary>
        /// Calculates whether the user who picked rock won the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOnePlayerRock_Click(object sender, EventArgs e) {
            // Assigns rock to the player 1 roll field variable
            player1Roll = (int)Rolls.Rock;
            // Calculates the player picking rock vs the computer game
            Throw(player1Roll);
        }

        /// <summary>
        /// Calculates whether the user who picked paper won the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOnePlayerPaper_Click(object sender, EventArgs e) {
            // Assigns paper to the player 1 roll field variable
            player1Roll = (int)Rolls.Paper;
            // Calculates the player picking paper vs the computer game
            Throw(player1Roll);
        }

        /// <summary>
        /// Calculates whether the user who picked scissors won the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOnePlayerScissors_Click(object sender, EventArgs e) {
            // Assigns scissors to the player 1 roll field variable
            player1Roll = (int)Rolls.Scissors;
            // Calculates the player picking scissors vs the computer game
            Throw(player1Roll);
        }

        /// <summary>
        /// Shows the number of games from the trackbar in a label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trNumberOfGames_Scroll(object sender, EventArgs e) {
            // Gets trackbar value and outputs the value in the label
            int trackbar = trNumberOfGames.Value;
            lblPickedNumberOfGames.Text = trackbar.ToString("n0");
            // assigns the value from the trackbar to the number of games played
            gamesPlayed = trackbar;
        }

        /// <summary>
        /// Calculates the computer vs. computer games
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlayGames_Click(object sender, EventArgs e) {           
            Throw();          
        }

        /// <summary>
        /// Calculates the player 1 vs. player 2 game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTwoPlayersPlayGame_MouseClick(object sender, MouseEventArgs e) {
            // Player 1  and 2 pick an rock, paper, or scissors  to create a player vs player game
            Throw(player1Roll, player2Roll);
            // Shows player 1's buttons for the two players game to the play again
            ShowPlayer1Buttons();
        }

        /// <summary>
        /// Clears the labels, trackbar, and field variables
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e) {
            ClearLabels();
            ClearTrackbar();
            ClearFieldVariables();                       
        }

        /// <summary>
        /// Closes the GUI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        /// <summary>
        /// Clears the labels, trackbar, and field variables when the user clicks to a different tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tcHowMayPlayers_SelectedIndexChanged(object sender, EventArgs e) {
            btnClear.PerformClick();
        }

        /// <summary>
        /// Assigns player 1's pick to rock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn2Player1Rock_Click(object sender, EventArgs e) {
            player1Roll = (int)Rolls.Rock;
            // Shows player 2's buttons and hides player 1's buttons
            ShowPlayer2Buttons();


        }

        /// <summary>
        /// Assigns player 1's pick to paper
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn2Player1Paper_Click(object sender, EventArgs e) {
            player1Roll = (int)Rolls.Paper;
            // Shows player 2's buttons and hides player 1's buttons
            ShowPlayer2Buttons();
        }

        /// <summary>
        /// Assigns player 1's pick to scissors
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn2Player1Scissors_Click(object sender, EventArgs e) {
            player1Roll = (int)Rolls.Scissors;
            // Shows player 2's buttons and hides player 1's buttons
            ShowPlayer2Buttons();
        }

        /// <summary>
        /// Assigns player 2's pick to rock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn2Player2Rock_Click(object sender, EventArgs e) {
            player2Roll = (int)Rolls.Rock;
            // Shows no players' buttons
            ShowNoPlayerButtons();
        }

        /// <summary>
        /// Assigns player 2's pick to paper
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn2Player2Paper_Click(object sender, EventArgs e) {
            player2Roll = (int)Rolls.Paper;
            // Shows no players' buttons
            ShowNoPlayerButtons();
        }

        /// <summary>
        /// Assigns player 2's pick to scissors
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn2Player2Scissors_Click(object sender, EventArgs e) {
            player2Roll = (int)Rolls.Scissors;
            // Shows no players' buttons
            ShowNoPlayerButtons();
        }

        private void frmRockPaperScissors_Load(object sender, EventArgs e)
        {

        }

        private void lblPlayer1Wins_Click(object sender, EventArgs e)
        {

        }

        private void lblWhoWonStatistics_Click(object sender, EventArgs e)
        {

        }
    }
}
