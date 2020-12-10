namespace RockPaperScissors {
    partial class frmRockPaperScissors {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tcHowManyPlayers = new System.Windows.Forms.TabControl();
            this.tpOnePlayer = new System.Windows.Forms.TabPage();
            this.btnOnePlayerScissors = new System.Windows.Forms.Button();
            this.btnOnePlayerPaper = new System.Windows.Forms.Button();
            this.btnOnePlayerRock = new System.Windows.Forms.Button();
            this.tpTwoPlayers = new System.Windows.Forms.TabPage();
            this.btn2Player2Scissors = new System.Windows.Forms.Button();
            this.btn2Player2Paper = new System.Windows.Forms.Button();
            this.btn2Player2Rock = new System.Windows.Forms.Button();
            this.btnTwoPlayersPlayGame = new System.Windows.Forms.Button();
            this.lblPlayer2Turn = new System.Windows.Forms.Label();
            this.lblPlayer1Turn = new System.Windows.Forms.Label();
            this.btn2Player1Scissors = new System.Windows.Forms.Button();
            this.btn2Player1Paper = new System.Windows.Forms.Button();
            this.btn2Player1Rock = new System.Windows.Forms.Button();
            this.tpAutomaticGames = new System.Windows.Forms.TabPage();
            this.lblNumberOfGames = new System.Windows.Forms.Label();
            this.btnComputerPlayGames = new System.Windows.Forms.Button();
            this.lblPickedNumberOfGames = new System.Windows.Forms.Label();
            this.trNumberOfGames = new System.Windows.Forms.TrackBar();
            this.lblPlayer1Wins = new System.Windows.Forms.Label();
            this.lblPlayer2Wins = new System.Windows.Forms.Label();
            this.lblTotalPlayer1Wins = new System.Windows.Forms.Label();
            this.lblTotalPlayer2Wins = new System.Windows.Forms.Label();
            this.lblGamesPlayed = new System.Windows.Forms.Label();
            this.lblTotalGamesPlayed = new System.Windows.Forms.Label();
            this.lblWhoWonStatistics = new System.Windows.Forms.Label();
            this.lblTie = new System.Windows.Forms.Label();
            this.lblOutputTieGames = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.tcHowManyPlayers.SuspendLayout();
            this.tpOnePlayer.SuspendLayout();
            this.tpTwoPlayers.SuspendLayout();
            this.tpAutomaticGames.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trNumberOfGames)).BeginInit();
            this.SuspendLayout();
            // 
            // tcHowManyPlayers
            // 
            this.tcHowManyPlayers.Controls.Add(this.tpOnePlayer);
            this.tcHowManyPlayers.Controls.Add(this.tpTwoPlayers);
            this.tcHowManyPlayers.Controls.Add(this.tpAutomaticGames);
            this.tcHowManyPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcHowManyPlayers.Location = new System.Drawing.Point(12, 12);
            this.tcHowManyPlayers.Name = "tcHowManyPlayers";
            this.tcHowManyPlayers.SelectedIndex = 0;
            this.tcHowManyPlayers.Size = new System.Drawing.Size(518, 203);
            this.tcHowManyPlayers.TabIndex = 0;
            this.tcHowManyPlayers.Tag = "";
            this.tcHowManyPlayers.SelectedIndexChanged += new System.EventHandler(this.tcHowMayPlayers_SelectedIndexChanged);
            // 
            // tpOnePlayer
            // 
            this.tpOnePlayer.AccessibleName = "";
            this.tpOnePlayer.Controls.Add(this.btnOnePlayerScissors);
            this.tpOnePlayer.Controls.Add(this.btnOnePlayerPaper);
            this.tpOnePlayer.Controls.Add(this.btnOnePlayerRock);
            this.tpOnePlayer.Location = new System.Drawing.Point(4, 22);
            this.tpOnePlayer.Name = "tpOnePlayer";
            this.tpOnePlayer.Padding = new System.Windows.Forms.Padding(3);
            this.tpOnePlayer.Size = new System.Drawing.Size(510, 177);
            this.tpOnePlayer.TabIndex = 0;
            this.tpOnePlayer.Text = "Один игрок";
            this.tpOnePlayer.UseVisualStyleBackColor = true;
            // 
            // btnOnePlayerScissors
            // 
            this.btnOnePlayerScissors.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnePlayerScissors.Location = new System.Drawing.Point(336, 38);
            this.btnOnePlayerScissors.Name = "btnOnePlayerScissors";
            this.btnOnePlayerScissors.Size = new System.Drawing.Size(150, 100);
            this.btnOnePlayerScissors.TabIndex = 2;
            this.btnOnePlayerScissors.Text = "Ножницы";
            this.btnOnePlayerScissors.UseVisualStyleBackColor = true;
            this.btnOnePlayerScissors.Click += new System.EventHandler(this.btnOnePlayerScissors_Click);
            // 
            // btnOnePlayerPaper
            // 
            this.btnOnePlayerPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnePlayerPaper.Location = new System.Drawing.Point(180, 38);
            this.btnOnePlayerPaper.Name = "btnOnePlayerPaper";
            this.btnOnePlayerPaper.Size = new System.Drawing.Size(150, 100);
            this.btnOnePlayerPaper.TabIndex = 1;
            this.btnOnePlayerPaper.Text = "Бумага";
            this.btnOnePlayerPaper.UseVisualStyleBackColor = true;
            this.btnOnePlayerPaper.Click += new System.EventHandler(this.btnOnePlayerPaper_Click);
            // 
            // btnOnePlayerRock
            // 
            this.btnOnePlayerRock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnePlayerRock.Location = new System.Drawing.Point(24, 38);
            this.btnOnePlayerRock.Name = "btnOnePlayerRock";
            this.btnOnePlayerRock.Size = new System.Drawing.Size(150, 100);
            this.btnOnePlayerRock.TabIndex = 0;
            this.btnOnePlayerRock.Text = "Камень";
            this.btnOnePlayerRock.UseVisualStyleBackColor = true;
            this.btnOnePlayerRock.Click += new System.EventHandler(this.btnOnePlayerRock_Click);
            // 
            // tpTwoPlayers
            // 
            this.tpTwoPlayers.Controls.Add(this.btn2Player2Scissors);
            this.tpTwoPlayers.Controls.Add(this.btn2Player2Paper);
            this.tpTwoPlayers.Controls.Add(this.btn2Player2Rock);
            this.tpTwoPlayers.Controls.Add(this.btnTwoPlayersPlayGame);
            this.tpTwoPlayers.Controls.Add(this.lblPlayer2Turn);
            this.tpTwoPlayers.Controls.Add(this.lblPlayer1Turn);
            this.tpTwoPlayers.Controls.Add(this.btn2Player1Scissors);
            this.tpTwoPlayers.Controls.Add(this.btn2Player1Paper);
            this.tpTwoPlayers.Controls.Add(this.btn2Player1Rock);
            this.tpTwoPlayers.Location = new System.Drawing.Point(4, 22);
            this.tpTwoPlayers.Name = "tpTwoPlayers";
            this.tpTwoPlayers.Padding = new System.Windows.Forms.Padding(3);
            this.tpTwoPlayers.Size = new System.Drawing.Size(510, 177);
            this.tpTwoPlayers.TabIndex = 1;
            this.tpTwoPlayers.Text = "Два игрока";
            this.tpTwoPlayers.UseVisualStyleBackColor = true;
            // 
            // btn2Player2Scissors
            // 
            this.btn2Player2Scissors.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Player2Scissors.Location = new System.Drawing.Point(339, 97);
            this.btn2Player2Scissors.Name = "btn2Player2Scissors";
            this.btn2Player2Scissors.Size = new System.Drawing.Size(150, 35);
            this.btn2Player2Scissors.TabIndex = 8;
            this.btn2Player2Scissors.Text = "Ножницы";
            this.btn2Player2Scissors.UseVisualStyleBackColor = true;
            this.btn2Player2Scissors.Visible = false;
            this.btn2Player2Scissors.Click += new System.EventHandler(this.btn2Player2Scissors_Click);
            // 
            // btn2Player2Paper
            // 
            this.btn2Player2Paper.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Player2Paper.Location = new System.Drawing.Point(339, 56);
            this.btn2Player2Paper.Name = "btn2Player2Paper";
            this.btn2Player2Paper.Size = new System.Drawing.Size(150, 35);
            this.btn2Player2Paper.TabIndex = 7;
            this.btn2Player2Paper.Text = "Бумага";
            this.btn2Player2Paper.UseVisualStyleBackColor = true;
            this.btn2Player2Paper.Visible = false;
            this.btn2Player2Paper.Click += new System.EventHandler(this.btn2Player2Paper_Click);
            // 
            // btn2Player2Rock
            // 
            this.btn2Player2Rock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Player2Rock.Location = new System.Drawing.Point(339, 15);
            this.btn2Player2Rock.Name = "btn2Player2Rock";
            this.btn2Player2Rock.Size = new System.Drawing.Size(150, 35);
            this.btn2Player2Rock.TabIndex = 6;
            this.btn2Player2Rock.Text = "Камень";
            this.btn2Player2Rock.UseVisualStyleBackColor = true;
            this.btn2Player2Rock.Visible = false;
            this.btn2Player2Rock.Click += new System.EventHandler(this.btn2Player2Rock_Click);
            // 
            // btnTwoPlayersPlayGame
            // 
            this.btnTwoPlayersPlayGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwoPlayersPlayGame.Location = new System.Drawing.Point(201, 144);
            this.btnTwoPlayersPlayGame.Name = "btnTwoPlayersPlayGame";
            this.btnTwoPlayersPlayGame.Size = new System.Drawing.Size(100, 25);
            this.btnTwoPlayersPlayGame.TabIndex = 5;
            this.btnTwoPlayersPlayGame.Text = "Играть";
            this.btnTwoPlayersPlayGame.UseVisualStyleBackColor = true;
            this.btnTwoPlayersPlayGame.Visible = false;
            this.btnTwoPlayersPlayGame.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnTwoPlayersPlayGame_MouseClick);
            // 
            // lblPlayer2Turn
            // 
            this.lblPlayer2Turn.AutoSize = true;
            this.lblPlayer2Turn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2Turn.Location = new System.Drawing.Point(359, 148);
            this.lblPlayer2Turn.Name = "lblPlayer2Turn";
            this.lblPlayer2Turn.Size = new System.Drawing.Size(97, 16);
            this.lblPlayer2Turn.TabIndex = 4;
            this.lblPlayer2Turn.Text = "Игрок 2 ходит";
            this.lblPlayer2Turn.Visible = false;
            // 
            // lblPlayer1Turn
            // 
            this.lblPlayer1Turn.AutoSize = true;
            this.lblPlayer1Turn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Turn.Location = new System.Drawing.Point(47, 148);
            this.lblPlayer1Turn.Name = "lblPlayer1Turn";
            this.lblPlayer1Turn.Size = new System.Drawing.Size(97, 16);
            this.lblPlayer1Turn.TabIndex = 3;
            this.lblPlayer1Turn.Text = "Игрок 1 ходит";
            // 
            // btn2Player1Scissors
            // 
            this.btn2Player1Scissors.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Player1Scissors.Location = new System.Drawing.Point(24, 97);
            this.btn2Player1Scissors.Name = "btn2Player1Scissors";
            this.btn2Player1Scissors.Size = new System.Drawing.Size(150, 35);
            this.btn2Player1Scissors.TabIndex = 2;
            this.btn2Player1Scissors.Text = "Ножницы";
            this.btn2Player1Scissors.UseVisualStyleBackColor = true;
            this.btn2Player1Scissors.Click += new System.EventHandler(this.btn2Player1Scissors_Click);
            // 
            // btn2Player1Paper
            // 
            this.btn2Player1Paper.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Player1Paper.Location = new System.Drawing.Point(24, 56);
            this.btn2Player1Paper.Name = "btn2Player1Paper";
            this.btn2Player1Paper.Size = new System.Drawing.Size(150, 35);
            this.btn2Player1Paper.TabIndex = 1;
            this.btn2Player1Paper.Text = "Бумага";
            this.btn2Player1Paper.UseVisualStyleBackColor = true;
            this.btn2Player1Paper.Click += new System.EventHandler(this.btn2Player1Paper_Click);
            // 
            // btn2Player1Rock
            // 
            this.btn2Player1Rock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Player1Rock.Location = new System.Drawing.Point(24, 15);
            this.btn2Player1Rock.Name = "btn2Player1Rock";
            this.btn2Player1Rock.Size = new System.Drawing.Size(150, 35);
            this.btn2Player1Rock.TabIndex = 0;
            this.btn2Player1Rock.Text = "Камень";
            this.btn2Player1Rock.UseVisualStyleBackColor = true;
            this.btn2Player1Rock.Click += new System.EventHandler(this.btn2Player1Rock_Click);
            // 
            // tpAutomaticGames
            // 
            this.tpAutomaticGames.Controls.Add(this.lblNumberOfGames);
            this.tpAutomaticGames.Controls.Add(this.btnComputerPlayGames);
            this.tpAutomaticGames.Controls.Add(this.lblPickedNumberOfGames);
            this.tpAutomaticGames.Controls.Add(this.trNumberOfGames);
            this.tpAutomaticGames.Location = new System.Drawing.Point(4, 22);
            this.tpAutomaticGames.Name = "tpAutomaticGames";
            this.tpAutomaticGames.Padding = new System.Windows.Forms.Padding(3);
            this.tpAutomaticGames.Size = new System.Drawing.Size(510, 177);
            this.tpAutomaticGames.TabIndex = 2;
            this.tpAutomaticGames.Text = "Автоматическая игра";
            this.tpAutomaticGames.UseVisualStyleBackColor = true;
            // 
            // lblNumberOfGames
            // 
            this.lblNumberOfGames.AutoSize = true;
            this.lblNumberOfGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfGames.Location = new System.Drawing.Point(182, 75);
            this.lblNumberOfGames.Name = "lblNumberOfGames";
            this.lblNumberOfGames.Size = new System.Drawing.Size(114, 16);
            this.lblNumberOfGames.TabIndex = 3;
            this.lblNumberOfGames.Text = "Количество игр:";
            // 
            // btnComputerPlayGames
            // 
            this.btnComputerPlayGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComputerPlayGames.Location = new System.Drawing.Point(197, 120);
            this.btnComputerPlayGames.Name = "btnComputerPlayGames";
            this.btnComputerPlayGames.Size = new System.Drawing.Size(100, 25);
            this.btnComputerPlayGames.TabIndex = 2;
            this.btnComputerPlayGames.Text = "Играть";
            this.btnComputerPlayGames.UseVisualStyleBackColor = true;
            this.btnComputerPlayGames.Click += new System.EventHandler(this.btnPlayGames_Click);
            // 
            // lblPickedNumberOfGames
            // 
            this.lblPickedNumberOfGames.AutoSize = true;
            this.lblPickedNumberOfGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPickedNumberOfGames.Location = new System.Drawing.Point(306, 75);
            this.lblPickedNumberOfGames.Name = "lblPickedNumberOfGames";
            this.lblPickedNumberOfGames.Size = new System.Drawing.Size(0, 16);
            this.lblPickedNumberOfGames.TabIndex = 1;
            // 
            // trNumberOfGames
            // 
            this.trNumberOfGames.Location = new System.Drawing.Point(13, 17);
            this.trNumberOfGames.Maximum = 10000;
            this.trNumberOfGames.Minimum = 10;
            this.trNumberOfGames.Name = "trNumberOfGames";
            this.trNumberOfGames.Size = new System.Drawing.Size(483, 45);
            this.trNumberOfGames.TabIndex = 0;
            this.trNumberOfGames.Value = 10;
            this.trNumberOfGames.Scroll += new System.EventHandler(this.trNumberOfGames_Scroll);
            // 
            // lblPlayer1Wins
            // 
            this.lblPlayer1Wins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Wins.Location = new System.Drawing.Point(60, 227);
            this.lblPlayer1Wins.Name = "lblPlayer1Wins";
            this.lblPlayer1Wins.Size = new System.Drawing.Size(100, 16);
            this.lblPlayer1Wins.TabIndex = 1;
            this.lblPlayer1Wins.Text = "Игрок 1 победы";
            this.lblPlayer1Wins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPlayer1Wins.Click += new System.EventHandler(this.lblPlayer1Wins_Click);
            // 
            // lblPlayer2Wins
            // 
            this.lblPlayer2Wins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2Wins.Location = new System.Drawing.Point(375, 227);
            this.lblPlayer2Wins.Name = "lblPlayer2Wins";
            this.lblPlayer2Wins.Size = new System.Drawing.Size(100, 16);
            this.lblPlayer2Wins.TabIndex = 2;
            this.lblPlayer2Wins.Text = "Игрок 2 победы";
            this.lblPlayer2Wins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalPlayer1Wins
            // 
            this.lblTotalPlayer1Wins.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPlayer1Wins.Location = new System.Drawing.Point(60, 255);
            this.lblTotalPlayer1Wins.Name = "lblTotalPlayer1Wins";
            this.lblTotalPlayer1Wins.Size = new System.Drawing.Size(100, 35);
            this.lblTotalPlayer1Wins.TabIndex = 3;
            this.lblTotalPlayer1Wins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalPlayer2Wins
            // 
            this.lblTotalPlayer2Wins.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPlayer2Wins.Location = new System.Drawing.Point(375, 255);
            this.lblTotalPlayer2Wins.Name = "lblTotalPlayer2Wins";
            this.lblTotalPlayer2Wins.Size = new System.Drawing.Size(100, 35);
            this.lblTotalPlayer2Wins.TabIndex = 4;
            this.lblTotalPlayer2Wins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGamesPlayed
            // 
            this.lblGamesPlayed.AutoSize = true;
            this.lblGamesPlayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGamesPlayed.Location = new System.Drawing.Point(193, 389);
            this.lblGamesPlayed.Name = "lblGamesPlayed";
            this.lblGamesPlayed.Size = new System.Drawing.Size(68, 16);
            this.lblGamesPlayed.TabIndex = 5;
            this.lblGamesPlayed.Text = "Раундов:";
            // 
            // lblTotalGamesPlayed
            // 
            this.lblTotalGamesPlayed.AutoSize = true;
            this.lblTotalGamesPlayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGamesPlayed.Location = new System.Drawing.Point(306, 393);
            this.lblTotalGamesPlayed.Name = "lblTotalGamesPlayed";
            this.lblTotalGamesPlayed.Size = new System.Drawing.Size(0, 16);
            this.lblTotalGamesPlayed.TabIndex = 6;
            // 
            // lblWhoWonStatistics
            // 
            this.lblWhoWonStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhoWonStatistics.Location = new System.Drawing.Point(168, 308);
            this.lblWhoWonStatistics.Name = "lblWhoWonStatistics";
            this.lblWhoWonStatistics.Size = new System.Drawing.Size(195, 76);
            this.lblWhoWonStatistics.TabIndex = 7;
            this.lblWhoWonStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWhoWonStatistics.Click += new System.EventHandler(this.lblWhoWonStatistics_Click);
            // 
            // lblTie
            // 
            this.lblTie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTie.Location = new System.Drawing.Point(216, 227);
            this.lblTie.Name = "lblTie";
            this.lblTie.Size = new System.Drawing.Size(100, 16);
            this.lblTie.TabIndex = 8;
            this.lblTie.Text = "Ничьи";
            this.lblTie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutputTieGames
            // 
            this.lblOutputTieGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputTieGames.Location = new System.Drawing.Point(216, 255);
            this.lblOutputTieGames.Name = "lblOutputTieGames";
            this.lblOutputTieGames.Size = new System.Drawing.Size(100, 35);
            this.lblOutputTieGames.TabIndex = 9;
            this.lblOutputTieGames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(29, 389);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 25);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Сброс";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(412, 389);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 25);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // frmRockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 428);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblOutputTieGames);
            this.Controls.Add(this.lblTie);
            this.Controls.Add(this.lblWhoWonStatistics);
            this.Controls.Add(this.lblTotalGamesPlayed);
            this.Controls.Add(this.lblGamesPlayed);
            this.Controls.Add(this.lblTotalPlayer2Wins);
            this.Controls.Add(this.lblTotalPlayer1Wins);
            this.Controls.Add(this.lblPlayer2Wins);
            this.Controls.Add(this.lblPlayer1Wins);
            this.Controls.Add(this.tcHowManyPlayers);
            this.Name = "frmRockPaperScissors";
            this.Text = "Rock - Paper - Scissors";
            this.Load += new System.EventHandler(this.frmRockPaperScissors_Load);
            this.tcHowManyPlayers.ResumeLayout(false);
            this.tpOnePlayer.ResumeLayout(false);
            this.tpTwoPlayers.ResumeLayout(false);
            this.tpTwoPlayers.PerformLayout();
            this.tpAutomaticGames.ResumeLayout(false);
            this.tpAutomaticGames.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trNumberOfGames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcHowManyPlayers;
        private System.Windows.Forms.TabPage tpOnePlayer;
        private System.Windows.Forms.TabPage tpTwoPlayers;
        private System.Windows.Forms.TabPage tpAutomaticGames;
        private System.Windows.Forms.Button btnOnePlayerScissors;
        private System.Windows.Forms.Button btnOnePlayerPaper;
        private System.Windows.Forms.Button btnOnePlayerRock;
        private System.Windows.Forms.Label lblNumberOfGames;
        private System.Windows.Forms.Button btnComputerPlayGames;
        private System.Windows.Forms.Label lblPickedNumberOfGames;
        private System.Windows.Forms.TrackBar trNumberOfGames;
        private System.Windows.Forms.Label lblPlayer1Wins;
        private System.Windows.Forms.Label lblPlayer2Wins;
        private System.Windows.Forms.Label lblTotalPlayer1Wins;
        private System.Windows.Forms.Label lblTotalPlayer2Wins;
        private System.Windows.Forms.Label lblPlayer2Turn;
        private System.Windows.Forms.Label lblPlayer1Turn;
        private System.Windows.Forms.Button btn2Player1Scissors;
        private System.Windows.Forms.Button btn2Player1Paper;
        private System.Windows.Forms.Button btn2Player1Rock;
        private System.Windows.Forms.Label lblGamesPlayed;
        private System.Windows.Forms.Label lblTotalGamesPlayed;
        private System.Windows.Forms.Label lblWhoWonStatistics;
        private System.Windows.Forms.Button btnTwoPlayersPlayGame;
        private System.Windows.Forms.Label lblTie;
        private System.Windows.Forms.Label lblOutputTieGames;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btn2Player2Scissors;
        private System.Windows.Forms.Button btn2Player2Paper;
        private System.Windows.Forms.Button btn2Player2Rock;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
    }
}

